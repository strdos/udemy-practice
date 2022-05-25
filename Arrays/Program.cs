using System;

namespace Arrays
{
    internal class Program
    {
        static int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };
        static int[] array93 = new int[] { 1, 4, 5, 7, 12 };

        public static void IncreaseByTwo(int[] array)
        {
            for (int i = 0; i < array93.Length; i++)
            {
                array93[i] += 2;                
            }
        }

        public static int FindMin(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if (min > number)
                    min = number;
            }
            return min;

        }
        static void Main(string[] args)
        {
            int minNumber = FindMin(1, -5, 3, 5, 77, -12, 12, -32, 8, 5);
            Console.WriteLine(minNumber);
            //foreach (int item in array93)
            //{
            //    Console.Write(item + " ");
            //}
            //IncreaseByTwo(array93);
            //foreach (int item in array93)
            //{
            //    Console.Write(item + " ");
            //}
            //foreach (var item in array93)
            //{
            //    Console.WriteLine(array93[item]);
            //}
            //JaggedArray.IntroduceFriends();
            //JaggedArray.PrintJaggedArray();            
            #region TicTacToe
            //// Tic Tac Toe winner identifier
            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    if (array2D[i, 0] == array2D[i, 1] && array2D[i, 1] == array2D[i, 2])
            //    {
            //        Console.WriteLine("Game over");
            //    }


            //}            

            //// print array's backward diagonal
            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        if (i == array2D.GetLength(0)-j-1)
            //            Console.Write(array2D[i, j] + " ");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine("");
            //}

            //// print array's diagonal
            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            Console.Write(array2D[i, j] + " ");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            // print array using nested for loop
            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        Console.Write(array2D[i, j] + " ");
            //    }
            //    Console.WriteLine("");
            //}

            ////print array using foreach
            //foreach (int i in array2D)
            //{
            //    Console.Write(i + " ");                                                   
            //}

            //Console.WriteLine(twoDArray[2,0]);
            //twoDArray[2, 0] = 100;
            //Console.WriteLine(twoDArray[2,0]);
            //Console.WriteLine(twoDArray.Rank);

            //DataTypeChallenge.CheckDataType();                 

            //string a = "aaa";
            //Console.WriteLine(a.GetType());

            //string[] friends = new string[] { "Adam", "Boris", "Claire", "David", "Elon" };
            //// foreach method
            //foreach (string friend in friends)
            //{
            //    Console.WriteLine("Greetings, " + friend);
            //}

            //// for method (often faster than foreach)
            //for (int i = 0; i < friends.Length; i++)
            //{
            //    Console.WriteLine("Greetings, " + friends[i]);
            //}
        }
    }
}
