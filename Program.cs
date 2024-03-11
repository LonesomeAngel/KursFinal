// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArray;

        // Если аргументы командной строки отсутствуют или их количество недостаточно для формирования массива, запрашиваем ввод с клавиатуры
        if (args.Length < 1)
        {
            // Вводим массив с клавиатуры
            Console.WriteLine("Введите строки для массива (введите пустую строку для завершения ввода):");
            inputArray = ReadInputArray();
        }
        else
        {
            inputArray = args;
        }

        // Формирование нового массива из строк, длина которых <= 3 символам
        string[] resultArray = FilterArray(inputArray);

        // Вывод результата
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] ReadInputArray()
    {
        // Временный список для хранения введенных строк
        string[] tempArray = new string[100]; // Максимальное количество строк - 100
        int count = 0;

        // Чтение строк с клавиатуры
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) // Проверка на пустую строку для завершения ввода
                break;

            tempArray[count++] = input;
        }

        // Создание массива с длиной, соответствующей количеству введенных строк
        string[] inputArray = new string[count];
        Array.Copy(tempArray, inputArray, count);

        return inputArray;
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Подсчёт количества строк, удовлетворяющих условию
        int resultCount = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
                resultCount++;
        }

        // Создание массива с подходящими строками
        string[] resultArray = new string[resultCount];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
                resultArray[index++] = str;
        }

        return resultArray;
    }
}