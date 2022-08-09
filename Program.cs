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
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
string[] ArrayString(int size)
{
    string[] arrString = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент строкового массива - ");
        arrString[i] = Console.ReadLine();
    }
    return arrString;
}

string[] arrStringNumElements(string[] arr)
{
    string[] arrTemp;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            count++;
    }
    if (count!=0) arrTemp = new string[count];
    else arrTemp = new string[count+1];
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrTemp[count] = arr[i];
            count++;
        }
    }
    return arrTemp;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.WriteLine(arr[i] + "]");
    }
}

int n = InputNumbers("Введите количество элементов массива ");
string[] array = ArrayString(n);
PrintArray(array);
string[] arrayNew = arrStringNumElements(array);
PrintArray(arrayNew);


