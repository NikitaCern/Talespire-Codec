using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talespire_Converter
{
    [Serializable]
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int r { get; set; }
    };
}
