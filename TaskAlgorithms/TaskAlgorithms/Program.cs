#region Task1
//Task 1 - Verilən ədədi tərsinə çevirən alqoritm ( məsələn input 5987, output 7895)

//Version - 1
//int number = 3948;
//int reversedNumber = 0;
//int save = 0;

//while (number > 0)
//{
//    save = number % 10;
//    number /= 10;
//    reversedNumber *= 10;
//    reversedNumber += save;
//}


//Console.WriteLine(reversedNumber);



//Version - 2
//int number = 3948;

//string reversedNumber = "";

//while(number > 0)
//{
//    reversedNumber += number % 10;
//    number /= 10;
//}

//Console.WriteLine(reversedNumber);

#endregion


#region Task2
//Task 2 - Verilən ədədin önünə 3 elave eden alqoritm məsələn ( input 257, output 3257)


//Version 1
int number = 16311;
int copyNumber = number;
int count = 1;
while (copyNumber > 0)
{
    copyNumber /= 10;
    count *= 10;
}

Console.WriteLine(number += 3 * count);






//Version2
//int number = 161;
//int copyNumber = number;
//int count = 0;
//while (copyNumber > 0)
//{
//    copyNumber /= 10;
//    count++;
//}

//switch (count)
//{
//    case 1: number += 30; break;
//    case 2: number += 300; break;
//    case 3: number += 3000; break;
//    case 4: number += 30000; break;
//    case 5: number += 300000; break;
//    case 6: number += 3000000; break;
//    case 7: number += 30000000; break;
//    case 8: number += 300000000; break;
//    default:
//        Console.WriteLine("Rəqəm daxil edilməyib və ya sıfırdır"); break;
//}

//Console.WriteLine(number);




//Version2
//int number = 485;

//string addedNumber = "3" + number;

//Console.WriteLine(addedNumber);

#endregion