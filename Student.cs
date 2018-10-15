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

        public float ID { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
    }

    class Test
    {
        static void main()
        {
            Console.WriteLine();
        }
    }
}
