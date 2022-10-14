// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
int i = 0;
while(i<array.Length)
{
    array[i] = new Random().Next(100,999);
    i++;
}
Console.Write("Ваш массив: ");
i = 0;
while (i < array.Length)
{
    Console.Write($"{array[i]} ");
    i++;
}
Console.WriteLine();

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            even++;
        }
        else 
        {
            uneven++;
        }
    }
    Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
    Console.WriteLine();
}

PrintResult(array);
