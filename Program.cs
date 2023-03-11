// Урок 4. Функции

/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
// 2, 4 -> 16*/

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;
int stepen1 = Auto ();
int Auto()
{
for (int i = 1; i < b; i++)
{
stepen = stepen * a;
}
return stepen;
}
Console.WriteLine($"{a} в степени {b} равно: " + stepen1);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// // 9012 -> 12

int getUserData(string message)
{
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getNumberSum(int number)
{
    int NumberSum = 0;
    while (number > 0)
    {
        NumberSum = NumberSum + number % 10;
        number =  number / 10;
    }
    return NumberSum;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.Write(data);
    Console.ResetColor();
}
int number = getUserData ("Введите число");
int NumberSum = getNumberSum(number);
showData($"Сумма цифр в числе {number} = ", NumberSum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

   int lenArray = ReadInt("Введите длину массива: ");

    int[] randomArray = new int[lenArray];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1, 19);
        Console.Write(randomArray[i] + " ");
    }
        // Функция ввода
    int ReadInt(string input)
    {
        Console.Write(input);
        return Convert.ToInt32(Console.ReadLine());
    }
