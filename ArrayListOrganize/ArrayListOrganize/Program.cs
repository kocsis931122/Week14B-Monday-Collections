using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOrganize
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            string inputString;
            Console.WriteLine("Please enter some words.  When finished press enter a blank line.");
            while ((inputString = Console.ReadLine()) != "")
            {
                list.Add(inputString);
            }
            Console.ReadLine();
        }
    }
}
