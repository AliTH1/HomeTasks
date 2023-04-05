#region Task1
//PrintNumber(EvenOrOddNumber(6));

//int EvenOrOddNumber(int number)
//{
//    return number % 2;
//}

//void PrintNumber(int number)
//{
//    if (number != 0)
//    {
//        Console.WriteLine("Odd number");
//    }
//    else
//    {
//        Console.WriteLine("Even number");
//    }
//}
#endregion


#region Task2
PrintPrimeNumber(PrimeNumbers(9));


int[] PrimeNumbers(int number)
{
	int[] numbers = new int[0];
	int count = 0;
	int copyNumber = number;
	for (int i = 2; i < number; i++)
	{
		if (number % i == 0)
		{
			while(copyNumber > 1)
			{
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[count] = i;
                count++;

				copyNumber /= i;
            }
		}
	}

	return numbers;
}

void PrintPrimeNumber(int[] numbers)
{
	foreach (var number in numbers)
	{
		Console.WriteLine(number);
	}
}
#endregion


#region Task3
//PrintResultCalc(Sum(5, 5));
//PrintResultCalc(Difference(30, 5));
//PrintResultCalc(Multiplication(4, 3));
//PrintResultCalc(Division(15, 5));

////Sum
//double Sum(double number1, double number2)
//{
//    return number1 + number2;
//}


////Difference
//double Difference(double number1, double number2)
//{
//    return number1 - number2;
//}


////Multiplication
//double Multiplication(double number1, double number2)
//{
//    return number1 * number2;
//}


////Divide
//double Division(double number1, double number2)
//{
//    return number1 / number2;
//}


//void PrintResultCalc(double result)
//{
//    Console.WriteLine(result);
//}
#endregion