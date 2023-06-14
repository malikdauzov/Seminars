
// Console.Write("input first number"); 
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("input second number"); 
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine("Number" + firstNumber + "является квадратом числа" + secondNumber);
// }

// else
// {
//     Console.WriteLine("Number" + firstNumber + " Не является квадратом числа" + secondNumber);
// }


Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N *(-1); // -N, N = 5, negativeN = 5 *(-1) = -5

while(negativeN <=N)
{
    Console.WriteLine(negativeN);//negativeN = -2
    negativeN = negativeN +1;//negativeN ++
}
 