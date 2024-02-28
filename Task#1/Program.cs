using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine()!;
        string[] originalArray = input.Split(',');

        string[] newArray = FilterArray(originalArray);

        Console.WriteLine("Новый массив:");
        foreach (string str in newArray)
        {
            Console.Write($"{str.Trim()} ");
        }
    }

    static string[] FilterArray(string[] arr)
    {
        int count = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}
