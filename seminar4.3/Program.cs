int[] Arr = new int[8];
Random rand = new Random();

void FillingArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = rand.Next(-100, 100);
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + ", ");
    }
    Console.Write(" ]");
}

FillingArrayRandom(Arr);
PrintArray(Arr);