using System;
using System.Collections.Generic;

namespace School
{
    public class Student
    {
        public float Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Student(float ID, String name, String gender)
        {
            this.Id = ID;
            this.Name = name;
            this.Gender = gender;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            return String.Format("The ID: {0} \nThe Name: {1}\nThe Gender: {2}", Id, Name, Gender);
        }
    }
}
