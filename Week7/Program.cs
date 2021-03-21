using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad401.LINQ {
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

            foreach (var item in teachers){
                Console.WriteLine($"ID = {item.EmpID}, Name = {item.Name}, School = {item.School} Dept = {item.Dept}"); 
            }

            
            Console.WriteLine("\nQ2) How many teachers are there?");

            int numberOfTeachers = teachers.Count();
            Console.WriteLine($"{numberOfTeachers}");
  
            
            Console.WriteLine("\nQ3) List full details of all Teachers in Business & IT.");

            var listOfTeachers = teachers.Where(i => i.Dept == 0);
            
            foreach (var teacher in listOfTeachers){
                Console.WriteLine($"ID = {teacher.EmpID} Name = {teacher.Name}, School = {teacher.School} Dept = {teacher.Dept}");
            }

            
            Console.WriteLine("\nQ4) List the names of all courses taught by Nick.");
            
            var coursesTaughtByNick = courses.Where(course => course.Teacher == 0);

            foreach (var course in coursesTaughtByNick){
                Console.WriteLine($"{course.Name}");
            }
            
            Console.WriteLine("\nQ5) List all courses which cost less than $200.00, in ascending order of course code.");
            
            var coursesLessThanTwoHundred = courses.Where(courses => courses.Cost < 200).OrderBy( e => e.CourseCode);

            foreach (var course in coursesLessThanTwoHundred){
                Console.WriteLine($"{course}");
            }
            
            Console.WriteLine("\nQ6) What is the average cost of a course in the Winter term?");
            
            var courseCostSum = courses.Where(courses => courses.Term == "Winter").Average(courses => courses.Cost);
            Console.WriteLine($"{Math.Round(courseCostSum, 2)}");

            
            
            
            Console.WriteLine("\nQ7) List the number of courses taught by each teacher.");

            var coursesTaughtByEachTeacher = courses.Join(teachers,
                courses => courses.Teacher,
                teachers => teachers.EmpID,
            
                (courses, teachers) => new {
                    teachers.Name,
                    courses.Teacher
                });

            foreach (var item in coursesTaughtByEachTeacher){
                Console.WriteLine($"Name = {item.Name} Course Count = {item.Teacher}");
            }
            
            /*
            Console.WriteLine("\nQ8) What is the total income from courses taken?");

            
            
            
            Console.WriteLine("\nQ9) What is the average number of courses students are enrolled in?");

            
            Console.WriteLine("\nQ10) Are there any courses which are over capacity? (True or False)");
            var courseCap = courses.Where(c => c.Capacity < 10);
            bool overCapacity = courseCap.Contains(10);
            Console.WriteLine($"{overCapacity}");
            
            /*
            Console.WriteLine("\nQ11) List the course codes for all courses which are over capacity.");

          
            Console.WriteLine("\n\nPress any key to quit");
            */
            Console.ReadKey();
        }
    }
}
