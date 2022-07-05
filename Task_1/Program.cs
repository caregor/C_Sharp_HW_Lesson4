/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Pow (int a, int b)
{
    int res = a;
    for (int i=1; i < b; i++)
    {
        res = res * a;
    }
return res;
}

int Promt (string message)
{
    System.Console.Write(message);
    int ret = int.Parse(Console.ReadLine());
    return ret;
}

int A = Promt("Enter a A number: ");
int B = Promt("Enter a B number: ");

System.Console.WriteLine($"{A}, {B} -> {Pow(A,B)}");