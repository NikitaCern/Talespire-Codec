using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using Talespire_Converter.Classes;

namespace Talespire_Converter
{
    public static class ObjectReader
    {
        public static Map ReadJson(string Filepath)
        {
            var path = Path.Combine(Filepath, "index.json");
            var json = File.ReadAllText(path);
            var map = JsonConvert.DeserializeObject<Map>(json);

            foreach (var atlas in map.Icons)
            {
                atlas.GetImage(Filepath);
            }

            foreach (var tile in map.Tiles)
            {
                GetImages(map, tile);
            }

            foreach (var props in map.Props)
            {
                GetImages(map, props);
            }
            return map;
        }

        private static void GetImages(Map map, Tile tile)
        {
            var width = map.Icons[tile.Icon.AtlasIndex].Image.Width;
            var height = map.Icons[tile.Icon.AtlasIndex].Image.Height;

            var cropRectangle = new Rectangle(
                        (int)(tile.Icon.Region.X * width),
                        (int)(tile.Icon.Region.Y * height),
                        (int)(tile.Icon.Region.Width * width),
                        (int)(tile.Icon.Region.Height * height)
                    );

            tile.Icon.Image = map.Icons[tile.Icon.AtlasIndex].Bitmap.Clone(
                    cropRectangle,
                    map.Icons[tile.Icon.AtlasIndex].Bitmap.PixelFormat);
        }
    }
}

