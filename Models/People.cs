using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class People
    {
        public string name;
        public string surname;
        public int age;
        public string Name 
        {
            get
            { 
                return name; 
            } 
            set 
            { 
                     if(value.Trim().Length>3 && value.Trim().Length<30)
                      { 
                            name = value.Trim();
                      }
            }
         }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Trim().Length > 2 && value.Trim().Length < 30)
                 {
                    surname = value.Trim();
            }    }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value < 100)
                {
                    age = value;
                }
            }
        }
        public People(string name, string surname, int age)
        {
            Name= name;
            Surname= surname;
            Age= age;
        }
    }
   
}
