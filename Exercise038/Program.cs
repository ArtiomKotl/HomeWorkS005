// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


float[] genArray(int N)
{
  float[] arrNum = new float[N];

  Random rnd = new Random();
  for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(-99, 100)) { }

  return arrNum;
}

void printArray(int N, float result)
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

float sumMinMax(float[] arrNum)
{
  float min = arrNum[0];
  float max = arrNum[0];

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
Console.WriteLine( $"{max}, {min}");
  return max - min;
}
int N = amountElements();
float[] arr = genArray(N);
float result = sumMinMax(arr);
printArray(N, result);