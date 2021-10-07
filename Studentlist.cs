using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num2
{
    class Studentlist
    {
        private List<Student> StudentList;

        public Studentlist()
        {
            this.StudentList = new List<Student>();
        }

        public void AddNewStudent(Student student)
        {
            this.StudentList.Add(student);
        }
        public void FetchStudentList()
        {
            Console.WriteLine("List Students");
            Console.WriteLine("-------------");
            foreach (Student student in this.StudentList)
            {
                    Console.WriteLine("Name : {0} \nType : Student", student.GetName());
                    Console.WriteLine("Major : {0}", student.GetMajor());
                    Console.WriteLine("Activity Hour : {0}", student.GetActivityHour());
                    Console.WriteLine("\n------------------------------------------------\n");
                }
            }
        }
    }
