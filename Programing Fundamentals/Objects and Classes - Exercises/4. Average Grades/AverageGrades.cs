using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Average_Grades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var grades = input.Skip(1).Select(double.Parse).ToList();
                var student = new Student() { Name = name, Grades = grades };
                students.Add(student);
            }

            var listSelected = students.Where(s => s.Average >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.Average).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, listSelected.Select(s => $"{s.Name} -> {s.Average:F2}")));
        }
    }

    class Student
    {
        /*name, list of grades and average grade (calculated property, read-only).
         * A single grade will be in range [2…6], e.g. 3.25 or 5.50.*/

        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double Average
        {
            get
            {
                return this.Grades.Average();
            }
        }

    }
}
