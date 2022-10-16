// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int n = 10;
int[] array = new int[n];

for(int i = 0; i < n; i++)
    array[i] = new Random().Next(0,100);
Console.Write("Задан массив: ");
for(int i = 0; i < n; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine();

int[] PairNumbers(int[] array)
{
    int[] result = new int[array.Length / 2];
    int last = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[last];
        last = last - 1;
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
   {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Произведение пар чисел: ");
PrintArray(PairNumbers(array));