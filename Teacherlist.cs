using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num2
{
    class Teacherlist
    {
        private List<Teacher> TeacherList;

        public Teacherlist()
        {
            this.TeacherList = new List<Teacher>();
        }

        public void AddNewTeacher(Teacher teacher)
        {
            this.TeacherList.Add(teacher);
        }
        public void FetchTeacherList()
        {
            Console.WriteLine("List Teachers");
            Console.WriteLine("-------------");
            foreach (Teacher teacher in this.TeacherList)
            {
                    Console.WriteLine("Name : {0} \nType : Teacher", teacher.GetName());
                    Console.WriteLine("Major : {0}", teacher.GetMajor());
                    Console.WriteLine("\n------------------------------------------------\n");
                }
            }
        }
    }
