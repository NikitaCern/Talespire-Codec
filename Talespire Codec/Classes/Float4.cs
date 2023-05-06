using Newtonsoft.Json;
using System;

namespace Talespire_Converter
{
    [Serializable]
    public class Float4
    {
        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("z")]
        public float Z { get; set; }

        [JsonProperty("w")]
        public float W { get; set; }

    }
}