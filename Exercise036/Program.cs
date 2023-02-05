// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int num)
{
  int[] array = new int[num];
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(-99, 100);
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

int sumOddElements(int[] sumArray)
{
  int sum = 0;
  for (int i = 0; i < sumArray.Length; i = i + 2)
  {
    sum = sum + sumArray[i];
  }
  return sum;
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
Console.WriteLine($"Сумма нечётных элементов массива = {sumOddElements(randomArray)}");
