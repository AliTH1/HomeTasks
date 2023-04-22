using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models
{
    internal class User
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private static int Age { get; set; }


        public void GetFullName()
        {
            Console.WriteLine("{0} {1}", Name, Surname);
        }

        public static void ChangeAge(int age)
        {
            Age = age;
        }
    }
}