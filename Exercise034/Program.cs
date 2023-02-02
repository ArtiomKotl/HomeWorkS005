// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] genArray(int N)
{
  int[] arrNum = new int[N];

  Random rnd = new Random();
  for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(100, 1000)) { }

  return arrNum;
}

void printArray(int N, int result)
{
  Console.Write($"[{String.Join(", ", genArray(N))}] количество чётных чисел в массиве -> {result}\n");
}

int amountElements()
{
  int varValue = 0;
  bool isNumeric = false;

  while (!isNumeric)
  {
    Console.Write($"Введите число элементов массива: ");
    isNumeric = int.TryParse(Console.ReadLine(), out varValue);
    if (varValue < 0)
    {
      isNumeric = false;
    }
  }

  return varValue;
}
int countEvenNumbers(int[] arrNum)
{
  int count = 0;
  for (int i = 0; i < arrNum.Length; i++)
  {
    if (arrNum[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}
int N = amountElements();
int[] arr = genArray(N);
int result = countEvenNumbers(arr);
printArray(N, result);
