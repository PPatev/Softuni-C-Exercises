using System;
using System.Collections.Generic;
using System.Globalization;

namespace _10._Student_Groups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            var towns = ReadTownsAndStudents();
            var groups = DistributeStudentsInGroups(towns);


        }

        static List<Group> DistributeStudentsInGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            for (int i = 0; i < towns.Count; i++)
            {
                var town = towns[i];
                var students = town.Students;
                var count = town.SeatCount;
                if (students.Count == 0)
                {
                    continue;
                }

                while (students.Count > 0)
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = new List<Student>();

                    if (count <= students.Count)
                    {
                        group.Students.AddRange(students.GetRange(0, count));
                        students.RemoveRange(0, count);
                    }
                    else
                    {
                        group.Students.AddRange(students.GetRange(0, students.Count));
                        students.RemoveRange(0, students.Count);
                    }
                    
                    groups.Add(group);
                }

                
            }


            return groups;
        }

        static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();
            /*Plovdiv => 5 seats
            Ani Kirilova   |ani88@abv.bg             |27-May-2016
            Todor Nikolov  | tod92@mente.org         | 28-May-2016
            Kiril Stoyanov |  kirtak@gmail.com       | 27-May-2016
            Stefka Petrova |   st96@abv.bg           | 26-May-2016
            Ani Kirilova   |     ani.k@yahoo.co.uk   | 27-May-2016
            Ivan Ivanov    |  ivan.i.ivanov@gmail.com| 27-May-2016
            */
            var line = Console.ReadLine();
            Town currentTown = null;
            while (line != "End")
            {
                var splitted = line.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (splitted.Length == 2)
                {
                    var townName = splitted[0];
                    var numberOfSeats = int.Parse(splitted[1].Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
                    var town = new Town();
                    town.Name = townName;
                    town.SeatCount = numberOfSeats;
                    town.Students = new List<Student>();
                    towns.Add(town);
                    currentTown = town;
                }
                else
                {
                    var studentInfo = line.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    var studentName = studentInfo[0].Trim();
                    var studentEmail = studentInfo[1].Trim();
                    var registrationDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    var student = new Student();
                    student.Name = studentName;
                    student.Email = studentEmail;
                    student.RegistrationDate = registrationDate;
                    currentTown.Students.Add(student);
                }


                line = Console.ReadLine();
            }

            return towns;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
