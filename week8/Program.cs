using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad401.LINQ.QES {
    class Program {
        static void Main(string[] args) {
            Department[] departments = {
                new Department() { DeptID = 0, Name = "School Of Business & IT" },
                new Department() { DeptID = 1, Name = "School Of Community Studies" },
            };
        

            Teacher[] teachers = {
                new Teacher() { EmpID = 0, Name = "Nick", School = "St.Clair College",  Dept = 0 },
                new Teacher() { EmpID = 1, Name = "Peter", School = "St.Clair College", Dept = 0},
                new Teacher() { EmpID = 2, Name = "Robert", School = "Fanshawe", Dept = 1},
                new Teacher() { EmpID = 3, Name = "John", School = "St.Clair College", Dept = 1}
            };

            Course[] courses = {
                new Course() { CourseID = 0, CourseCode = "MAD401", Name = "Intro to C#", Cost = 100.00, Term = "Winter", Capacity = 5, Teacher = 0},
                new Course() { CourseID = 1, CourseCode = "MAD304", Name = "Object Oriented Analysis & Design", Cost = 150.00, Capacity = 3, Term = "Fall", Teacher = 1 },
                new Course() { CourseID = 2, CourseCode = "MAD403", Name = "Adv. PHP", Cost = 200.00, Term = "Winter", Capacity = 10, Teacher = 0},
                new Course() { CourseID = 3, CourseCode = "MAD506", Name = "Game Development I", Cost = 250.00, Term = "Fall", Capacity = 7, Teacher = 0},
                new Course() { CourseID = 4, CourseCode = "SSC100", Name = "Intro to Sociology", Cost = 175.00, Term = "Winter", Capacity = 4, Teacher = 2},
                new Course() { CourseID = 5, CourseCode = "SSC101", Name = "Intro to Psychology", Cost = 250.00, Term = "Fall", Capacity = 8, Teacher = -1},

            };

            Student[] students = {
                new Student() {StudentID = 1, Name = "Bobby" , Courses = new int[] {1,2,3} },
                new Student() {StudentID = 2, Name = "Sally" , Courses = new int[] {3,4} },
                new Student() {StudentID = 3, Name = "Jane" , Courses = new int[] {1,4,5} },
                new Student() {StudentID = 4, Name = "Joe" , Courses = new int[] {1,4,5} },
                new Student() {StudentID = 5, Name = "Jim" , Courses = new int[] {1,3} },
            };


            Console.WriteLine("Q1) List full details of all Teachers who work at St. Clair College");

            var q1Answer = from teacher in teachers where teacher.School == "St.Clair College" select teacher;
            
            foreach (var item in q1Answer){
                Console.WriteLine(item);
            }
            

            Console.WriteLine("\nQ2) How many teachers are there?");

            var q2Answer = (from teacher in teachers select teacher).Count();
            Console.WriteLine($"{q2Answer}");
            

            Console.WriteLine("\nQ3) List full details of all Teachers in Business & IT.");
            
            var q3Answer = from teacher in teachers where teacher.Dept.Equals(0) select teacher;
            foreach (var item in q3Answer){
                Console.WriteLine($"{item}");
            }
            

            Console.WriteLine("\nQ4) List the names of all courses taught by Nick.");

            var q4Answer = from teacher in courses where teacher.Teacher.Equals(0) select teacher;
            foreach (var item in q4Answer){
                Console.WriteLine($"{item.Name}");
            }

            Console.WriteLine("\nQ5) List all courses which cost less than $200.00, in ascending order of course code.");

            var q5Answer = (from course in courses where course.Cost < 200.00 orderby course.CourseCode select course);
            foreach (var item in q5Answer){
                Console.WriteLine($"{item}\n");
            }

            Console.WriteLine("\nQ6) What is the average cost of a course in the Winter term?");

            var q6Answer = (from course in courses where course.Term.Equals("Winter") select course.Cost).Average();
            Console.WriteLine($"{Math.Round(q6Answer,2)}");
            

            Console.WriteLine("\nQ7) List the number of courses taught by each teacher.");
        
            var q7Answer = (from course in courses join teacher in teachers on course.Teacher equals teacher.EmpID select new {
                tName = teacher.Name,
                cCode = course.CourseCode
            });

            foreach (var item in q7Answer){
                Console.WriteLine($"{item.tName} {item.cCode}");
            }
            
            //Console.WriteLine("\nQ8) What is the total income from courses taken?");


            //Console.WriteLine("\nQ9) What is the average number of courses students are enrolled in?");


            //Console.WriteLine("\nQ10) Are there any courses which are over capacity? (True or False)");


            //Console.WriteLine("\nQ11) List the course codes for all courses which are over capacity.");

                
            Console.WriteLine("\n\nPress any key to quit");
            Console.ReadKey();
        }
    }
}
