using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 2 - using regex
            string lines2 = File.ReadAllText(@"X:\input2.txt");

            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(lines2);
            int matchAsNum;
            using (StreamWriter file2 = new StreamWriter(@"X:\output2.txt"))
            {            
                foreach (Match match in matches)
                {
                    //Console.WriteLine(match);
                    if (int.TryParse(match.ToString(), out matchAsNum))
                    {
                        char matchAsChar = (char)matchAsNum;
                        Console.Write(matchAsChar + "");
                        file2.Write(matchAsChar);
                    }
                }
            }

        //// part 1
        //string[] lines = File.ReadAllLines(@"X:\input.txt");

        //using (StreamWriter file = new StreamWriter(@"X:\output.txt"))
        //{
        //    foreach (var line in lines)
        //    {
        //        if (line.Contains("split"))
        //        {
        //            string[] tempArray = line.Split(" ");
        //            file.Write(tempArray[4] + " ");                    
        //        }
        //    }
        //}
    }
}
}