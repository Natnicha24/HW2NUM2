using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_num2
{
    class Person
    {
        protected string name;
        protected string major;
        protected string email;
        protected int activityhour;

        public Person(string name, string major,string email,int activityhour)
        {
            this.name = name;
            this.major = major;
            this.email = email;
            this.activityhour = activityhour;
            this.activityhour += 3;
        }
      
        public string GetName()
        {
            return this.name;
        }
        public string GetMajor()
        {
            return this.major;
        }
        public int GetActivityHour()
        {
            return this.activityhour;
        }
    }
}
