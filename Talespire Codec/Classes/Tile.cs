using System;
using System.Collections.Generic;

namespace Talespire_Converter
{
    public class Tile
    {
        public Guid Uuid { get; set; }
        public String Name { get; set; }
        public bool IsDeprecated { get; set; }
        public string GroupTag { get; set; }
        public List<string> Tags { get; set; }
        public string Folder { get; set; }
        public Bounds bounds { get; set; }
        // Icon
    }
}
