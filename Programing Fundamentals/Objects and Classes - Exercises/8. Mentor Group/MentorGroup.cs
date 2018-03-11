using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _8._Mentor_Group
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var line = Console.ReadLine();

            while (line != "end of dates")
            {
                var split = line.Split(' ');
                var name = split[0];
                var student = students.Where(s => s.Name.Equals(name)).DefaultIfEmpty(new Student()).First();
                if (student.Name == null)
                {
                    student.Name = name;
                    student.Attendance = new List<DateTime>();
                    student.Comments = new List<string>();
                    students.Add(student);
                }
                
                if (split.Length > 1)
                {
                    var datesStr = split[1].Split(',');
                    for (int i = 0; i < datesStr.Length; i++)
                    {
                        var date = DateTime.ParseExact(datesStr[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        student.Attendance.Add(date);
                    }
                }

                
                line = Console.ReadLine();
            }

            var names = students.Select(s => s.Name);

            line = Console.ReadLine();
            while (line != "end of comments")
            {
                var splitted = line.Split('-');
                var name = splitted[0];
                var comment = splitted[1];
                if (!names.Contains(name))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var student = students.Where(s => s.Name.Equals(name)).First();
                student.Comments.Add(comment);

                line = Console.ReadLine();
            }

            var sortedUsers = students.OrderBy(s => s.Name);
            foreach (var student in sortedUsers)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comments.Count > 0)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, student.Comments.Select(c => $"- {c}")));
                }

                Console.WriteLine("Dates attended:");
                var sortedDates = student.Attendance.OrderBy(d => d).ToList();
                if (sortedDates.Count > 0)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, sortedDates.Select(d => $"-- {d.Day:D2}/{d.Month:D2}/{d.Year}")));
                }
            }
        }
    }

    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }
        public string Name { get; set; }
    }
}
