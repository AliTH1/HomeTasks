﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomValidator
{
    public static class CustomValidators
    {
        public static string UsernameValidator(string username)
        {
            if(username.Length > 2)
            {
                return username;
            }
            return "Incorrect username";
        }

        public static string NameValidator(string name)
        {
            if (name.Length > 2) 
            {
                return name;
            }
            return "Incorrect name";
        }

        public static string SurnameValidator(string surname)
        {
            if (surname.Length > 2)
            {
                return surname;
            }
            return "Incorrect surname";
        }

        public static string PasswordValidator(string password)
        {
            string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$";
            if (Regex.IsMatch(password, pattern))
            {
                return password;
            }
            return "Incorrect password";
        }

        public static int AgeValidator(int age)
        {
            if (age > 0)
            {
                return age;
            }
            Console.Write("Incorrect age: ");
            return -1;
        }

        public static int BirthdayValidator(int birthday)
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
