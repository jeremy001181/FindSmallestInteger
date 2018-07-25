/*
Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Assume that:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
Complexity:

expected worst-case time complexity is O(N);
expected worst-case space complexity is O(N) (not counting the storage required for input arguments).
Copyright 2009–2018 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
 */

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
