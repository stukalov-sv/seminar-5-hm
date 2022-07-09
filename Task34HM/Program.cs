/*
Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество четных чисел
*/

int[] InitArray(int length)
{
    int[] arr = new int [length];
    Random rnd = new Random();

    for(int i=0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int FindEven (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) 
            result = "[" + result + Convert.ToString(array[i]) + ", ";
        else 
            if(i < array.Length - 1) 
                result = result + Convert.ToString(array[i]) + ", ";
        else
            result = result + Convert.ToString(array[i]) + "]";
    }
    return result;
}

Console.WriteLine("Enter array size:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine($"{PrintArray(arr)} -> Even number count: {FindEven(arr)}");