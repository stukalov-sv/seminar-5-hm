/*
Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементами массива
*/

double[] InitArray(int length)
{
    double[] arr = new double [length];
    Random rnd = new Random();

    for(int i=0; i < length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return arr;
}

double GetMaxMinDiff (double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
            maxNumber = array[i];
        else
            if (array[i] < minNumber) 
                minNumber = array[i];
    }
    double diff = Math.Round(maxNumber - minNumber, 1);
    return diff;
}

string PrintArray(double[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) 
            result = "[" + result + Convert.ToString(array[i]) + " ";
        else 
            if(i < array.Length - 1) 
                result = result + Convert.ToString(array[i]) + " ";
        else
            result = result + Convert.ToString(array[i]) + "]";
    }
    return result;
}

Console.WriteLine("Enter array size:");
int length = int.Parse(Console.ReadLine());
double[] arr = InitArray(length);

Console.WriteLine($"{PrintArray(arr)} -> Max and min numbers difference: {GetMaxMinDiff(arr)}");