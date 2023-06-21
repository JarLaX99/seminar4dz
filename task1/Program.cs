// Напишите цикл,который принимает на вход 
//два числа A и B и возводит A в натуральную степень B

int Readint(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Pow(int num, int numberN)
{
    int sum = num;

    for (int i = 1; i < numberN; i++)
    {
        sum = sum * num;
    }
    return sum;
}

int numberA = Readint("Введите первое число: ");
int numberB = Readint("Введите второе число: ");

int result = Pow(numberA, numberB);
System.Console.WriteLine($"{numberA}^{numberB} = {result}");