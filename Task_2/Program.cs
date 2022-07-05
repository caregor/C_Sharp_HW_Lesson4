/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Promt (string message)
{
    System.Console.Write(message);
    int ret = int.Parse(Console.ReadLine());
    return ret;
}

int CalcDigitsInNumber (int n)
{
    int res = 0;
    while (n> 0)
    { 
        res = res + n % 10;
        n = n / 10;
    }
    return res;
}

int number = Promt("Enter a number: ");
System.Console.Write($"{number} -> ");

int summ = CalcDigitsInNumber(number);
System.Console.WriteLine(summ);
