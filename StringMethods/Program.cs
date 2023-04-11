using StringMethods;

CustomString customString = new CustomString();

//string.Empty
string text = customString.Empty;


//StartWith
string word = "Hello World";
Console.Write("StartWith: ");
Console.WriteLine(customString.CStartWith(word, 'H'));


//EndWith
Console.Write("EndWith: ");
Console.WriteLine(customString.CEndWith(word, 'e'));


//Length
Console.Write("Length: ");
Console.WriteLine(customString.CLength(word));


//IndexOf
Console.Write("IndexOf: ");
Console.WriteLine(customString.CIndexOf(word, 'W'));


//LastIndexOf
Console.Write("LastIndexOf: ");
Console.WriteLine(customString.CLastIndexOf(word, 'o'));


//Replace
Console.Write("Replace: ");
Console.WriteLine(customString.CReplace(word, 'o', 'Z'));


//Remove
Console.Write("Remove: ");
Console.WriteLine(customString.CRemove(word, 3));

//SubString
Console.Write("SubString: ");
Console.WriteLine(customString.CSubString(word, 1, 8));


//Trim
Console.Write("Trim: ");
Console.WriteLine(customString.CTrim("      Hello      World      "));


//Split
string greeting = "Hello World ";
Console.Write("Split: ");

foreach (var item in customString.CSplit(greeting, ' '))
{
    Console.WriteLine(item);
}



//Join
string[] arr = { "C#", "Java", "Python" };

Console.Write("Join: ");
Console.WriteLine(customString.CJoin(arr, " "));


//Compare
Console.WriteLine(customString.CCompare("abc", "ab"));
Console.WriteLine(customString.CCompare("abc", "abc"));
Console.WriteLine(customString.CCompare("ab", "abc"));


//IsNullOrEmpty
Console.WriteLine(customString.CIsNullOrEmpty(""));
Console.WriteLine(customString.CIsNullOrEmpty(null));


//IsNullOrWhiteSpace
Console.WriteLine(customString.CIsNullOrWhiteSpace(""));
Console.WriteLine(customString.CIsNullOrWhiteSpace(null));