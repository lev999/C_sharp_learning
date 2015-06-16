using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    class Person
    {
        private String name;
        private string p;

        public Person(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public String Name {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return Age; }
            set { Age = value; }

        }
    }
}
