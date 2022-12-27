// Написать программу, которая из имеющегося массива строк
//формирует масив из строк, длина которых меньше или равна 3 символа.

// Программа
string valueLenght = GetValue("Введите длину массива");
bool isValueValid = IsNumberInt(valueLenght);
if (isValueValid)
{
    int numLenght = int.Parse(valueLenght);
    if (numLenght > 0)
    {
        string[] myArray = CreateStringArray(numLenght);
        Console.WriteLine();
        Console.WriteLine("Исходный массив:");
        PrintArray(myArray);
        Console.WriteLine();
        int countElements = FindThreeCharElements(myArray);
        if (countElements > 0)
        {
            string[] resultArray = CreateThreeCharElementsArray(myArray,countElements);
            Console.WriteLine("Результирующий массив:");
            PrintArray(resultArray);
        }
        else
        {
            Console.WriteLine("В массиве нет элементов, длина которых меньше или равна 3 символа");
        }
    }
    else
    { Console.WriteLine("Ошибка"); }
}
else
{ Console.WriteLine("Неверные данные"); }




//Методы

string GetValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}

bool IsNumberInt(string valueB)
{
    bool IsIntNum = Int32.TryParse(valueB, out int Exp2);
    if (IsIntNum)
        return true;
    return false;
}

string[] CreateStringArray(int N)
{
    string[] array = new string[N];

    for (int i = 0; i < N; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int FindThreeCharElements(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] CreateThreeCharElementsArray(string[] arr, int N)
{
    string[] threeCharArray = new string[N];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            threeCharArray[j] = arr[i];
            j++;
        }
    }
    return threeCharArray;
}
