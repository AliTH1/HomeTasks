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
string word2 = "   Ali    ";
Console.WriteLine("Trim: ");
Console.Write(customString.Trim(word2));