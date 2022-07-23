// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return akkerman(m - 1, 1);
    }
    else
    {
        return akkerman(m - 1, akkerman(m, n - 1));
    }
}
int m = Prompt(" Введите первое число ");
int n = Prompt(" Введите второе число ");
if (m < 0 || n < 0)
{
    System.Console.WriteLine("Неверные условия ввода");

}
else
{
    int result = akkerman(m, n);
    System.Console.WriteLine($"Функция Аккермана для чисел {m} и {n} равна {result}");
}