﻿using System;

namespace Exercise2
{
    class Solution {
        public int solution(int[] A) {
            int n = A.Length;
            
            Array.Sort(A);
            int max_count = 1, res = A[0];
            int curr_count = 1;

            for (int i = 1; i < n; i++)
            {
                if (A[i] == A[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = A[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = A[n - 1];
            }

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Array Length => ");
            int length =  Convert.ToInt32(Console.ReadLine());
            int[] A = new int[length];
            // parsing the array
            for (int i = 0; i < length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Solution s = new Solution();
            Console.WriteLine($"most frequency value = {s.solution(A)}"); 
        }
    }
}
