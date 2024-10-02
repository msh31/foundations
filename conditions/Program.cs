Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) { Console.WriteLine($"{firstNumber} is bigger than {secondNumber}"); }
else if (secondNumber > firstNumber) { Console.WriteLine($"{secondNumber} is bigger than {firstNumber}"); }
else { Console.WriteLine($"{firstNumber} and {secondNumber} are equal"); }

if (firstNumber < 0 || secondNumber < 0) { Console.WriteLine("At least one of the numbers is negative"); }