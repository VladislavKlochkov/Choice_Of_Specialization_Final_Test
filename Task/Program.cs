// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreateArray(int number)
{
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}й элемент:");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"“{array[i]}”, ");
        else Console.Write($"“{array[i]}”");
    }
    Console.Write("]");
}

string[] ArrayTransformation(string[] array, int size)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) j++;
    }
    string[] newArray = new string[j];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите количество элементов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное количество символов в искомых элементах:");
int s = Convert.ToInt32(Console.ReadLine());
if (n < 0 || s < 0)
{
    Console.WriteLine("Количество элементов в массиве или количество символов в элементе введено неверно");
}
else
{
    string[] arr = CreateArray(n);
    PrintArray(arr);
    string[] newArr = ArrayTransformation(arr, s);
    Console.Write($" --> ");
    PrintArray(newArr);
}