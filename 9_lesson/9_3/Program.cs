// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int sum_nums (int sum)
{
    if (sum == 0) return 0;
    return sum_nums (sum / 10) + sum % 10;
}

Console.WriteLine(sum_nums(928));