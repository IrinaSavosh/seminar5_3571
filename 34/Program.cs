// Домашняя работа
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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



int EvenNumber(int[] array)
{
   int evenNumber = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0)
      {
         evenNumber++;
      }
   }
   return evenNumber;
}
const int SIZE = 6;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 1000;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));
int evenNumber = EvenNumber(arr);
Console.WriteLine($"Количество четных чисел равна {evenNumber}");







// Случайно написала этот метод, но решила не удалять на случай необходимости воспользоваться
// int GetQuantityPositive(int[] array)
// {
//    int quantityPositive = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] > 0)//элемент массива положительный
//       {
//          quantityPositive++;
//       }
//    }
//    return quantityPositive;
// }