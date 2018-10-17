using System;
using System.Collections.Generic;

namespace School
{
    public class Student
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
}
