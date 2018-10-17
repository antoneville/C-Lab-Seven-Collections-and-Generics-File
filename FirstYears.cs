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

        public StudentClass(String CRN, String LectureName)
        {
            this.CRN = CRN;
            this.lectureName = LectureName;
            this.collect = new List<Student>();
        }

        public void addStudent(Student e)
        {
            if (collect == null)                               
            {
                collect.Add(e);                          
            }
            else
            {
                if ((collect.Count(s => s.Id == e.Id)) == 1)                         
                {
                    throw new ArgumentException("Error student " + e.Name + " is already in the class");
                }
                else
                {
                    collect.Add(e);
                }
            }


        }

        public IEnumerator GetEnumerator()
        {
            foreach (Student student in collect)
            {
                yield return student;
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
                int count = collect.Count(s => s.Id == stuID);
                if (count == 1)
                {
                    student = collect.Where(s => s.Id == stuID).First();
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
        public static void Main()
        {
            try
            {

                Student r1 = new Student(3455, "John Marcus", "Male");
                Student r2 = new Student(331, "Spider Pig", "Male");

                StudentClass s2 = new StudentClass("3", "Thomas Coleman");
                StudentClass s7 = new StudentClass("5", "Marcus Alonso");

                s7.addStudent(r1);
                s7.addStudent(r2);


                Console.WriteLine("****************");
                Console.WriteLine("Student Details: ");
                Console.WriteLine(r1);

                r1.Id = 29;
                r1.Name = "Elizabeth Walker";
                r1.Gender = "Female";

                Console.WriteLine("\n************************");
                Console.WriteLine("Student Details Changed:");
                Console.WriteLine(r1);

                Console.WriteLine("\nName of Class: {0} \t| Name of Lecturer: {1}", s7.CRN, s7.lectureName);
                foreach (Student student in s7)
                {
                    Console.WriteLine("\n***********************");
                    Console.WriteLine(student);
                }

                Student findStu1 = s7[1];
                Console.WriteLine("Found " + findStu1); 

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
    }
}