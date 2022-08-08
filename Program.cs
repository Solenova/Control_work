// Задача:
// Написать программу, которая из имеющегося массива строк, формирует массив из строк, 
// длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567","-2","computer science"] -> ["-2"]
// ["Russia","Denmark", "Kazan"] -> []

string[] ArrayString(int size)
{
    string[] arrString = new string[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент строкового массива - ");
        arrString[i] = Console.ReadLine();
    }
    return arrString;
}

string[] arrStringNumElements(int[] arr)
{
    string[] arrTemp= new string[];
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i].Length <3 )
        {
            arrTemp[count] = arr[i];
            count+=1;
        }
    }
    return new string[] {arrTemp};
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}

// void PrintSumPosNegElem(int[] sum)
// {
//     Console.WriteLine();
//     Console.WriteLine($"Сумма положительных чисел = {sum[0]}");
//     Console.WriteLine($"Сумма отрицательных чисел = {sum[1]}");
// }
string[] array=ArrayString(5);
PrintArray(array);
string[] arrayNew=arrStringNumElements(array);
PrintArray(arrayNew);
// int [] sumPosNegElem=GetSumPosNegElem(array);
// PrintSumPosNegElem(sumPosNegElem);