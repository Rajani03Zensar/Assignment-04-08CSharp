using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringGenericCollections
{
    class ExploringLinkedList
    {
        static void Main()
        {
            LinkedList<string> myList = new LinkedList<string>();
            myList.AddLast("Pune");
            myList.AddLast("Mumbai");
            myList.AddLast("Kolhapur");
            myList.AddLast("Pandharpur");
            myList.AddLast("Satara");
            Console.WriteLine("Adding Nagpur at the first node using AddFirst()");
            myList.AddFirst("Nagpur");
            LinkedListNode<string> n1=myList.Find("Mumbai");
            LinkedListNode<string> var1 = myList.AddAfter(n1, "Amravati");
            myList.AddBefore(var1, "Solapur");
            
            foreach(string str in myList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Iteration using GetEnumerator method");
            LinkedList<string>.Enumerator lle=myList.GetEnumerator();
            while (lle.MoveNext())
            {
                Console.WriteLine(lle.Current);
                //Console.WriteLine(lle.);
            }
            Console.WriteLine("Contains Method--------");
            bool ht=myList.Contains("Satara");
            Console.WriteLine(ht);
            Console.WriteLine("Using CopytTo method------------");
            string[] arr = new string[myList.Count];
            myList.CopyTo(arr,0);
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
            LinkedListNode <string> b=myList.FindLast("Pandharpur");
            Console.WriteLine("FindLast method:{0}",b.Value);
            bool rem=myList.Remove("Nagpur");
            Console.WriteLine("Removing Element Nagpur from the linked list:{0}",rem );
            foreach (string show in myList)
            {
                Console.WriteLine(show);
            }
            Console.WriteLine("Removing the starting node from the linked list");
            myList.RemoveFirst();
            foreach (string  rem1 in myList)
            {
                Console.WriteLine(rem1);
            }
            Console.WriteLine("Removing the node at the last from the linked list");
            myList.RemoveLast();
            foreach(string disp in myList)
            {
                Console.WriteLine(disp);
            }
            //Console.WriteLine("Clearing the LinkedList");
            //myList.Clear();
            Console.Read();

        }
    }
}
