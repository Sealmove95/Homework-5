// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[size];
Random numRandom = new Random();
for (int i = 0; i < size; i++)
{
  array[i] = numRandom.Next(100, 1000);
  Console.Write($" {array[i]},");
  
}
for (int i = 0; i < array.Length; i++)
{
  if (i % 2 == 0)
  count++;
}
Console.WriteLine();
Console.Write($"{count}");