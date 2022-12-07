// Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] EnterNumberArray(int size, int leftRange, int rightRange)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
   {
      Console.Write($"Введите число от {leftRange} до {rightRange}: ");
      array[i] = Convert.ToInt32(Console.ReadLine());
   }
   return array;
}

(int, int) MaxAndMin(int[] array)
{
   int i = 0;
   int max = array[i];
   int min = array[i];
   while (i < array.Length)
   {
      if (array[i] > max)
      {
         max = array[i];
      }
      if (array[i] < min)
      {
         min = array[i];
      }
      i++;
   }
   return (max, min);
}
const int SIZE = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 99;

int[] arr = EnterNumberArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));
(int max, int min) = MaxAndMin(arr);
Console.WriteLine($"Максимальное число в массиве равно {max}, а минимальное число равно {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом введенного массива равна {max - min}");