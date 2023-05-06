using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Talespire_Converter.Classes;

namespace Talespire_Converter
{
    [Serializable]
    public class Tile
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("IsDeprecated")]
        public bool IsDeprecated { get; set; }

        [JsonProperty("GroupTag")]
        public string GroupTag { get; set; }

        [JsonProperty("Tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("Folder")]
        public string Folder { get; set; }

        [JsonProperty("Assets")]
        public List<Asset> Assets { get; set; }

        [JsonProperty("IsInteractable")]
        public bool IsInteractable { get; set; }

        [JsonProperty("ColliderBoundsBound")]
        public Bounds ColliderBoundsBound { get; set; }

        [JsonProperty("Icon")]
        public Icon Icon { get; set; }

    }
}
