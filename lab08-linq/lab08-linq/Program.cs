using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace lab08_linq
{
    class Program
    {
        public static string path = "./../../../data.json";
        public static DataCollection property = JsonConvert.DeserializeObject<DataCollection>(File.ReadAllText(path));

        static void Main(string[] args)
        {
            AllNeighborhoods();


            Console.WriteLine("Below are the data results queried by LINQ: ");
            Console.WriteLine($"1. Output all of the neighborhoods in this data list: {AllNeighborhoods()}");
            Console.WriteLine("2. Filter out all the neighborhoods that do not have any names: ");
            Console.WriteLine("3. Remove the duplicates: ");
            Console.WriteLine("4. Rewrite the queries from above and consolidate all into one single query: see codes and comments in program.cs");
            Console.WriteLine("5. Rewrite at least one of these questions only using the opposing method: see codes and comments in program.cs");
        }

        public static int AllNeighborhoods()
        {
            int counter = 0;
            var results = property.features;
            foreach (var result in results)
            {
                counter++;
            }
            return counter;
        }

        //public static int NeighborhoodsHaveName()
        //{

        //}
    }
}
