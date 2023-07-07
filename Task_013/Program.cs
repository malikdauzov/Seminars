// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int randomNumber = new Random(). Next(111,999);

 
//  int numberThree = randomNumber % 100;
//  int result = numberThree  % 10;
//  Console.WriteLine(randomNumber);
//  Console.WriteLine(result);
    
    
Console.WriteLine("Enter a number:"); 
int number = Convert.ToInt32(Console.ReadLine()); 
 
while (number > 999) 
{ 
    number = number / 10; 
 
} 
 
if (number < 100) 
{ 
    Console.WriteLine("No third digit."); 
} 
else 
{ 
    int result = number % 10; 
    Console.WriteLine("Third number of the entered digit: " + result);
}