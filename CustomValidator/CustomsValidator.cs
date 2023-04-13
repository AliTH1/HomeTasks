using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomValidator
{
    public class CustomValidators
    {

        public CustomValidators(string username, string name, string surname, string password,
            int age, int birthday)
        {
            UsernameValidator(username);
            NameValidator(name);
            SurnameValidator(surname);
            PasswordValidator(password);
            AgeValidator(age);
            BirthdayValidator(birthday);
        }


        public string UsernameValidator(string username)
        {
            if(username.Length > 2)
            {
                return username;
            }
            return "Incorrect username";
        }

        public string NameValidator(string name)
        {
            if (name.Length > 2) 
            {
                return name;
            }
            return "Incorrect name";
        }

        public string SurnameValidator(string surname)
        {
            if (surname.Length > 2)
            {
                return surname;
            }
            return "Incorrect surname";
        }

        public string PasswordValidator(string password)
        {
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                return password;
            }
            return "Incorrect password";
        }

        public int AgeValidator(int age)
        {
            if (age > 0)
            {
                return age;
            }
            Console.Write("Incorrect age: ");
            return -1;
        }

        public int BirthdayValidator(int birthday)
        {
            if (birthday > 1970)
            {
                return birthday;
            }
            Console.Write("Incorrect birthday");
            return -1;
        }
    }
}
