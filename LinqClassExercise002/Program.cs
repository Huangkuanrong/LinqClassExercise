using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClassExercise002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split Odd and Even Number Program (Ex:1,2,3,4)\n-------");
            Console.Write("Input numbers : ");
            List<string> input = Console.ReadLine().Split(',').ToList();
            List<int> list = input.Select(x => int.Parse(x)).ToList();
            List<int> oddNumber = list.Where(x => x%2!=0).OrderBy(y => y).ToList();
            List<int> evenNumber = list.Where(x => x%2==0).OrderBy(y => y).ToList();
            Console.WriteLine($"\"Odd Number : \"{string.Join(",", oddNumber)}");
            Console.WriteLine($"\"Even Number : \"{string.Join(",", evenNumber)}");
            Console.ReadLine();
        }
    }
}
