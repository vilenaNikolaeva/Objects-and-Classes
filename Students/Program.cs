using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countStudents; i++)
            {
                string[] studentArg = Console.ReadLine()
                    .Split(" ");

                string firstName = studentArg[0];
                string lastName = studentArg[1];
                double grade = double.Parse(studentArg[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }
            List<Student> sortedStudent = students
               .OrderByDescending(x => x.Grade)
               .ToList();

            foreach (var student in sortedStudent)
            {
                Console.WriteLine(student);
            }
        }
    }
}
