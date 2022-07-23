// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Printresult (int n, int m)
{
    if (n>m)
    {
        return 0;
    }
    return Printresult(n+1,m)+n;
}
int n = Prompt("Введите первое число ");
int m = Prompt("Введите второе число ");

if(n>m || n<0 || m<0)
{
    System.Console.WriteLine("Неверные условия ввода");
}
else
{
    int result = Printresult(n-1,m);
    System.Console.WriteLine($"Сумма равна {result}");
}

