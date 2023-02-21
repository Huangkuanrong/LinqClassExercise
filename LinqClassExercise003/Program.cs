using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClassExercise003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    list.Add($"{input - i + 1}");
                }
                list.Add($"\n");
            }
            foreach (var i in list)
            {
                Console.Write(i);
            }

        }
    }
}
