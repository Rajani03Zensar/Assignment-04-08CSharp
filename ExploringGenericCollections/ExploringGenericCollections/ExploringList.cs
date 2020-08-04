using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringGenericCollections
{
    class ExploringList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Generic Collections List similar to ArrayList");
            List<int> list = new List<int>();
            list.Add(15);
            list.Add(16);
            list.Add(89);
            list.Add(45);
            list.Add(78);
            list.Add(45);
            int findRes = list.Find(x => x.Equals(15));
            List<int> findAll = list.FindAll(a => a.Equals(89));
            Console.WriteLine("Result of Find All");
            foreach (var l3 in findAll)
            {
                Console.WriteLine(l3);
            }
            Console.WriteLine("Finding 15 in the list:{0}", findRes);
            foreach (int l1 in list)
            {
                Console.WriteLine(l1);
            }
            Console.WriteLine("find index");
            int findindex = list.FindIndex(y => y == 89);
            Console.WriteLine(findindex);
            Console.WriteLine("Find Last");
            int findlast= list.FindLast(z => z == 45);
            Console.WriteLine(findlast);
            //List<string> list1 = new List<string>();
            //list1.Add("Hello");
            //list1.Add("Everyone");
            //list1.Add("Get");
            //list1.Add("Lost");
            //foreach (string l2 in list1)
            //{
            //    Console.WriteLine(l2);
            //}




            Console.Read();
        }
    }
}
