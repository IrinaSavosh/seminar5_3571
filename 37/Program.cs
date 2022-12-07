// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
   int[] array = new int[size];
   Random rand = new Random();

   for (int i = 0; i < array.Length; i++)
   {
      array[i] = rand.Next(leftRange, rightRange + 1);
   }

   return array;
}

const int SIZE = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(",", arr));

int[] RezaltArray = new int[arr.Length / 2 + arr.Length % 2];

for (int i = 0; i < arr.Length / 2; i++)
{
   RezaltArray[i] = arr[i] * arr[arr.Length - 1 - i]; // ЗАПОМНИТЬ
}
if (arr.Length % 2 == 1)
{
   RezaltArray[RezaltArray.Length -1] = arr[arr.Length/2];
}
   Console.WriteLine(string.Join(",", RezaltArray));