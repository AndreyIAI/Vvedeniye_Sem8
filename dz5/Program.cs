System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[,] array = new int[size, size];
int temp = 1;
int j = 0;
int i = 0;
while (temp <= size * size)
{
    array[i, j] = temp;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    temp++;
}
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        System.Console.Write($"{array[x, y]}\t");
    }
    System.Console.WriteLine();
}