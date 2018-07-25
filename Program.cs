using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args1)
        {
            var args = new[] { 1L, 3L, 2L, 1L, 6, 4, 7L};

            var missingNumbers = new SortedSet<long>();
            var examinedNumbers = new HashSet<long>();

            for (long i = 0; i < args.Length; i++)
            {
                var current = args[i];
                if (missingNumbers.Contains(current))
                {
                    missingNumbers.Remove(current);
                }

                examinedNumbers.Add(current);
                var pre = current - 1;
                
                if (!examinedNumbers.Contains(pre) && !missingNumbers.Contains(pre) && pre > 0)
                {
                    missingNumbers.Add(pre);
                    
                }
                var next = current + 1;
                if (!examinedNumbers.Contains(next) && !missingNumbers.Contains(next) && next > 0)
                {
                    missingNumbers.Add(next);
                   
                }
            }


            Console.WriteLine($"Smailest number is {missingNumbers.Min}");
        }
    }
}
