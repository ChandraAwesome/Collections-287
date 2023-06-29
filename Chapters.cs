using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Chapters
    {
        public static void FindChapters()
        {
            Console.WriteLine("Enter the number of chapters in the book:");
            int N = int.Parse(Console.ReadLine());

            int[] X = new int[N];
            int[] Y = new int[N];

            Console.WriteLine("Enter the starting and ending pages of each chapter:");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Chapter " + (i + 1) + " starting page: ");
                X[i] = int.Parse(Console.ReadLine());
                Console.Write("Chapter " + (i + 1) + " ending page: ");
                Y[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the current reading page:");
            int K = int.Parse(Console.ReadLine());

            int current_page = 0;
            int current_chapter = 1;
            for (int i = 0; i < N; i++)
            {
                current_page += Y[i] - X[i] + 1;
                if (K <= current_page)
                {
                    break;
                }
                current_chapter++;
            }
            int chapters_left = N - current_chapter;
            Console.WriteLine("Number of chapters Amelia has yet to read: " + chapters_left);
        }
    }

}

