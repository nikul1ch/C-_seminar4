Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int temp = 0;  //Хотел сделать инициализацию внутри метода, но он постоянно обнуляется при рекурсии, как это можно обойти?

int SumDigits(int digit)
{
    if (digit < 10) return temp += digit;
    else
    {
        temp += digit % 10;
        SumDigits(digit / 10);
    }
    return temp;
}

void PrintConsole(int digit)
{
    Console.Write($"Сумма цифр введённого числа = {digit}");
}

PrintConsole(SumDigits(A));