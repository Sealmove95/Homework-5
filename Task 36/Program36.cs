// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:");
int size = Convert.ToInt32(Console.ReadLine());
int sumElement = 0;
int[] array = new int[size];
Random numRandom = new Random();
for (int i = 0; i < size; i++)
{
  array[i] = numRandom.Next(-10, 10);
  Console.Write($" {array[i]},");
  
}
for (int i = 0; i < array.Length; i++)
{
  if (i % 2 == 0)
  sumElement = sumElement + array[i];
}
Console.WriteLine();
Console.Write($"{sumElement}");
