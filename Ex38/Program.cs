// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int [size];
FillArray(numbers);
PrintArray(numbers);
int max = 0;
int min = 0;
int Diff = 0;
int i = 0;

for (i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {   
     max = numbers[i];
     min = max;
    }    

    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Diff = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равняется {Diff}");

void FillArray(int[]numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] numbers)
{
    int count = numbers.Length;
    Console.WriteLine($"[{String.Join("; ", numbers)}]"); 
}
