using System;

namespace Exercise3
{
    class Solution
    {
        public int solution(int A, int B)
        {
            int res = 0;
            // for loop every element to check
            for (int i = A; i <= B; i++)
            {
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                    res++;
            }

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value of A => ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value of B => ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Solution s = new Solution();
            Console.WriteLine($"the number of perfect square between {num1} and {num2} is {s.solution(num1, num2)}");
        }
    }
}
