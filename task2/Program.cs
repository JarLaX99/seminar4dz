// Напишите програму,которая принемает на вход число
// и выдает сумму цифр в числе 

// математический способ

int Readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int sum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int number = Readint("Введите число: ");
int result = sum(number);
System.Console.WriteLine($"сумма цифр числа {number} = {result}");