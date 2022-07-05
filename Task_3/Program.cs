/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] GetRandomArray (int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next();
    }
    return mas;
}

void PrintArray (int[] massive)
{
    for (int i = 1; i < massive.Length; i++)
    {
        System.Console.Write(massive[i - 1] + ", ");
    }
    System.Console.WriteLine(massive[massive.Length - 1]);
    System.Console.WriteLine();
}

int[] array = GetRandomArray(8);

PrintArray(array);



