using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            int inputInt;
            string inputString;
            Console.WriteLine("Please enter some numbers. When finished press enter a blank line.");
            while ((inputString = Console.ReadLine()) != "")
            {
                inputInt = int.Parse(inputString);
                myStack.Push(inputInt);
            }
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.ReadLine();
        }
    }
    }
