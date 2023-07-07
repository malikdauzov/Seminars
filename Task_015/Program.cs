// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int userInput = Convert.ToInt32(Console.ReadLine());
if (userInput <= 5)
{
    Console.WriteLine("Today is a work day");
}

else if (userInput == 6 || userInput == 7)
{
   Console.WriteLine("Today is a relax day"); 
}
