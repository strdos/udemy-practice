using System;

namespace TicTacToe
{
    internal class Program
    {
        static string[] arrayOnStart = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string[] array = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string input = String.Empty;
        static bool isValid = false;
        static bool isVacant = false;
        static int selection = 0;
        static string ticTacToeSign = String.Empty;
        static bool win = false;
        static int drawCounter = 0;
        static int playerNumber = 0;
        static int counter = 0;

        public static void DrawArray()
        {
            Console.Clear();
            Console.WriteLine("   |   |");
            Console.WriteLine($" {array[0]} | {array[1]} | {array[2]}");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |");
            Console.WriteLine($" {array[3]} | {array[4]} | {array[5]}");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |");
            Console.WriteLine($" {array[6]} | {array[7]} | {array[8]}");
            Console.WriteLine("   |   |");
            Console.WriteLine("");
        }

        public static void CheckIsNumber()
        {
            isValid = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (input == arrayOnStart[i])
                {
                    isValid = true;
                    selection = i;
                    break;
                }
            }
            if (!isValid)
            {
                Console.WriteLine("Please enter a number between 1 and 9.");
                input = Console.ReadLine();
                CheckIsNumber();
            }
        }

        public static void CheckIsFree()
            {
                isVacant = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (input == array[i])
                    {
                        isVacant = true;
                        selection = i;
                        break;
                    }
                }
                if (!isVacant)
                {
                    Console.WriteLine("This square has already been taken. Please select a different square.");
                    input = Console.ReadLine();
                    CheckIsFree();
                    CheckIsNumber();
                }
                else
                {
                    array[selection] = ticTacToeSign;
                    DrawArray();
                    CheckWin();
                    counter++;
                }
            }

        public static void Play()
        {
            playerNumber = (counter % 2 + 1);        
            if (playerNumber % 2 == 0)
            ticTacToeSign = "O";
            else
            ticTacToeSign = "X";

            Console.WriteLine("");
            Console.WriteLine($"Player {playerNumber}: Choose your square!");
            input = Console.ReadLine();
            CheckIsNumber();
            CheckIsFree();
            CheckWin();
            CheckDraw();
        }

        public static void CheckWin()
        {
            //horizontal
            for (int i = 0; i < 6; i += 3)
            {
                if (array[i] == array[i + 1] && array[i + 1] == array[i + 2])
                    win = true;                    
            }
            //vertical
            for (int i = 0; i < 3; i++)
            {
                if (array[i] == array[i + 3] && array[i + 3] == array[i + 6])
                    win = true;                    
            }
            //diagonals
            if ((array[0] == array[4] && array[4] == array[8]) || (array[2] == array[4] && array[4] == array[6]))
                win = true;                

            if (!win)
            {
                CheckDraw();
                counter++;
                Play();
            }
            else
            {
                Console.Clear();
                DrawArray();
                Console.WriteLine($"Game over. Player {playerNumber} has won!");
                Console.WriteLine("Press 'R' to reset the game or any other key to exit.");
                input = Console.ReadLine();
                if (input == "r" || input == "R")
                {
                    array = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                    DrawArray();
                    counter = 0;
                    win = false;
                    Play();
                }
                else Environment.Exit(0);              

            }
        }

        public static void CheckDraw()
        {
            drawCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "X" || array[i] == "O")
                {
                    drawCounter++;
                }    
            }
            if(drawCounter == 9)
            {
                Console.Clear();
                DrawArray();
                Console.WriteLine($"Game over. It is a draw!");
                Console.WriteLine("Press 'R' to reset the game or any other key to exit.");
                input = Console.ReadLine();
                if (input == "r" || input == "R")
                {
                    array = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                    DrawArray();
                    counter = 0;
                    Play();
                }          
            }

        }
        
        static void Main(string[] args)
        {
            DrawArray();
            while (!win)
            {
                Play();
            }
        }
    }
}