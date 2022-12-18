// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//Например:
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


int[] array = GenArray(123,-100,100);
PrintArray(array);
Console.WriteLine();
int[] result = ConvertArr(array);
PrintArray(result);
Console.WriteLine();

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int[] ConvertArr(int[] array)
{
    int[] outArr = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        outArr[i]=array[i]*array[array.Length-1 -i];
    }
    return outArr;
}