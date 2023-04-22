using ReflectionTask.Models;
using System.Reflection;

//Assembly assembly = Assembly.GetExecutingAssembly();
//Type type = assembly.GetType(typeof(User).ToString());
Type type = typeof(User);

User user1 = Activator.CreateInstance(typeof(User)) as User;

PropertyInfo propId = type.GetProperty("Id", BindingFlags.Instance|BindingFlags.NonPublic);
PropertyInfo propName = type.GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic);
PropertyInfo propSurname = type.GetProperty("Surname", BindingFlags.Instance | BindingFlags.NonPublic);
PropertyInfo propAge = type.GetProperty("Age", BindingFlags.Static | BindingFlags.NonPublic);

propId.SetValue(user1, 5);
propName.SetValue(user1, "Ali");
propSurname.SetValue(user1, "Taghizada");
propAge.SetValue(null, 21);

Console.WriteLine("Id: " + propId.GetValue(user1));
Console.WriteLine("Name: " + propName.GetValue(user1));
Console.WriteLine("Surname: " + propSurname.GetValue(user1));
Console.WriteLine("Age: " + propAge.GetValue(user1));


MethodInfo methodGetFullName = type.GetMethod("GetFullName");
Console.Write("\nFull name: ");
methodGetFullName.Invoke(user1, null);

MethodInfo methodChangeAge = type.GetMethod("ChangeAge");
methodChangeAge.Invoke(user1, new object[] { 25 });
Console.WriteLine("Age changed");
Console.WriteLine("Age: " + propAge.GetValue(user1));