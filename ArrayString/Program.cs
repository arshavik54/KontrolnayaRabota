// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
int n;
string[] arr;
string[] array3str;

Console.Write("Введите колличество элементов: ");
n = int.Parse(Console.ReadLine());

arr = new string[n];
array3str = new string[n];
Console.WriteLine("Введите массив: ");

for (int i = 0; i < arr.Length; i++) 
{
   Console.Write($"arr[{i}] = ");
   arr[i] = Console.ReadLine();
}
 
void CreateArray(string[] arr, string[] array)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array[j] = arr[i];
            j++;
        }
    }
}

void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]},");
    }
    Console.WriteLine();
}   

CreateArray(arr, array3str);
Console.WriteLine();
PrintArray(arr);
PrintArray(array3str);