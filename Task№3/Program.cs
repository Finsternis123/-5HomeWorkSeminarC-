//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int[] Array = GetArray(5);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
int[] Array2 =  Multi(Array);
System.Console.WriteLine($"[{String.Join(",", Array2)}]");


int[] GetArray(int size)
{
    int[] Array = new int[size];
       for(int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1, 10);
    }
    return Array;
}

int[] Multi(int[] Array)
{
    
    int i = 0;
    while (i < Array.Length / 2)
{
    Array[i] *= Array[Array.Length - 1 - i];
    i++;   
}
return Array;
}







