using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace lab08_linq
{
    class Program
    {
        public static string path = "./../../../data.json";
        public static DataCollection DataCollection = JsonConvert.DeserializeObject<DataCollection>(File.ReadAllText(path));
        public static List<Properties> properties = new List<Properties>();
        //public static List<Properties> properties = new List<Properties>();

        static void Main(string[] args)
        {
            AllNeighborhoods();
            NeighborhoodsHaveNames();
            UniqueNeighborhoods();
            OneSingleQuery();
            OpposingMethod();

            Console.WriteLine("Below are the data results queried by LINQ: ");
            Console.WriteLine($"1. Output all of the neighborhoods in this data list: {AllNeighborhoods()}");
            Console.WriteLine($"2. Filter out all the neighborhoods that do not have any names: {NeighborhoodsHaveNames()}");
            Console.WriteLine($"3. Remove the duplicates: {UniqueNeighborhoods()}");
            Console.WriteLine($"4. Rewrite the queries from above and consolidate all into one single query: {OneSingleQuery()}");
            Console.WriteLine($"5. Rewrite question 3) using the opposing method: {OpposingMethod()}");
        }

        public static int AllNeighborhoods()
        {
            int counter = 0;
            var results = DataCollection.features;
            foreach (var result in results)
            {
                counter++;
            }
            return counter;
        }

        public static int NeighborhoodsHaveNames()
        {
            int counter = DataCollection.features
                           .Where(data => data.Properties.Neighborhood != "")
                           .Select(data => data.Properties.Neighborhood).Count();
            return counter;
        }

        public static int UniqueNeighborhoods()
        {
            int counter = DataCollection.features
                           .Where(data => data.Properties.Neighborhood != "")
                           .Select(data => data.Properties.Neighborhood)
                           .Distinct().Count();
            return counter;
        }

        public static string OneSingleQuery()
        {
            int q1 = AllNeighborhoods();
            int q2 = NeighborhoodsHaveNames();
            int q3 = UniqueNeighborhoods();
            string answersInString = $"[{q1}, {q2}, {q3}]";
            return answersInString;
        }

        public static int OpposingMethod()
        {
            int result = DataCollection.features.Select(data => data.Properties.Neighborhood != "").Distinct().Count();
            return result;
        }
    }
}
