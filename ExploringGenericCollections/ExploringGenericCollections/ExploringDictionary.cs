using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringGenericCollections
{
    class ExploringDictionary
    {
        static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "India");
            dict.Add(2, "America");
            dict.Add(3, "Canada");
            dict.Add(4, "Canada");
            dict.Add(5, "Germany");
            Console.WriteLine("-------------Printing Dictionary Element--------------------");
            foreach (var at in dict)
            {
                Console.WriteLine(at);
            }
            Console.WriteLine();

            Console.WriteLine("Counting the Elements of the Dictionary: {0}", dict.Count);

            Console.WriteLine("Checking index 4 in the Dictionary dict : {0}", dict.ContainsKey(4));
            Console.WriteLine("Checking Value Germany in the Dictionary dict : {0}", dict.ContainsValue("Germany"));
            Console.WriteLine("Checking index 4 in the Dictionary : {0}", dict.ContainsKey(4));

            Console.WriteLine("Clearing all the data from the Dictionary dict : ");
            dict.Clear();

            foreach (var n in dict)
            {
                Console.WriteLine(n);
            }


            Console.ReadLine();

        }

    }
}

