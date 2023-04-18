using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;
using System.Linq;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Talespire_Converter
{
    public class Codec
    {
        private static int listEntryLength = 20;
        private static int positionEntryLength = 8;
        private static Regex rx = new Regex(@"^```\S*```$");

        public List<Asset> Decode( string rawData )
        {
            if (string.IsNullOrEmpty(rawData)) throw new ArgumentNullException("String to decode cant be null!");
            if (!rx.IsMatch(rawData)) throw new FormatException("String doesnt match format!");

            rawData = rawData.Trim().Substring(3, rawData.Length - 6); // Remove ``` from begining and end

            byte[] data = Decompress(Convert.FromBase64String(rawData));
            byte[] header = data.Take(10).ToArray();

            int uniqueAssetCount = header[6];
            List<Asset> assetList = PopulateAssetList(data, header.Length, uniqueAssetCount);

            return assetList;
        }

        public string Encode( List<Asset> data) {

            byte[] header = new byte[] { 0xCE, 0xFA, 0xCE, 0xD1, 0x02, 0x00 };
            header = header.Concat(BitConverter.GetBytes(data.Count)).ToArray();
            byte[] rawDataAssets = null;
            byte[] rawDataPositions = null;

            foreach (var entry in data) {
                if (rawDataAssets == null) rawDataAssets = EncodeAsset(entry);
                else rawDataAssets = rawDataAssets.Concat(EncodeAsset(entry)).ToArray(); 

                if (rawDataPositions == null) rawDataPositions = EncodeAssetPosition(entry.instances);
                else rawDataPositions = rawDataPositions.Concat(EncodeAssetPosition(entry.instances)).ToArray();
            }

            byte[] rawData = header.Concat(rawDataAssets).Concat(rawDataPositions).Concat(new byte[] { 0x00, 0x00}).ToArray();

            byte[] compressed = Compress(rawData);
            string output = $"```{Convert.ToBase64String(compressed)}```";

            return output;
        }


        private List<Asset> PopulateAssetList(byte[] data, int headerLength, int uniqueAssetCount)
        {
            List<Asset> assetList = new List<Asset>();

            int position = 0 + headerLength;
            int assetPositionDataOffset = position + uniqueAssetCount * listEntryLength;

            for (int i = 0; i < uniqueAssetCount; i++)
            {
                Asset asset = DecodeAsset(data.Skip(position).Take(listEntryLength));

                var assetDataAmount = asset.instanceCount * positionEntryLength;
                asset.instances = DecodeAssetPosition(data.Skip(assetPositionDataOffset).Take(assetDataAmount).ToArray());

                assetList.Add(asset);
                position += listEntryLength;
                assetPositionDataOffset += assetDataAmount;
            }
            return assetList;
        }

        private Asset DecodeAsset(IEnumerable<byte> data)
        {
            Asset asset = new Asset();

            asset.uuid = new Guid(data.Take(16).ToArray()).ToString();
            asset.instanceCount = BitConverter.ToUInt16(data.Skip(16).Take(4).ToArray(), 0);
            asset.instances = new List<Position>();

            return asset;
        }

        private List<Position> DecodeAssetPosition(IEnumerable<byte> data)
        {
            List<Position> positions = new List<Position>();

            var positionCount = data.ToArray().Length / positionEntryLength;

            for (int i = 0; i < positionCount; i++)
            {
                var currentData = BitConverter.ToUInt64(data.Skip(i * positionEntryLength).Take(8).ToArray(), 0);

                Position position = new Position();
                position.x = (ushort) (currentData >> 0);
                position.z = (ushort) (currentData >> 18);
                position.y = (ushort) (currentData >> 36);
                position.r = (byte)   (currentData >> 54);
                positions.Add(position);
            }

            return positions;
        }

        private byte[] EncodeAsset(Asset entry)
        {
            byte[] uuid = Guid.Parse(entry.uuid).ToByteArray();
            byte[] instanceCount = BitConverter.GetBytes(entry.instanceCount);

            return uuid.Concat(instanceCount).ToArray();
        }

        public static byte[] EncodeAssetPosition(IEnumerable<Position> positions)
        {
            List<byte> result = new List<byte>();

            foreach (Position position in positions)
            {
                ulong currentData = ((ulong)position.x)
                    | (((ulong)position.z) << 18)
                    | (((ulong)position.y) << 36)
                    | (((ulong)position.r) << 54);

                result.AddRange(BitConverter.GetBytes(currentData));
            }

            return result.ToArray();
        }

        public static byte[] Decompress(byte[] input)
        {
            using (var compressedStream = new MemoryStream(input))
            using (var gzip = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var decompressedStream = new MemoryStream())
            {
                gzip.CopyTo(decompressedStream);
                return decompressedStream.ToArray();
            }
        }

        public static byte[] Compress(byte[] input)
        {
            using (var output = new MemoryStream())
            {
                using (var gzip = new GZipStream(output, CompressionMode.Compress))
                {
                    gzip.Write(input, 0, input.Length);
                    gzip.Flush();
                    
                }
                return output.ToArray();
            }
        }

    }
}
