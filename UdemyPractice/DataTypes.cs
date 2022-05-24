using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractice
{
    internal class DataTypes
    {
        public static void DivideByZeroException()
        {
        int num1 = 5, num2 = 0;
            try
            {
                int result = num1 / num2;
            }

            catch (DivideByZeroException)
            {

                Console.WriteLine("Division by zero is not possible."); ;
            }
        }

        public static void JustCodeToCopyFrom()
        {
        //Multiply();

        //WriteSomething();
        //WriteSomethingSpecific("I am an argument for the WriteSomethingSpecific method.");

        #region valueTypes

        //byte myByte = 255;
        //Console.WriteLine(myByte);
        //Console.WriteLine(myByte.GetType());
        //sbyte mySByte = -125;
        //Console.WriteLine(mySByte);
        //Console.WriteLine(mySByte.GetType());
        //int myInt = 1;
        //Console.WriteLine(myInt);
        //Console.WriteLine(myInt.GetType());
        //uint myUInt = 45789990;
        //Console.WriteLine(myUInt);
        //short myShort = -1235;
        //Console.WriteLine(myShort);
        //ushort myUShort = 55555;
        //Console.WriteLine(myUShort);
        //long myLong = 12345678999999;
        //Console.WriteLine(myLong);
        //ulong myULong = 1212121212454545;
        //Console.WriteLine(myULong);
        //float myFloat = 3.1415926F;
        //Console.WriteLine(myFloat);
        //double myDouble = 3.14159265;
        //Console.WriteLine(myDouble);
        //char myChar = 'c';
        //Console.WriteLine(myChar);
        //Console.WriteLine(myChar.GetType());
        //bool myBool = false;
        //Console.WriteLine(myBool);
        //decimal myDecimal = 1.1212124545457878M;
        //Console.WriteLine(myDecimal);
        //string myString1 = "I control text";
        //Console.WriteLine(myString1);
        //string myString2 = "115";
        //Console.WriteLine(myString2);
        //int myStringNum = Int32.Parse(myString2);
        //Console.WriteLine(myStringNum);
        //Console.WriteLine(myStringNum.GetType());

        #endregion valueTypes

        #region stringPractice

        //Console.WriteLine("Enter a string here: ");
        //string userString = Console.ReadLine();
        //Console.WriteLine("Enter the character to search: ");
        //string userCharacter = Console.ReadLine();
        //Console.WriteLine(userString.IndexOf(userCharacter));

        //Console.WriteLine("Enter your first name: ");
        //string userFirstName = Console.ReadLine();
        //Console.WriteLine("Enter your last name");
        //string userLastName = Console.ReadLine();
        //string userFullName = String.Format("Your full name is: {0} {1}", userFirstName, userLastName);
        //Console.WriteLine(userFullName);


        //string myString;
        //Console.WriteLine("Please enter your name and press enter");
        //myString = Console.ReadLine();
        //Console.WriteLine(myString.ToUpper());
        //Console.WriteLine(myString.ToLower());
        //Console.WriteLine(myString.Trim());
        //Console.WriteLine(myString.Substring(5));


        //// string concatenation
        //int age = 35;
        //string name = "John";
        //string hobby = "books";

        //Console.WriteLine("My name is " + name + ", and I am " + age + " years old.");

        //// string formatting
        //Console.WriteLine("My name is {0}, and I am {1} years old, and I like {2}.", name, age, hobby);

        //// string interpolation
        //Console.WriteLine($"My name is {name}, and I am {age} years old, and I like {hobby}.");

        //// verbatim
        //Console.WriteLine(@"Lorem ipsum \n Lorem ipsum");
        //Console.WriteLine("Lorem ipsum \nLorem ipsum");


        //string stringForFloat = "0.85"; // datatype should be float
        //string stringForInt = "12345"; // datatype should be int

        //float myFloat = float.Parse(stringForFloat);
        //int myInt = int.Parse(stringForInt);

        //Console.WriteLine(myFloat);
        //Console.WriteLine(myFloat.GetType());
        //Console.WriteLine(myInt);
        //Console.WriteLine(myInt.GetType());

        //// parsing strings
        //string myString1 = "15";
        //string myString2 = "18";
        //int num1 = Int32.Parse(myString1);
        //int num2 = Int32.Parse(myString2);
        //int result = num1 + num2;
        //Console.WriteLine(result);


        //// cast to long (implicit conversion)
        //int num = 123456789;
        //long longNum = num;
        //Console.WriteLine(longNum);

        //// cast to int (explicit conversion)
        //double myDouble = 18.45;
        //int myInt = (int)myDouble;
        //Console.WriteLine(myInt);

        //// type conversion
        //string myString;
        //myString = myDouble.ToString();
        //Console.WriteLine(myString);
        //Console.WriteLine(myString.GetType());

        //float myFloat = 12.1578F;
        //string myFloatString = myFloat.ToString();
        //Console.WriteLine(myFloatString);

        //Console.ReadKey();
        #endregion stringPractice

        }

    }



}
