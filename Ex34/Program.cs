// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
result++;

Console.WriteLine($"Количество чётных чисел в данном массиве равняется {result}");

void FillArray(int[]numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] numbers)
{
    int count = numbers.Length;
    Console.WriteLine($"[{String.Join("; ", numbers)}]"); 
}



