/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "");
int reverseNumber = 0;
int temporaryNumber = number;


int ReverseNumber(int number)
{
    while (number > 0)
    {
        int digit = number % 10;
        reverseNumber = reverseNumber * 10 + digit;
        number = number / 10;
    }
    return (reverseNumber);
}

if (ReverseNumber(number) == temporaryNumber)
{
    Console.WriteLine($"Это палиндром");
}
else
{
    Console.WriteLine($"Это не палиндром");
}