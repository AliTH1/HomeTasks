using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAccessModifiersEncaptulation
{
    internal class Person
    {

        #region Encapsulation
        //private string Name { get; set; }
        //private string Surname { get; set; }
        //private int Age { get; set; }
        //private int BirthDay { get; set; }


        //public void SetName(string name)
        //{
        //    if (name.Length < 2)
        //    {
        //        Console.WriteLine("Wrong value for name");
        //        return;
        //    }
        //    Name = name;
        //}

        //public string GetName() { return Name; }

        //public void SetAge(int age)
        //{
        //    if (age < 16)
        //    {
        //        Console.WriteLine("You are not old enough");
        //        return;
        //    }
        //    Age = age;
        //}

        //public int GetAge() { return Age; }

        #endregion

        #region OvverideGetSet
        private string _name;
        private string _surname;
        private int _age;
        private int _birthDay;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("Wrong value for name");
                    return;
                }
                _name = value;
            }
        }

        public string Surname { get; set; }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 16)
                {
                    Console.WriteLine("You are not old enough");
                    return;
                }
                _age = value;
            }
        }

        public int BirthDay { get; set; }
        #endregion
    }
}
