using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num2
{
    class Teacher:Person
    {
        public Teacher(string name, string major, string email,int activityhour):base(name, major, email,activityhour)
        {
            this.activityhour = 0;
        }
    }
}
