using System;
using System.Collections;

namespace Challenge_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 43);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(3, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach(Student student in students)
            {
                if(!studentsTable.ContainsKey(student.Id))
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine("Student with Id {0} has been added", student.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, this Id {0} already exist", student.Id);
                }
            }
        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GPA { get; set; }

        public Student(int id, string name, int gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
