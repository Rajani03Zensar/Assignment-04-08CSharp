using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringGenericCollections
{
    class LinkedListAssignment
    {
        static void Main()
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
            
            LinkedListNode<string> n = lList.AddFirst("the");
            LinkedListNode<string> n1 = lList.Find("quick");
            LinkedListNode<string> n2 = lList.AddAfter(n1, "brown");
            LinkedListNode<string> l = lList.AddLast("fox");
            LinkedListNode<string> f = lList.Find("fox");
            lList.AddAfter(f, "jumps");
            var fLast = lList.FindLast("the");
            lList.AddBefore(fLast, "over");

            Console.WriteLine("Final Output");
            foreach (string str in lList)
            {
                Console.WriteLine(str);
            }

        }
    }
}
