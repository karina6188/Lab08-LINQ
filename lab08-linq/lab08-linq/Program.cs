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
            Console.WriteLine($"Total of 147 neighborhood");
            Console.WriteLine("");
            Console.WriteLine($"2. Filter out all the neighborhoods that do not have names: {NeighborhoodsHaveNames()}");
            Console.WriteLine($"Total of 143 neighborhood");
            Console.WriteLine("");
            Console.WriteLine($"3. Remove the duplicates and sort the neiborhoods alphabetically: {UniqueNeighborhoods()}");
            Console.WriteLine($"Total of 39 neighborhood");
            Console.WriteLine("");
            Console.WriteLine($"4. Rewrite the queries from above and consolidate all into one single query: {OneSingleQuery()}");
            Console.WriteLine("\n");
            Console.WriteLine($"5. Rewrite question 1) using the opposing method: {OpposingMethod()}");
        }

        public static string AllNeighborhoods()
        {
            IEnumerable<string> results = DataCollection.features
                            .Select(data => data.Properties.Neighborhood);
            int counter = 0;
            string printData = "";
            foreach (var data in results)
            {
                printData += "\n" + data.ToString() + ", ";
                counter++;
            }
            return printData;
        }

        public static string NeighborhoodsHaveNames()
        {
            IEnumerable<string> results = DataCollection.features
                           .Where(data => data.Properties.Neighborhood != "")
                           .Select(data => data.Properties.Neighborhood);
            int counter = 0;
            string printData = "";
            foreach (var data in results)
            {
                printData += "\n" + data.ToString() + ", ";
                counter++;
            }
            return printData;
        }

        public static string UniqueNeighborhoods()
        {
            IEnumerable<string> results = DataCollection.features
                           .Where(data => data.Properties.Neighborhood != "")
                           .OrderBy(data => data.Properties.Neighborhood)
                           .Select(data => data.Properties.Neighborhood)
                           .Distinct();
            int counter = 0;
            string printData = "";
            foreach (var data in results)
            {
                printData += "\n" + data.ToString() + ", ";
                counter++;
            }
            return printData;
        }

        public static string OneSingleQuery()
        {
            string q1 = AllNeighborhoods();
            string q2 = NeighborhoodsHaveNames();
            string q3 = UniqueNeighborhoods();
            string answersInString = $"\n [1. All neiborhoods: {q1} \n\n 2. Neiborhoods have names: {q2} \n\n 3. Neiborhoods without duplicates: {q3}]";
            return answersInString;
        }

        public static string OpposingMethod()
        {
            var result = from data in DataCollection.features
                                         where data.Properties.Neighborhood != ""
                                         select data.Properties.Neighborhood;
            int counter = 0;
            string printData = "";
            foreach (var data in result)
            {
                printData += "\n" + data.ToString() + ", ";
                counter++;
            }
            return printData;
        }
    }
}
