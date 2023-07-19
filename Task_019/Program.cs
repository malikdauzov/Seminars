int Palindrome = Convert.ToInt32(Console.ReadLine());
if (Palindrome/10000 == Palindrome%10 && Palindrome /1000%10 == Palindrome%100/10)
Console.WriteLine ("Is Palindrome"); 
else
{
    Console.WriteLine(" is not Palindrome");
}
