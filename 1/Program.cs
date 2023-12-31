﻿// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел для ввода: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];

InputArray(m);
Console.WriteLine("[{0}]", string.Join(", ", arr));
Console.WriteLine($"Количество чисел больше нуля: {Count(m)}");

void InputArray(int count)
{
    for (int i = 0; i < count; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Count(int quantity)
{
    int count = 0;
    for (int i = 0; i < quantity; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}