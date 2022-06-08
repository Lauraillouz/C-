using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 76);
            Student student3 = new Student(3, "Clara", 43);
            Student student4 = new Student(4, "Steve", 55);

            // assigning data into the hashtable : Add(key, value)
            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);
            studentsTable.Add(student4.Id, student4);

            // to retrieve an item with known ID we have to cast the object in the type of the class we want to use
            Student storedStudent1 = (Student)studentsTable[student1.Id];

            // retrieve all values from Hastable
            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                // Console.WriteLine("Student ID {0}", temp.Id);
                // Console.WriteLine("Student name {0}", temp.Name);
                // Console.WriteLine("Student GPA {0}", temp.GPA);

            }

            // more direct way to do the above
            foreach(Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID {0}", value.Id);
                Console.WriteLine("Student name {0}", value.Name);
                Console.WriteLine("Student GPA {0}", value.GPA);


            }

            Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
        }
    }

    class Student
    {
        //property called id
        public int Id { get; set; }

        // property called name
        public string Name { get; set; }

        // property called GPA
        public float GPA { get; set; }

        // constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
