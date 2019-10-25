using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace lab08_linq
{
    public class DataCollection
    {
        public string Type { get; set; }
        public IList<Feature> features { get; set; }

        public DataCollection(string type, IList<Feature> feature)
        {
            Type = type;
            features = feature;
        }
    }
}
