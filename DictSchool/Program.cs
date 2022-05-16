using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string count = Console.ReadLine();
            int c = Convert.ToInt32(count);
            //var students = new Dictionary<string, int>();
            var students = new List<Student> { };

            while (c > 0)
            {
                string[] student = Console.ReadLine().Trim().Split();
                for(int i = 4; i < student.Length; i ++)
                {
                    string name = student[0] + " " + student[1];
                    string[] strgrade = new[] { student[2], student[3], student[4]};
                    int[] grade = strgrade.Select(int.Parse).ToArray();
                    int num = grade.Sum();
                    students.Add(new Student { Name = name, Grade = num });
                }
                c--;
            }
            var maxGrade = students.Select(g => g.);
            scipy.stats
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}
