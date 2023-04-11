using StringMethods;

CustomString customString = new CustomString();

//string.Empty
string text = customString.Empty;

//StartWith
string word = "Hello World";
Console.Write("StartWith: ");
Console.WriteLine(customString.StartWith(word, 'H'));

//EndWith
Console.Write("EndWith: ");
Console.WriteLine(customString.EndWith(word, 'e'));

//Length
Console.Write("Length: ");
Console.WriteLine(customString.Length(word));

//IndexOf
Console.Write("IndexOf: ");
Console.WriteLine(customString.IndexOf(word, 'W'));

//LastIndexOf
Console.Write("LastIndexOf: ");
Console.WriteLine(customString.LastIndexOf(word, 'o'));

//Replace
Console.Write("Replace: ");
Console.WriteLine(customString.Replace(word, 'o', 'Z'));

//Remove
Console.Write("Remove: ");
Console.WriteLine(customString.Remove(word, 3));

//SubString
Console.Write("SubString: ");
Console.WriteLine(customString.SubString(word, 1, 8));


//Trim
Console.Write("Trim: ");
Console.WriteLine(customString.Trim("      Hello      World      "));


//Compare
Console.WriteLine(customString.Compare("abc", "ab"));
Console.WriteLine(customString.Compare("abc", "abc"));
Console.WriteLine(customString.Compare("ab", "abc"));

//IsNullOrEmpty
Console.WriteLine(customString.IsNullOrEmpty(""));
Console.WriteLine(customString.IsNullOrEmpty(null));

//IsNullOrWhiteSpace
Console.WriteLine(customString.IsNullOrWhiteSpace(""));
Console.WriteLine(customString.IsNullOrWhiteSpace(null));