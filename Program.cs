/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

System.Console.Write($"Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());

//int count = 1;
string result = string.Empty;

string Recurse(int n)
{
    if (n >= 1) 
    {
        result = $"{n}, " + result;
        return Recurse(n - 1);
    }

    return result;
}

Recurse(n);
System.Console.Write($"N = {n} - > {result}");

/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

System.Console.Write($"Введите значение M: ");
int m = Convert.ToInt16(Console.ReadLine());

System.Console.Write($"Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());

int count = m;

void Recurse(int m, int n)
{
    if (m < n) {
        System.Console.Write($"{count++}, "); 
        Recurse(m, n - 1);
    } else if (m == n) {
        System.Console.Write($"{count++}"); 
    } 
}

System.Console.Write($"M = {m}, N = {n} - > ");

Recurse(m, n);


/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

System.Console.Write($"Введите число: ");
int a = Convert.ToInt16(Console.ReadLine());

int summ = 0;

int Recurse(int a)
{
    if (a > 0) 
    {   
        summ = summ + a % 10;
        Recurse(a / 10);
        return summ;
    }

    return 0;
}

System.Console.Write($"A = {a} - > ");

System.Console.Write($"{Recurse(a)}");


/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

System.Console.Write($"Введите значение A: ");
int a = Convert.ToInt16(Console.ReadLine());

System.Console.Write($"Введите значение B: ");
int b = Convert.ToInt16(Console.ReadLine());

int pow = 1;

int Recurse(int a, int b)
{
    if (b > 0) 
    {
        Recurse(a, b - 1);
        return pow = pow * a;
    }
    return 0;
}

System.Console.Write($"A = {a}, B = {b} - > ");

System.Console.Write($"{Recurse(a, b)}");