using System;
using System.Collections.Generic;

namespace School
{
    class FirstYears : Student
    {
        private string CRN { get; set; }
        private string lectureName { get; set; }
        private List<Student> collect;

        public FirstYears(float ID, String Name, String Gender, String CRN, String LectureName)
                : base(ID, Name, Gender)
        {
            this.CRN = CRN;
            this.lectureName = LectureName;
            this.collect = new List<Student>();
        }

        public void addStudent(Student e)
        {
            collect.Add(e);            
        }

        //Part 4
        //private static List<string> alFileTypes =
        //new List<string> {"css","gif","htm","html","txt","xml"};

    }

}