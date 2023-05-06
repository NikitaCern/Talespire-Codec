using Newtonsoft.Json;
using System;

namespace Talespire_Converter.Classes
{
    [Serializable]
    public class LoaderData
    {
        [JsonProperty("BundleId")]
        public string BundleId { get; set; }

        [JsonProperty("AssetName")]
        public string AssetName { get; set; }
    }
}