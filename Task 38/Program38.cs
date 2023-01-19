// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

for (int i = 0; i < size; i++)
{
  array[i] = new Random().NextDouble() + new Random().Next(1, 100);
  Console.Write($" {Math.Round(array[i], 3)},");
  
}
Console.WriteLine();
double maxNum = array[0];
double minNum = array[0];

for (int i = 1; i < array.Length; i++)
{
  if (array[i] > maxNum)
    maxNum = array[i];
  if (array[i] < minNum)
    minNum = array[i];
}
Console.WriteLine();
double result = Math.Round(maxNum, 3) - Math.Round(minNum, 3);
Console.WriteLine(Math.Round(maxNum, 3) + " - " + Math.Round(minNum, 3) + " = " + Math.Round(result, 3)); 