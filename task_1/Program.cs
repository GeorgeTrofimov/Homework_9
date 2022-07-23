// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintEl (int znachenie)
{
        if (znachenie<0)
        {
            System.Console.WriteLine("Введен неверный диапазон");
            return ;
        }
     
        if (znachenie==0)
        {
            return;
        }
        if (znachenie%2!=0)
        {
            znachenie--;
        }
        PrintEl(znachenie-2);
        System.Console.WriteLine($"{znachenie}");
    }
    
int m = Prompt("Введите натуральное число m => ");

int n = Prompt("Введите натуральное число n => ");

int znachenie=n-m;
PrintEl(znachenie);