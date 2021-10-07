using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num2
{
    class Student:Person
    {
        private string id;
        public Student(string name, string major, string id,string email,int activityhour) : base(name, major,email,activityhour)
        {
            this.id = id;
        }
        
    }
}
