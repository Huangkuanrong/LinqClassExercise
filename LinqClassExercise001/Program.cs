using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClassExercise001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Number Program (Ex:1,2,3,4)\n-------");
            Console.Write("Input numbers : ");
            string[] input = Console.ReadLine().Split(',');
            var output = input.Reverse();
            Console.WriteLine(string.Join(",", output));
            Console.ReadLine();
        }
    }
}
