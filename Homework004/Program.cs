// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int n = 123;
int[] array = new int[n];

for(int i = 0; i < n; i++)
    array[i] = new Random().Next(0,500);

int count = 1;
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
    if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine();
Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");



