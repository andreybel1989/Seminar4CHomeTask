// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




using System.Globalization;

int GetPowNumber(int num, int power)


{
    int result = 1;
    int index = 1;
    while (index <= power)
    {
        result *= num;
        index++;
    }
    return result;
}

int GetNumber()
{
    Console.WriteLine("input number");
    return Convert.ToInt32(Console.ReadLine());
}

int GetPower()
{
    Console.WriteLine("input power");
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumber();
int power = GetPower();
Console.WriteLine($"number {number} in power {power} is {GetPowNumber(number, power)}");