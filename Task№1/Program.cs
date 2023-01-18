//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] Array = GetArray(4); 
Console.WriteLine($"[{String.Join(";", Array)}]");

int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(100, 999);
    } 
    return Array; 
}

int count = 0;
foreach (int el in Array)
{
    if((el % 2) == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чётных чисел {count}");

