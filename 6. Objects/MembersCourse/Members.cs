using System;
using System.Diagnostics;

namespace MembersCourse
{
    public class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely
        public string JobTitle {
            get {
                return jobTitle;
            }
            set {
                jobTitle = value;
            }

        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}, and I'm {2}", memberName, jobTitle, age);
            }

        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member - constructor
        public Members()
        {
            age = 30;
            memberName = "Lucie";
            salary = 2000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member finalizer / destructor. Can only be one per class. Cannot be called, inherited 
        // should never be empty
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Deconstruction of Members object");
        }
    }
}
