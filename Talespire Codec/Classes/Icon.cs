using Newtonsoft.Json;
using System;
using System.Drawing;

namespace Talespire_Converter
{
    [Serializable]
    public class Icon
    {
        [JsonProperty("AtlasIndex")]
        public int AtlasIndex { get; set; }

        [JsonProperty("Region")]
        public Region Region { get; set; }

        public Image Image { get; set; }

    }
}