using System;
using System.Collections;

namespace Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 62);
            students[3] = new Student(1, "Luis", 74);
            students[4] = new Student(4, "James", 84);

            Hashtable studentInfo = new Hashtable();

            // add students with unique ID to hash table
            foreach (Student s in students)
            {
                if (!studentInfo.ContainsKey(s.Id))
                {
                    studentInfo.Add(s.Id, s);
                    Console.WriteLine(s.Id + " " + s.Name + " " + s.GPA);
                }            
            }

            #region
            // creating a hashtable
            //Hashtable studentTable = new Hashtable();
            
            //Student student1 = new Student(1, "Maria", 4.8);
            //Student student2 = new Student(2, "Mark", 4.1);
            //Student student3 = new Student(3, "Marta", 5.0);
            //Student student4 = new Student(4, "Matt", 3.8);

            //// adding students to hashtable
            //studentTable.Add(student1.Id, student1);
            //studentTable.Add(student2.Id, student2);
            //studentTable.Add(student3.Id, student3);
            //studentTable.Add(student4.Id, student4);

            //// retrieving individual item with known id
            //Student studentStored1 = (Student)studentTable[1];
            //Console.WriteLine(studentStored1.Id);
            //Console.WriteLine(studentStored1.Name);
            //Console.WriteLine(studentStored1.GPA);

            //// retrieving all items using DictionaryEntry class
            //foreach (DictionaryEntry student in studentTable)
            //{
            //    Student temp = (Student)student.Value;
            //    Console.WriteLine(temp.Id);
            //    Console.WriteLine(temp.Name);
            //    Console.WriteLine(temp.GPA);
            //}

            //// retrieving all items using Values keyword
            //foreach (Student student in studentTable.Values)
            //{
            //    Console.WriteLine(student.Id);
            //    Console.WriteLine(student.Name);
            //    Console.WriteLine(student.GPA);
            //}
            #endregion
        }
    }
}
