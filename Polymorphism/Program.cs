using System;
using System.Collections.Generic;
using System.IO;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write to file
            string[] lines2 = { "first line", "second line", "third line" };
            File.WriteAllLines(@"X:\textFile2.txt", lines2);
            Console.WriteLine("Please name your file.");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter your text.");
            string input = Console.ReadLine();
            File.WriteAllText(@"X:\" + fileName + ".txt", input);

            using (StreamWriter file = new StreamWriter(@"X:\myStreamWriterfile.txt"))
            {
                foreach (string line in lines2)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"X:\myStreamWriterfile.txt", true))
            {
                file.WriteLine("This is an appended line.");
            }


            // read from a file, example 1
            string text = System.IO.File.ReadAllText(@"C:\Users\strdo\Desktop\textFile.txt");
            Console.WriteLine(text);
            // example 2
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\strdo\Desktop\textFile.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            // abstract class practice
            Cube cube = new Cube(5.45);
            Sphere sphere = new Sphere(3.44);
            cube.GetInfo();
            sphere.GetInfo();
            Console.WriteLine(sphere.CalculateVolume());

            Shape[] shapes = { new Sphere(4), new Cube(5), new Cube(12) };
            foreach (Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("The shape's volume is " + s.CalculateVolume());
                
                // using 'as' keyword and checking the type                
                Cube iceCube = s as Cube; 
                if(iceCube == null)
                    Console.WriteLine("null");
                if(iceCube is Cube)
                    Console.WriteLine("cube");

                Sphere aSphere = s as Sphere;
                if (aSphere == null)
                    Console.WriteLine("null");
                if (aSphere is Sphere)
                    Console.WriteLine("sphere");

                // casting
                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
            }
            


            // polymorphism practice
            //var cars = new List<Car>
            //{
            //    new BMW("M3", 222, "yellow"),
            //    new Audi("A4", 180, "blue")
            //};

            //foreach (var car in cars)
            //{
            //    car.ShowDetails();
            //    car.Repair();
            //}

            //// ShowDetails method of base class is used as a new Car is created
            //Car bmwZ3 = new Car(220, "black");
            //Car audiA3 = new Car(230, "silver");
            //bmwZ3.ShowDetails();
            //audiA3.ShowDetails();

            //// ShowDetails method of derived class is used as a new BMW is created
            //BMW bmwM5 = new BMW("M5", 300, "white");
            //bmwM5.ShowDetails();

            //// casting a BMW to a Car
            //Car carB = (Car)bmwM5 as Car;
            //carB.ShowDetails();

            //M3 myM3 = new M3("M3 Turbo", 260, "red");
            //myM3.Repair();

            //bmwZ3.SetCarIdInfo(1234, "Adam");
            //audiA3.SetCarIdInfo(1425, "Baker");
            //bmwZ3.GetCarIdInfo();
            //audiA3.GetCarIdInfo();
        }
    }
}
