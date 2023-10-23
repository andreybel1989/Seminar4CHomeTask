// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber()
{
    Console.WriteLine("Input number");
    return Convert.ToInt32(Console.ReadLine());

}


int GetSumNumbers(int num)
{
    int result = 0;
        
    for (; num != 0;)
    {
        result += num % 10;
        num /= 10;
    }

    if (result < 0 ) result *= -1;
    return result;
}

Console.WriteLine(GetSumNumbers(InputNumber()));