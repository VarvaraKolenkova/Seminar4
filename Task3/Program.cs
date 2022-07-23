// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 50);
    }
}

void PrintArray(int [] col)
{
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write($"{col[position]}, ");
    }
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);
