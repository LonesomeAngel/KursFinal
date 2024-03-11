// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

class Program
{
    static void Main(string[] args)
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива (разделяйте каждый элемент нажатием клавиши Enter). Для завершения введите пустую строку:");
        string[] inputArray = ReadInputArray();

        // Формирование нового массива из строк, длина которых <= 3 символам
        string[] resultArray = FilterShortStrings(inputArray);

        // Вывод результата
        Console.WriteLine("\nРезультат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    // Метод для ввода массива строк с клавиатуры
    static string[] ReadInputArray()
    {
        var inputList = new System.Collections.Generic.List<string>();
        string input;
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            inputList.Add(input);
        }
        return inputList.ToArray();
    }

    // Метод для формирования нового массива из строк, длина которых <= 3 символам
    static string[] FilterShortStrings(string[] inputArray)
    {
        var resultList = new System.Collections.Generic.List<string>();
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultList.Add(str);
            }
        }
        return resultList.ToArray();
    }
}