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

    class FirstYears : Student 
    {
        private string CRN { get; set; }
        private string lectureName { get; set; }
        private List<Student> collect;

        public FirstYears(float ID, String Name, String Gender, String CRN, String LectureName, )
                :base(ID, Name, Gender)
        {
            this.CRN = CRN;
            this.lectureName = LectureName;
        }

        public void addStudent(float ID, String Name, String Gender)
        {   
        }

        //Part 4
        //private static List<string> alFileTypes =
        //new List<string> {"css","gif","htm","html","txt","xml"};


    }


}
