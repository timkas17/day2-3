using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания (от 1 до 9) задания с 1 по 5 являются заадниями по условиям, остальные от 5 до 9 по циклам.");
            int numberWrok = Convert.ToInt32(Console.ReadLine());

            switch (numberWrok)
            {
                case 1:
                    Console.WriteLine("Введите число" + Environment.NewLine);
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number > 0)
                    {
                        Console.WriteLine($"Число положительное, {number + 5}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"Число отрицательное, {number - 5}");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    Console.WriteLine("Введите три числа");

                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int number3 = Convert.ToInt32(Console.ReadLine());

                    if (number1 > number2 && number1 > number3)
                    {
                        Console.WriteLine($"Большее число {number1}");
                        Console.ReadKey();
                    }

                    if (number2 > number1 && number2 > number3)
                    {
                        Console.WriteLine($"Большее число {number2}");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine($"Большее число {number3}");
                        Console.ReadKey();
                    }
                    break;

                case 3:
                    int number1Work3, number2Work3, number3Work3;

                    Console.WriteLine("Введите три числа" + Environment.NewLine);

                    number1Work3 = Convert.ToInt32(Console.ReadLine());
                    number2Work3 = Convert.ToInt32(Console.ReadLine());
                    number3Work3 = Convert.ToInt32(Console.ReadLine());

                    if (number1Work3 > 0 && number2Work3 > 0 && number2Work3 > 0)
                    {
                        Console.WriteLine($"Сумма положительных чисел {number1Work3 + number2Work3 + number3Work3}");
                        Console.ReadKey();
                    }
                    if (number1Work3 > 0 && number2Work3 > 0)
                    {
                        Console.WriteLine($"Сумма положительных чисел {number1Work3 + number2Work3}");
                        Console.ReadKey();
                    }
                    if (number2Work3 > 0 && number3Work3 > 0)
                    {
                        Console.WriteLine($"Сумма положиткельных чисел {number2Work3 + number3Work3}");
                        Console.ReadKey();
                    }
                    if (number1Work3 > 0 && number3Work3 > 0)
                    {
                        Console.WriteLine($"Сумма положительных чисел {number1Work3 + number3Work3}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Положительных чисел нет");
                        Console.ReadKey();
                    }
                    break;

                case 4:
                    Console.WriteLine("Введите число" + Environment.NewLine);
                    int numberWork4 = Convert.ToInt32(Console.ReadLine());
                    numberWork4 = numberWork4 > 10 ? numberWork4 * 2 : numberWork4;

                    Console.WriteLine($"Число: {numberWork4}");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Введите день недил число (от 1 до 7)");
                    int numberWork5 = Convert.ToInt32(Console.ReadLine());

                    switch (numberWork5)
                    {
                        case 1:
                            Console.WriteLine("Сегодня понедельник");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Сегодня вторник");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Сегодня среда");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Сегодня четверг");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("Сегодня пятница");
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.WriteLine("Сегодня суббота");
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.WriteLine("Сегодня воскресенье");
                            Console.ReadKey();
                            break;
                    }
                    break;

                case 6:
                    for (int numberWork6 = 200; true; numberWork6++)
                    {
                        if (numberWork6 > 200 && numberWork6 % 17 == 0)
                        {
                            Console.WriteLine($"Необходимое число {numberWork6}");
                            break;
                        }
                    }

                    Console.ReadKey();
                    break;

                case 7:
                    int days = 1;
                    double distance = 10;
                    double percent = 0.05 * distance;

                    for (; true; distance += percent, days++)
                    {
                        if (distance == 20)
                        {
                            Console.WriteLine($"В {days} день он пробежал 20 км");
                            break;
                        }
                    }

                    Console.ReadKey();
                    break;

                case 8:
                    Console.WriteLine("Введите число");
                    int numberWork8 = Convert.ToInt32(Console.ReadLine());
                    int factorial = 1;

                    for (int count = 2; true; count++)
                    {
                        factorial *= count;

                        if (count == numberWork8)
                        {
                            Console.WriteLine($"Факториал числа {numberWork8} является число {factorial}");
                            break;
                        }
                    }

                    Console.ReadKey();
                    break;

                case 9:
                    Console.WriteLine("Введите число");
                    int numberWork9 = Convert.ToInt32(Console.ReadLine());

                    for (int delitel = 1; true; delitel++)
                    {
                        if (numberWork9 % delitel == 0 && delitel != 1)
                        {
                            Console.WriteLine($"Наименьший делитель числа {numberWork9} является {delitel}");
                            break;
                        }
                    }

                    Console.ReadKey();
                    break;
            }
        }
    }
}
