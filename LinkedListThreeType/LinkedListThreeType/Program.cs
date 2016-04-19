using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListThreeType
{
    class Program
    {

        static void Main(string[] args)
        {

            {
                string[] words = { "kutya", "asztal", "eger" };
                LinkedList<string> lows = new LinkedList<string>(words);
                lows.AddFirst("furulya");
                lows.AddLast("orgona");
                foreach (string word in lows)
                {
                    Console.WriteLine(word);
                }

                int[] nums = { 2, 23, 28 };
                LinkedList<int> number = new LinkedList<int>(nums);
                number.AddFirst(66);
                number.AddLast(33);
                foreach (int i in number)
                {
                    Console.WriteLine(i);
                }

             
                Console.ReadLine();
            }
        }
    }
}
