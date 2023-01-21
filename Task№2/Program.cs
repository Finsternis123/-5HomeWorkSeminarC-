//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
int[] Array = GetArray(5); 
Console.WriteLine($"[{String.Join(";", Array)}]");


int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(10, 20);
    }
    return Array;
}    

int sum = 0;
for (int i = 0; i < Array.Length; i += 2)
{
    sum += Array[i];
}

Console.WriteLine($"Сумма элементов на нечётных индексах {sum}");

    








