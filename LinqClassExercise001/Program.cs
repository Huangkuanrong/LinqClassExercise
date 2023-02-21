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
            List<string> input = Console.ReadLine().Split(',').ToList();
            List<int> list = input.Select(x => int.Parse(x)).ToList();
            var output = list.OrderByDescending(x => x).ToList();
            foreach ( var item in output )
            {
                Console.Write(item);
                if (output.IndexOf(item) < output.Count()-1)
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
