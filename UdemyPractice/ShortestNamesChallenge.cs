using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractice
{
    internal class ShortestNamesChallenge
    {
        public static string[] SortArray(string[] array)
        {
            string tempArrayValue = string.Empty;

            // sorts names from shortest to longest
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].Length < array[i-1].Length)
                {
                    tempArrayValue = array[i-1];
                    array[i-1] = array[i];
                    array[i] = tempArrayValue;
                    SortArray(array);
                }
            }
            return array;

        }
    }
}
