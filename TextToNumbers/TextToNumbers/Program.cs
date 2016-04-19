using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "I have two bananas and five forint.";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("zero", 0);
            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);
            dict.Add("four", 4);
            dict.Add("five", 5);
            dict.Add("six", 6);
            dict.Add("seven", 7);
            dict.Add("eight", 8);
            dict.Add("nine", 9);
            Console.WriteLine("Original text:");
            Console.WriteLine(text);
            string[] splitted = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in splitted)
            {
                if (dict.ContainsKey(word))
                {
                    sb.Append(dict[word]);
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(word);
                    sb.Append(" ");
                }
            }
            Console.WriteLine("Modified text:" );
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
