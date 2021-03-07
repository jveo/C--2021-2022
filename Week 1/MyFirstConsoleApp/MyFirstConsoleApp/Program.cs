using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp{
    class Program{


        static void Main(string[] args){

            string title = "St. Clair Student Registration Program";
            string name;
            int studentNo;
            int numOfChars = title.Length;
            string[] courses = { "MAD100", "MAD101", "MAD102", "MAD103", "WEB110", "MIT201" };

            //Title
            Console.WriteLine(title);

            //Asterisks Line
            Console.WriteLine(new String('*', numOfChars));

            //Gathers Students name (String) based on typed input
            Console.WriteLine("Please enter the students name");
            name = Console.ReadLine().ToUpper();

            //Gathers Student Number (Integer) based on typed input
            Console.WriteLine("Please enter their student number");
            studentNo = int.Parse(Console.ReadLine());

            //Gathers Yes or No CHAR from typed input
            Console.Write("Is the student transferring from another college?(Y or N)");
            ConsoleKeyInfo value = Console.ReadKey();

            //storing character in implicitly typed variable called 'transfer'
            var transfer = value.Key;


            //String Interpolated Output
            Console.WriteLine();

            int numOfEnrolledCourses = courses.Length;

            Console.WriteLine($"Student Name: {name}\n" +
                $"Student Number: {studentNo}\n" +
                $"Transfer Student?: {transfer}\n" +
                $"Number of enrolled courses: {numOfEnrolledCourses}");

            //Composite Formatted List of Courses
            Console.WriteLine("List of enrolled courses: {0}, {1}, {2}, {3}, {4}, {5}", courses[0], courses[1], courses[2], courses[3], courses[4], courses[5]);

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

        }


    }
}
