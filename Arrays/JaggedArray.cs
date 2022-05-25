using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class JaggedArray
    {
        static int[][] jaggedArray = new int[3][]
        {
            new int[] {1, 2, 3, 4, 5, 6, 7, 8 },
            new int[] {12, 15, 15, 18, 10 },
            new int[]{45, 62, 68, 100, 123, 11 }
        };

        static string[][] friends = new string[3][]
        {
            new string[] {"Adam", "Baker"},
            new string[] {"Charles", "David"},
            new string[] {"Edgar", "Fred"}
        };

        public static void PrintJaggedArray()
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                Console.Write($"The values for row {i} are: ");
                for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
                {
                    {
                        Console.Write(jaggedArray[i][j] + " ");
                    }
                }
                Console.WriteLine("");
            }            
        }
        public static void IntroduceFriends()
        {
            for (int i = 0; i < friends.GetLength(0); i++)
            {
                Console.WriteLine("My family members are: ");
                for (int j = 0; j < friends[i].GetLength(0); j++)
                {
                    Console.Write(friends[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
