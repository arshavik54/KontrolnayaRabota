// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Clear();
int n;  // колличество элементов в начальном массиве
string[] arr; // начальный массив
string[] arr1;  // результат

Console.Write("Введите колличество элементов: ");  
n = int.Parse(Console.ReadLine());


arr = new string[n];
arr1 = new string[n];


Console.WriteLine("Введите массив: ");

for (int i = 0; i < arr.Length; i++) 
{
   Console.Write($"arr[{i}] = ");
   arr[i] = Console.ReadLine();
}

string[] CreateArray(string[] array, string[] newarr)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newarr[j] = array[i];
        j++;
        }
    }
    return newarr;
}

string[] now = CreateArray(arr,arr1);
var strnow = string.Join(",", now);
var strarr = string.Join(", ", arr);
Console.Write('[');
Console.Write(strarr);
Console.Write(']');
Console.Write('-');
Console.Write('>');

Console.Write('[');
Console.Write(strnow);
Console.Write(']');

