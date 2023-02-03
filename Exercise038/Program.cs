// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] genArray(int N)
{
  int[] arrNum = new int[N];

  Random rnd = new Random();
  for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(1, 100)) { }

  return arrNum;
}

void printArray(int N, int result)
{
  Console.Write($"[{String.Join(", ", genArray(N))}] разница между максимальным и минимальным элементом массива -> {result}\n");
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

int diffMinMax(int[] arrNum)
{
  int min = arrNum[0];
  int max = arrNum[0];

  for (int i = 1; i < arrNum.Length; i++)
  {
    if (min > arrNum[i])
    {
      min = arrNum[i];
    }
    else if (max < arrNum[i])
    {
      max = arrNum[i];
    }
  }
  return max - min;
}
int N = amountElements();
int[] arr = genArray(N);
int result = diffMinMax(arr);
printArray(N, result);