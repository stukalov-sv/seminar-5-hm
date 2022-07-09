/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечетных позициях
*/

int[] InitArray(int length)
{
    int[] arr = new int [length];
    Random rnd = new Random();

    for(int i=0; i < length; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

int FindOddIndexSumm (int[] array)
{
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            summ += array[i];
    }
    return summ;
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

Console.WriteLine($"{PrintArray(arr)} -> Odd number summ: {FindOddIndexSumm (arr)}");