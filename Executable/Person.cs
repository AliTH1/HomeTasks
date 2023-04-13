using CustomValidator;
using System.ComponentModel.DataAnnotations;

namespace Executable
{
    public class Person
    {

        public Person(string username, string name, string surname, string password,
            int age, int birthday) 
        {
            Username = CustomValidators.UsernameValidator(username);
            Name = CustomValidators.NameValidator(name);
            Surname = CustomValidators.SurnameValidator(surname);
            Password = CustomValidators.PasswordValidator(password);
            Age = CustomValidators.AgeValidator(age);
            Birthday = CustomValidators.BirthdayValidator(birthday);
        }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set; }
    }
}
