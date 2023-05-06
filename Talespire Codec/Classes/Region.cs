using Newtonsoft.Json;
using System;

namespace Talespire_Converter
{
    [Serializable]
    public class Region
    {
        [JsonProperty("serializedVersion")]
        public string Version { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("width")]
        public float Width { get; set; }

        [JsonProperty("height")]
        public float Height { get; set; }
    }
}