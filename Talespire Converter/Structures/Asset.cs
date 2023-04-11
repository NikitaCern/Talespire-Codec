using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talespire_Converter
{
    [Serializable]
    public class Asset
    {
        public string uuid { get; set; }
        public int instanceCount { get; set; }
        public List<Position> instances { get; set; }
    };
}
