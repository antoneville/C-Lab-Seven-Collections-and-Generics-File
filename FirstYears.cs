using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public class StudentClass : IEnumerable
    {
        public string CRN { get; set; }
        public string lectureName { get; set; }
        private List<Student> collect;

        public StudentClass(float ID, String Name, String Gender, String CRN, String LectureName)
        {
            this.CRN = CRN;
            this.lectureName = LectureName;
            this.collect = new List<Student>();
        }

        public void addStudent(Student e)
        {
            try
            {
                if (e == null)
                {
                    collect.Add(e);
                }
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("List out of bounds: {0}", ex);
            }


        }

        public IEnumerator GetEnumerator()
        {
            foreach (Student students in collect)
            {
                yield return students;
            }
        }

        public Student this[int positon]
        {
            get
            {
                if ((positon < 0) & (positon >= collect.Count))
                {
                    return collect[positon];
                }
                else
                {
                    throw new ArgumentException("Error: ArrayList out of bounds");
                }
            }
        }

        public Student this[float stuID]
        {
            get
            {
                Student student = null;
                int count = collect.Count(s => s.ID == stuID);
                if (count == 1)
                {
                    student = collect.Where(s => s.ID == stuID).First();
                    return student;
                }
                else
                {
                    throw new ArgumentException("no matching student found");
                }
            }
        }

    }
    class Test
    {
        public static void main()
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