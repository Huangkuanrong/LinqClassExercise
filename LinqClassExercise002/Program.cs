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
            List<string> input = Console.ReadLine().Split(',').ToList();
            List<int> list = input.Select(x => int.Parse(x)).ToList();
            List<int> oddNumber = list.Where(x => x%2!=0).OrderBy(y => y).ToList();
            List<int> evenNumber = list.Where(x => x%2==0).OrderBy(y => y).ToList();
            Display(oddNumber);
            Display(evenNumber);
        }

        static void Display(List<int> output)
        {
            foreach (var item in output)
            {
                Console.Write(item);
                if (output.IndexOf(item) < output.Count() - 1)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
