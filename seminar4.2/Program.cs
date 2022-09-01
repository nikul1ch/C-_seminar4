Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int SumDigits(int digit)
{
    if (digit == 0) return digit;
    return (digit % 10 + SumDigits(digit / 10));
}


void PrintConsole(int digit)
{
    Console.Write($"Сумма цифр введённого числа = {digit}");
}

PrintConsole(SumDigits(A));