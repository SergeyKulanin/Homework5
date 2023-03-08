// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int sum = 0;

for (int i = 1; i < numbers.Length; i+=2)
sum=sum+numbers[i];

Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равняется {sum}");

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
