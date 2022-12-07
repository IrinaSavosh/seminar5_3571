// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int OddPposition(int[] array)
{
   int sumOddPos = 0;
   for (int i = 1; i < array.Length; i += 2)
   {

      sumOddPos = sumOddPos + array[i];

   }
   return sumOddPos;
}

const int SIZE = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));
int sumOddPos = OddPposition(arr);
Console.WriteLine(sumOddPos);
