using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MaximumSellingPrice
    {
        public static void Basket()
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] basketA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] basketB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int maxPrice = GetMaxSellingPrice(N, K, basketA, basketB);
            Console.WriteLine(maxPrice);
        }

        static int GetMaxSellingPrice(int N, int K, int[] basketA, int[] basketB)
        {
            Array.Sort(basketA);
            Array.Sort(basketB);

            int bIndex = N - 1; // Index for Basket B, starting from the largest price
            for (int i = 0; i < K; i++)
            {
                if (bIndex >= 0 && basketA[i] < basketB[bIndex])
                {
                    basketA[i] = basketB[bIndex];
                    bIndex--;
                }
                else
                {
                    break; // No more beneficial swaps possible
                }
            }

            int maxPrice = 0;
            for (int i = 0; i < N; i++)
            {
                maxPrice += basketA[i];
            }

            return maxPrice;
        }
    }
    
}
