﻿using System;
using System.Diagnostics;
using System.Linq.Expressions;

int UserChoice;
do
{
    Console.WriteLine("Введите желаемый номер:" + "\n" +
        "1. Сложить два числа " + "\n" +
        "2. Вычесть первое из второго " + "\n" +
        "3. Перемножить два числа " + "\n" +
        "4. Разделить первое на второе " + "\n" +
        "5. Возвести в степень N первое число" + "\n" +
        "6. Найти квадратный корень из числа" + "\n" +
        "7. Найти 1 процент от числа" + "\n" +
        "8. Найти факториал из числа" + "\n" +
        "9. Выйти из программы");
    UserChoice = Convert.ToInt32(Console.ReadLine());
    switch (UserChoice)
    {
        case 1:
            Console.WriteLine("Введите 1 число - ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число - ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ - " + (number1 + number2));
            break;
        case 2:
            Console.WriteLine("Введите 1 число - ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число - ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ - " + (number2 - number1));
            break;
        case 3:
            Console.WriteLine("Введите 1 число - ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число - ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ - " + (number1 * number2));
            break;
        case 4:
            Console.WriteLine("Введите 1 число - ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число - ");
            number2 = Convert.ToDouble(Console.ReadLine());
            if (number2 != 0)
            {
                Console.WriteLine("Ответ - " + (number1 / number2));
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!!!");
            }
            break;
        case 5:
            Console.WriteLine("Введите число");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ - " + Math.Pow(number1, number2));
            break;
        case 6:
            Console.WriteLine("Введите число");
            number1 = Convert.ToDouble(Console.ReadLine());
            if (number1 < 0)
            {
                Console.WriteLine("Невозможно найти корень отрицательного числа");
            }
            else
            {
                Console.WriteLine("Ответ - " + Math.Sqrt(number1));
            }
            break;
        case 7:
            Console.WriteLine("Введите число");
            number1 = Convert.ToDouble(Console.ReadLine());
            if (number1 == 0)
            {
                Console.WriteLine("Ответ - 0");
            }
            else
            {
                Console.WriteLine("Ответ - " + number1 / 100);
            }
            break;
        case 8:
            int CountFact = 1;
            Console.WriteLine("Введите число");
            number1 = Convert.ToInt32(Console.ReadLine());
            if ((number1 == 0) & (number1 == 1))
            {
                Console.WriteLine("Ответ - 1");
            }
            else if (number1 < 0)
            {
                Console.WriteLine("Нельзя найти факториал от отрицательного числа");
            }
            else
            {
                for (int i = 1; i <= number1; i++)
                {
                    CountFact = CountFact * i;
                }
                Console.WriteLine("Ответ - " + CountFact);
            }
            break;
        case 9:
            break;
    }
} while (UserChoice != 9);
