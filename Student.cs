using System;
using System.Collections.Generic;

namespace School
{
    class Student
    {
        private float id;
        private string name;
        private string gender;

        public Student(float ID, String Name, String Gender)
        {
            this.id = ID;
            this.name = Name;
            this.gender = Gender;
        }

        public Student()
        {
        }

        public float ID { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }

        public override string ToString()
        {
            return "The ID: {0} \nThe Name: {1}\nThe Gender: {2}";
        }
    }

    class Test
    {
        static void main()
        {
            Student r1 = new Student(3455, "John Marcus", "Male");
            Console.WriteLine(r1);

            r1.ID = 29;
            Console.WriteLine(r1.ID);

            r1.Name = "Elizabeth Walker";
            Console.WriteLine(r1.Name);

            r1.Gender = "Female";
            Console.WriteLine(r1.Gender);

            Console.WriteLine(r1);

        }
    }
}
