int n = 10;
int[] array = { 2, 4, 5, 6, 7, 84, 2, 5, 6, 1 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}
