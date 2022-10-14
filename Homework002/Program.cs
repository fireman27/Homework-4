// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int n = 12;
int[] array = new int[n];

for(int i = 0; i < n; i++)
    array[i] = new Random().Next(0,9);
Console.Write("Задан массив: ");
for(int i = 0; i < n; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine();

void PrintResult(int[] array)
{
    int plus = 0;
    int minus = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] > 0) plus = plus + array[i];
        else minus = minus + array[i];
        
    }
    Console.WriteLine($"Сумма положительных элементов массива = {plus}, сумма отрицательных элементов массива {minus}");
    Console.WriteLine();
}

PrintResult(array);



