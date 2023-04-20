using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskException.Utilities.Exceptions;

namespace TaskException.Models
{
    internal class Human
    {
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age;
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if(value <= 0)
                {
                    throw new AgeException("Incorrect value for age");
                }
                _age = value;
            }
        }
    }
}
