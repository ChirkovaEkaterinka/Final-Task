/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры или задать на старте выполнения алгоритма */

Console.WriteLine("Введите количество строк, которые хотите ввести: ");
int count = int.Parse(Console.ReadLine());
string[] arrayStart = GetArray(count);
Console.Write("Введенный массив: ");
PrintArray(arrayStart);
string[] newArray = ArrayIfThreeOrLess(arrayStart);
Console.Write("Полученный массив : ");
PrintArray(newArray);

string[] GetArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку №{0}:  ", i);
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ; ");
    }
    Console.WriteLine();
}

string[] ArrayIfThreeOrLess(string[] array)
{
    int count = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}

