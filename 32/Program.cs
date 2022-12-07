// Задача 32: Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

int[] GetReversalSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = array[i] * -1;
    }
    return array;
}
const int SIZE = 6;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));
int[] arrRev = GetReversalSign(arr);
Console.WriteLine(string.Join(", ", arrRev));