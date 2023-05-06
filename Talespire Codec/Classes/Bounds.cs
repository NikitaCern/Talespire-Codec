using Newtonsoft.Json;
using System;

namespace Talespire_Converter
{
    [Serializable]
    public class Bounds
    {
        [JsonProperty("m_Center")]
        public Float3 Center { get; set; }

        [JsonProperty("m_Extent")]
        public Float3 Extents { get; set; }
    }
}