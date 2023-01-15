// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив, можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“hello”,”2”,”world”,”:-)”] -> [”2”,”:-)”]
// [“1234”,”1567”,”-2”,”computer science”] -> [”-2”]
// [“Russia”,”Denmark”,”Kazan”] -> []

void Print(string[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] SecondArr(string[] arr)
{
    int size = arr.Length;
    string[] new_arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= 3)
            new_arr[i] = arr[i];
    }
    return new_arr;
}

string[] arr_1 = new string[4] { "hello", "2", "world", ":-)" };
Print(arr_1);
string[] arr_1_new = SecondArr(arr_1);
Print(arr_1_new);
Console.WriteLine();

string[] arr_2 = new string[4] { "1234", "1567", "-2", "computer science" };
Print(arr_2);
string[] arr_2_new = SecondArr(arr_2);
Print(arr_2_new);
Console.WriteLine();

string[] arr_3 = new string[3] { "Russia", "Denmark", "Kazan" };
Print(arr_3);
string[] arr_3_new = SecondArr(arr_3);
Print(arr_3_new);
Console.WriteLine();

