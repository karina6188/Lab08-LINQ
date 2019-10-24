using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace lab08_linq
{
    public class Feature
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }

        public Feature(string type, Geometry geometry, Properties properties)
        {
            Type = type;
            Geometry = geometry;
            Properties = properties;
        }
    }
}
