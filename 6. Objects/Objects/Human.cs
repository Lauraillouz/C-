using System;
namespace Objects
{
    public class Human
    {
        // member variable - no need to make them public because there're only locally used in the constructor
        private string name = "Unknown"; // default name if not changed when new instance
        private string nickname = "Nothing";
        private string eyeColor = "undfined";
        private int age;


        // we can create many different constructors depending on the configurations of fata we receive
        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // parameterised constructor
        public Human(string name, string nickname, int age)
        {
            this.name = name;
            this.nickname = nickname;
            this.age = age;
        }

        // parameterised constructor
        public Human(string name, string nickname, string eyeColor, int age)
        {
            this.name = name;
            this.nickname = nickname;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        // member method
        // useful to condition depending on data you received to personnalised the output and avoid blanks
        public void IntroduceMyself()
        {
            if (age != 0)
            {
                Console.WriteLine("Hi, I'm {0} aka {1}. My eyes are {2} and I'm {3}.", name, nickname, eyeColor, age);

            } else
            {
                Console.WriteLine("Hi, I'm {0} aka {1}. My eyes are {2} and my age is mysterious.", name, nickname, eyeColor);

            }
        }
    }
}
