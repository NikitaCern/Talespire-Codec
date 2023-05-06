using Newtonsoft.Json;
using System.Collections.Generic;

namespace Talespire_Converter.Classes
{
    public class Map
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Tiles")]
        public List<Tile> Tiles { get; set; }

        [JsonProperty("Props")]
        public List<Prop> Props { get; set; }

        [JsonProperty("IconsAtlases")]
        public List<IconAtlasPath> Icons { get; set; }
        //public void PopulateWithImages()
        //{

        //    foreach (var tile in Tiles)
        //    {

        //    }

        //}
    }
}
