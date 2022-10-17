// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int n = 10;
int[] array = new int[n];

for(int i = 0; i < n; i++)
    array[i] = new Random().Next(1,100);
Console.Write("Задан массив: ");
for(int i = 0; i < n; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine();

int a = 0;
double min = array[a];
double max = array[a];
for(int i = 0; i < n; i++)
    if (max < array[i]) 
    max = array[i];
    else
    if (min > array[i]) 
    min = array[i];
    
Console.WriteLine($"Минимальное значение {min}, максимальное {max}");
   
Console.WriteLine($"Разница между {max} и {min} = {max-min}");

