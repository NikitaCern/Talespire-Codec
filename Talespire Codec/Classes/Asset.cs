using Newtonsoft.Json;
using System;

namespace Talespire_Converter.Classes
{
    [Serializable]
    public class Asset
    {
        [JsonProperty("LoaderData")]
        public LoaderData LoaderData { get; set; }

        [JsonProperty("Position")]
        public Float3 Position { get; set; }

        [JsonProperty("Rotation")]
        public Float4 Rotation { get; set; }

        [JsonProperty("Scale")]
        public Float3 Scale { get; set; }
    }
}
