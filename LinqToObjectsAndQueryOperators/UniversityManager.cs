using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectsAndQueryOperators
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale"});
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Tony", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leila", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "male", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male students: ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female students: ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
        public void SortStudentsByAge()
        {
            // var is a bit slower than IEnumerable<> as it is too generic
            var studentsByAge = from student in students orderby student.Age select student;
            Console.WriteLine("Students by age: ");
            foreach (Student student in studentsByAge)
            {
                student.Print();
            }
        }
        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> studentsFromBeijingTech = from student in students
                                                           join university in universities
                                                           on student.UniversityId equals university.Id
                                                           where university.Name == "Beijing Tech"
                                                           select student;
            Console.WriteLine("Students from Beijing Tech: ");
            foreach (Student student in studentsFromBeijingTech)
            {
                student.Print();
            }

            //var studentsFromBeijingTech = from student in students where student.UniversityId == 2 select student;
            //Console.WriteLine("Students from Beijing Tech: ");
            //foreach (Student student in studentsFromBeijingTech)
            //{
            //    student.Print();
            //}
        }
        public void ShowStudentsFromSelectedUni()
        {
            int userInputAsNum = 0;
            Console.WriteLine("Please enter University Id: ");
            string userInput = Console.ReadLine();
            try
            {
                userInputAsNum = Int32.Parse(userInput);
                IEnumerable<Student> studentsFromUniSelectedByUser = from student in students where student.UniversityId == userInputAsNum select student;
                Console.WriteLine("Students from university with Id {0}: ", userInputAsNum);
                foreach (Student student in studentsFromUniSelectedByUser)
                {
                    student.Print();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input. University with such Id not found.");
            }
        }
        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection: ");
            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName );
            }
        }
    }
}
