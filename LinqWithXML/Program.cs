using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                                <GPA>4.0</GPA>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>1</Semester>
                                <GPA>3.4</GPA>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                                <GPA>3.7</GPA>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>10</Semester>
                                <GPA>3.85</GPA>
                            </Student>
                            <Student>
                                <Name>Adam</Name>
                                <Age>28</Age>
                                <University>Sydney Business College</University>
                                <Semester>7</Semester>
                                <GPA>3.59</GPA>
                            </Student>
                        </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value,
                               GPA = student.Element("GPA").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine("Student {0}, age {1}, from {2} unviersity, semester {3}, GPA {4}", student.Name, student.Age, student.University, student.Semester, student.GPA);
            }

            var studentsSortedByAge = from student in students orderby student.Age select student;
            foreach (var student in studentsSortedByAge)
            {
                Console.WriteLine($"{student.Name}, age {student.Age}");
            }
        }
    }
}
