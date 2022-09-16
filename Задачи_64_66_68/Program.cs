Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("64) Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        Console.WriteLine("66) Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("68) Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine("0) Выход.");

        Console.Write("Введите номер задачи: ");
        int taskNumber = Convert.ToInt32(Console.ReadLine());

        switch (taskNumber)
        {
            case 0: return;
            case 64: NaturalNumbers(); break;
            case 66: SumNaturalNumbers(); break;
            case 68: Console.Clear();
                     Console.Write("Введите неотрицательное число M: ");
                     int m = Convert.ToInt32(Console.ReadLine());
                     Console.Write("Введите неотрицательное число N: ");
                     int n = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}"); break;
            default: Console.WriteLine("ERROR"); break;
        }
    }
}

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NaturalNumbers()
{
    Console.Write("Введите начальное натуральное число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное натуральное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m > 0 && n > 0)  // Натуральные числа должны быть больше 0.
    {
        if (n > m)       // Конечное число N должно быть больше начального числа M.
        {
            Console.Write($"Натуральные числа от {m} до {n}: ");
            for (int i = m; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
        }
        else
        {
            Console.Write($"Ошибка! Конечное число N должно быть > начального числа M!");
        }
    }
    else 
    {
        Console.WriteLine("Ошибка! Числа M и N должны быть > 0!");
    }
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SumNaturalNumbers()
{
    Console.Clear();

    Console.Write("Введите начальное натуральное число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное натуральное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    if (m > 0 && n > 0)  // Натуральные числа должны быть больше 0.
    {
        if (n > m)       // Конечное число N должно быть больше начального числа M.
        {
            Console.Write($"Натуральные числа от {m} до {n}: ");
            for (int i = m; i <= n; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
        }
        else
        {
            Console.Write($"Ошибка! Конечное число N должно быть > начального числа M!");
        }
    }
    else 
    {
        Console.WriteLine("Ошибка! Числа M и N должны быть > 0!");
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов = {sum}");
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanFunction (m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanFunction (m - 1, AkkermanFunction (m, n - 1));
    }
    return 0;
}