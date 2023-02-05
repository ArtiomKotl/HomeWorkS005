// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] CreateRandomArray(int num)
{
  int[] array = new int[num];
  Random randome = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = randome.Next(1, 100);
  }
  return array;
}

void PrintArray(int[] arrayPrint)
{
  Console.Write("Полученный массив: [");
  for (int index = 0; index < arrayPrint.Length; index++)
  {
    Console.Write($"{arrayPrint[index]}");
    if (index < arrayPrint.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}

void DifferentMaxMinArray(int[] differentArray)
{
  int min = differentArray[0];
  int max = differentArray[0];
  for (int i = 1; i < differentArray.Length; i++)
  {
    if (min > differentArray[i])
      min = differentArray[i];
    else if (max < differentArray[i])
      max = differentArray[i];
  }
  Console.WriteLine($"Максимальное значение = {max}");
  Console.WriteLine($"Минимальное значение  = {min}");
  Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max - min}");
}

Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
  Console.WriteLine("Введено неверное значение. Попробуйте ещё раз.");
  int.TryParse(Console.ReadLine(), out num);
}
int[] maxMinArray = CreateRandomArray(num);
PrintArray(maxMinArray);
DifferentMaxMinArray(maxMinArray);