// Задача 2: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = {4, 5, 7, 8, 10, 21, 45};

ReversePrintArray (array, array.Length - 1);
void ReversePrintArray (int[] array, int i)
{
    if (i < 0) return;
    Console.Write(array[i] + " ");
    ReversePrintArray(array, i - 1);
}