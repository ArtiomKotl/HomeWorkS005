// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int num)
{
  int[] array = new int[num];
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(100, 1000);
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

int countEvenNumbers(int[] evenArray)
{
  int count = 0;
  for (int i = 0; i < evenArray.Length; i++)
  {
    if (evenArray[i] % 2 == 0)
      count++;
  }
  return count;
}

Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
  Console.WriteLine("Введено значение неверное значение. Попробуйте ещё раз.");
  int.TryParse(Console.ReadLine(), out num);
}
int[] randomArray = CreateRandomArray(num);
PrintArray(randomArray);
Console.WriteLine($"Количество чётных чисел в массиве = {countEvenNumbers(randomArray)}");