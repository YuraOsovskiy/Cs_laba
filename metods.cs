//1
using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Перше число:");
        double operand1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("друге число:");
        double operand2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть операцію:");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = PerformOperation(operand1, operand2, operation);

        Console.WriteLine($"Результат: {result}");
    }

    static double PerformOperation(double operand1, double operand2, char operation)
    {
        double result = 0;

        switch (operation)
        {
            case '+':
                result = operand1 + operand2;
                break;
            case '-':
                result = operand1 - operand2;
                break;
            case '*':
                result = operand1 * operand2;
                break;
            case '/':
                if (operand2 != 0)
                {
                    result = operand1 / operand2;
                }
                else
                {
                    Console.WriteLine("ділення на нуль!");
                }
                break;
            default:
                Console.WriteLine("Помилка");
                break;
        }

        return result;
    }
}

//2

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} є простим числом.");
            }
            else
            {
                Console.WriteLine($"{number} є складним числом.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне введення числа.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false; 
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; 
            }
        }

        return true;
    }
}
//3

class Currency
{
    static void Main()
    {
        Console.Write("Введіть суму для конвертації: ");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            Console.Write("Введіть обмінний курс: ");
            if (double.TryParse(Console.ReadLine(), out double exchangeRate))
            {
                double convertedAmount = ConvertCurrency(amount, exchangeRate);
                Console.WriteLine($"Конвертована сума: {convertedAmount}");
            }
            else
            {
                Console.WriteLine("Некоректний введений обмінний курс.");
            }
        }
        else
        {
            Console.WriteLine("Некоректна введена сума.");
        }
    }

    static double ConvertCurrency(double amount, double exchangeRate)
    {
        return amount * exchangeRate;
    }
}

//4
class Number
{
    static void Main()
    {
        int[] masiv = { 5, 20, 9, 9, 8, 5 };

        FindMinMax(masiv, out int min, out int max);

        Console.WriteLine($"Найменший елемент: {min}");
        Console.WriteLine($"Найбільший елемент: {max}");
    }

    static void FindMinMax(int[] masiv, out int min, out int max)
    {
        if (masiv.Length == 0)
        {
            min = max = 0;
            return;
        }

        min = max = masiv[0];

        foreach (int element in masiv)
        {
            if (element < min)
            {
                min = element;
            }
            else if (element > max)
            {
                max = element;
            }
        }
    }
}


class Figures
{
    static void Main()
    {
        Console.WriteLine("Виберіть фігуру:");
        Console.WriteLine("1. Круг");
        Console.WriteLine("2. Прямокутник");
        Console.WriteLine("3. Куб");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    CircleCalculations();
                    break;
                case 2:
                    RectangleCalculations();
                    break;
                case 3:
                    CubeCalculations();
                    break;
                default:
                    Console.WriteLine("Неправильний вибір.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Некоректний ввід.");
        }
    }

    static void CircleCalculations()
    {
        Console.Write("Введіть радіус круга: ");
        if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площа круга: {area}");
        }
        else
        {
            Console.WriteLine("Некоректний ввід для радіуса.");
        }
    }

    static void RectangleCalculations()
    {
        Console.Write("Введіть довжину прямокутника: ");
        if (double.TryParse(Console.ReadLine(), out double length) && length > 0)
        {
            Console.Write("Введіть ширину прямокутника: ");
            if (double.TryParse(Console.ReadLine(), out double width) && width > 0)
            {
                double area = length * width;
                Console.WriteLine($"Площа прямокутника: {area}");
            }
            else
            {
                Console.WriteLine("Некоректний ввід для ширини.");
            }
        }
        else
        {
            Console.WriteLine("Некоректний ввід для довжини.");
        }
    }

    static void CubeCalculations()
    {
        Console.Write("Введіть довжину ребра куба: ");
        if (double.TryParse(Console.ReadLine(), out double side) && side > 0)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"Об'єм куба: {volume}");
        }
        else
        {
            Console.WriteLine("Некоректний ввід для довжини ребра.");
        }
    }
}



    
