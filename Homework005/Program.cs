// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
int i = 0;
while(i<array.Length)
{
    array[i] = new Random().Next(1,100);
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
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            
        }
        else 
        {
            summ = summ + array[i];            
        }
    }
    Console.WriteLine($"Сумма нечетных чисел в данном массиве равна {summ}");
    Console.WriteLine();
}
PrintResult(array);

    
    

