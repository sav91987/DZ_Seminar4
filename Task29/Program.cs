Console.WriteLine("Введите число элементов массива: ");
int length = int.Parse(Console.ReadLine());

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(11);
    }
    return array;
}

int[] resultArray = GetArray(length);

Console.WriteLine($"[{String.Join("\t", resultArray)}]");