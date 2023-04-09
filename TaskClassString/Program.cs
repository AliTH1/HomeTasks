using System.Text;
using TaskClassString.Models;

Student[] students = new Student[3];
students[0] = new Student("Ali", "Taghizada", "AB201", 89.4, true);
students[1] = new Student("Ali", "Safarli", "AB201", 78.4, false);
students[2] = new Student("Hikmat", "Habibli", "AP208", 84.3, false);


StringBuilder result = new StringBuilder();
Console.WriteLine(result.Append(students[0].GetInfo()));


StringBuilder result2 = new StringBuilder();
Console.WriteLine(result2.Append(students[1].GetInfo()));


StringBuilder result3 = new StringBuilder();
Console.WriteLine(result3.Append(students[2].GetInfo()));