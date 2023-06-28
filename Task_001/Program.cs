/*
Напишите программу которая на вход принимает два числа и проверяет, является ли первое 
число квадратом второго.
а = 25； b = 5 -> да
*/
/*int number1  = Convert.ToInt32(Console.ReadLine());
int number2  = Convert.ToInt32(Console.ReadLine());
if (number1==number2*number2)
{
    Console.WriteLine("Number"  +  number1 + "является квадратом числа"  +  number2);
}
else
{
    Console.WriteLine("Number" + number1 + " не является квадратом числа" + number2);
}
*/

Console.Write("input first number"); 
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number"); 
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Number" + firstNumber + "является квадратом числа" + secondNumber);
}

else 
{
    Console.WriteLine("Number" + firstNumber + " Не является квадратом числа" + secondNumber);
}

