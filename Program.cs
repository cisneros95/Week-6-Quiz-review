using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_Quiz_review
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int a = AskNumber("Please enter 1st number: ");
            int b = AskNumber("Please enter 2nd number: ");
            Console.WriteLine(a+b);
        }
 
        static int AskNumber(string prompt)
        {
            Console.Write(prompt);
            //int num = int.Parse(Console.ReadLine());
            int num;
            string input = Console.ReadLine();
            bool ok = int.TryParse(input, out num);
            while (ok == false)
            {
                Console.WriteLine($"{input}is not an integer.");
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                ok = int.TryParse(input, out num);
        
            }
            return num;


        }
    }
}
