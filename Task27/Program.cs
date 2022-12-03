// Задача 27. Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");

string? n = Console.ReadLine();
int length = n.Length;
int[] array = new int[length];

int sum = 0;
int count = 0;

while (count < length)
{
    array[count] = Convert.ToInt32(n[count].ToString());
    count++;
}
for (int i = 0; i < length; i++)
    sum = sum + array[i];

Console.WriteLine($"Сумма цифр в числе: {sum}");