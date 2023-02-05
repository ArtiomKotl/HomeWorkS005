// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


float[] CreateRandomArray(int num)
{
  float[] array = new float[num];
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.NextSingle()*100 ;
  }
  return array;
}

void PrintArray(float[] arrayPrint)
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

void DifferentMaxMinArray(float[] differentArray)
{
  float diff = 0;
  float min = differentArray[0];
  float max = differentArray[0];
  for (int i = 1; i < differentArray.Length; i++)
  {
    if (min > differentArray[i])
      min = differentArray[i];
    else if (max < differentArray[i])
      max = differentArray[i];
  }
  diff = max - min;
  string result = string.Format("{0:f}", diff);
  Console.WriteLine($"Максимальное значение = {max}");
  Console.WriteLine($"Минимальное значение  = {min}");
  Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {result})");
}

Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
  Console.WriteLine("Введено неверное значение. Попробуйте ещё раз.");
  int.TryParse(Console.ReadLine(), out num);
}
float[] maxMinArray = CreateRandomArray(num);
PrintArray(maxMinArray);
DifferentMaxMinArray(maxMinArray);