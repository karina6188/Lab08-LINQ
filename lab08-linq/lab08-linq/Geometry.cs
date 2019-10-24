using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace lab08_linq
{
    public class Geometry
    {
        public string Type { get; set; }
        public IList<double> Coordinates { get; set; }

        public Geometry(string type, IList<double> coordinates)
        {
            Type = type;
            Coordinates = coordinates;
        }
    }
}
