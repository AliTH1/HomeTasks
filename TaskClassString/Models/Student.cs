using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClassString.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public double Point { get; set; }
        public bool IsGraduated { get; set; }


        public Student()
        {
            
        }

        public Student(string name, string surname, string group,
            double point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group; 
            Point = point;
            IsGraduated = isGraduated;
        }

        
        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }

        public string AdmissionToTheExam()
        {
            if(Point > 80)
            {
                return "Can take the exam";
            }
            else
            {
                return "Cannot take the exam";
            }
        }

        public string GetInfo()
        {
            Console.WriteLine("{");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Point: " + Point);
            Console.WriteLine("IsGraduated: " + IsGraduated);
            Console.WriteLine("}");

            if (IsGraduated == true)
            {
                return "Graduated";
            }
            else
            {
                return "Not graduated";
            }
        }
    }
}
