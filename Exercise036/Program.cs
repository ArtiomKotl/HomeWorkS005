// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] genArray(int N)
{
  int[] arrNum = new int[N];

  Random rnd = new Random();
  for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(-99, 100)) { }

  return arrNum;
}

void printArray(int N, int result)
{
  Console.Write($"[{String.Join(", ", genArray(N))}] сумма элементов, стоящих на нечётных позициях -> {result}\n");
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
int sumOddElements(int[] arrNum)
{
  int sum = 0;
  for (int i = 0; i < arrNum.Length; i = i + 2)
  {
    sum = sum + arrNum[i];
  }
  return sum;
}
int N = amountElements();
int[] arr = genArray(N);
int result = sumOddElements(arr);
printArray(N, result);
