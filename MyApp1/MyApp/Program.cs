using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameofStudent;
            int registerNumber;
            string sexCode;
            DateTime dateofBirth;
            int age;
            string courseCode;
            int mark;
            float classAverage;
            decimal feesPaid;
            bool coursePassed;
            nameofStudent = "Olexandr Zimnov";
            registerNumber = 23;
            sexCode = "M";
            dateofBirth = Convert.ToDateTime("24/05/2004");
            age = 25;
            courseCode = "IPZ19";
            mark = 87;
            classAverage=60.12f;
            feesPaid = 1000.53m;
            coursePassed = true;

            Console.WriteLine("Student Details");
            Console.WriteLine("Student Name: " + nameofStudent);
            Console.WriteLine("Register Number: " + registerNumber);
            Console.WriteLine("Gender: "+ sexCode);
            Console.WriteLine("Date of Birth: " + dateofBirth);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Mark: " + mark);
            Console.WriteLine("Class Average: " + classAverage);
            Console.WriteLine("Fees Paid: " + feesPaid);
            Console.WriteLine("Course Passed: " + coursePassed);
            Console.ReadLine();
        }
    }
}

