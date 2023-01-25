// Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввёл пользователь.
//0,7,8,-2,-2 ->2
//1,-7,567,89,223 -> 4 

Console.WriteLine("Введите числа:");
string number = Console.ReadLine()!;
string[] GetDigit = new string[number.Length];
int N = 0;
for (int i = 0; i < GetDigit.Length; i++)
{
    if (number[i] == ',')
    {
        N++;
    }
    else
    {
        GetDigit[N] = GetDigit[N] + $"{number[i]}";
    }
}
N++;
int[] resultNumber = new int[N];
PrintArray(resultNumber, GetDigit);
int sum = 0;
for (int i = 0; i < N; i++)
{
    if (resultNumber[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine("Количество чисел больше 0: " + sum);

void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(string1[i]);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}