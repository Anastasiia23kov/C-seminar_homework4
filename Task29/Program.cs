// Задача 29. Программа задает массив из 8 элементов и выводит их на экран.

Console.Clear();

int [] array = new int [8];
for(int i=0; i<array.Length; i++)
{
    Console.Write($"Введите элемент {i+1} массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");