using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        #region Method1
        public static string Work1(int number)
        {
            if (number > 0)
            {
                return $"Число положительное, {number + 5}";
            }
            else
            {
                return $"Число отрицательное, {number - 5}";
            }
        } 
        #endregion

        #region Method2
        public static string Work2(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                return $"Большее число {number1}";
            }

            if (number2 > number1 && number2 > number3)
            {
                return $"Большее число {number2}";
            }

            else
            {
                return $"Большее число {number3}";
            }
        }
        #endregion

        #region Method3
        public static string Work3(int number1Work3, int number2Work3, int number3Work3)
        {
            if (number1Work3 > 0 && number2Work3 > 0 && number2Work3 > 0)
            {
                return $"Сумма положительных чисел {number1Work3 + number2Work3 + number3Work3}";
            }
            if (number1Work3 > 0 && number2Work3 > 0)
            {
                return $"Сумма положительных чисел {number1Work3 + number2Work3}";
            }
            if (number2Work3 > 0 && number3Work3 > 0)
            {
                return $"Сумма положиткельных чисел {number2Work3 + number3Work3}";
            }
            if (number1Work3 > 0 && number3Work3 > 0)
            {
                return $"Сумма положительных чисел {number1Work3 + number3Work3}";
            }
            else
            {
                return "Положительных чисел нет";
            }
        }
        #endregion

        #region Method4
        public static string Work4(int numberWork4)
        {
            numberWork4 = numberWork4 > 10 ? numberWork4 * 2 : numberWork4;
            return $"Число: {numberWork4}";
        }
        #endregion

        #region Method5
        public static string Work5(int numberWork5)
        {
            switch (numberWork5)
            {
                case 1:
                    return "Сегодня понедельник";
                case 2:
                    return "Сегодня вторник";
                case 3:
                    return "Сегодня среда";
                case 4:
                    return "Сегодня четверг";
                case 5:
                    return "Сегодня пятница";
                case 6:
                    return "Сегодня суббота";
                case 7:
                    return "Сегодня воскресенье";
                default:
                    return "Никакой";
            }
        }
        #endregion

        #region Method6
        public static string Work6()
        {
            for (int numberWork6 = 200; true; numberWork6++)
            {
                if (numberWork6 > 200 && numberWork6 % 17 == 0)
                {
                    return $"Необходимое число {numberWork6}";
                }
            }
        }
        #endregion

        #region Method7
        public static string Work7(int days, double distance, double percent)
        {
            for (; true; distance += percent, days++)
            {
                if (distance == 20)
                {
                    return $"В {days} день он пробежал 20 км";
                }
            }
        } 
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания (от 1 до 9) задания с 1 по 5 являются заадниями по условиям, остальные от 5 до 9 по циклам.");
            int numberWrok = Convert.ToInt32(Console.ReadLine());

            switch (numberWrok)
            {
                case 1:
                    #region Case1
                    Console.WriteLine("Введите число" + Environment.NewLine);
                    int number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Work1(number));
                    Console.ReadKey();
                    break; 
                    #endregion

                case 2:
                    #region Case2
                    Console.WriteLine("Введите три числа");

                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int number3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Work2(number1, number2, number3));
                    Console.ReadKey();

                    break;
                #endregion

                case 3:
                    #region Case3
                    int number1Work3, number2Work3, number3Work3;

                    Console.WriteLine("Введите три числа" + Environment.NewLine);

                    number1Work3 = Convert.ToInt32(Console.ReadLine());
                    number2Work3 = Convert.ToInt32(Console.ReadLine());
                    number3Work3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Work3(number1Work3, number2Work3, number3Work3));
                    Console.ReadKey();
                    break; 
                    #endregion

                case 4:
                    #region Case4
                    Console.WriteLine("Введите число" + Environment.NewLine);
                    int numberWork4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Work4(numberWork4));
                    Console.ReadKey();
                    break; 
                    #endregion

                case 5:
                    #region Case5
                    Console.WriteLine("Введите день недели число (от 1 до 7)");
                    int numberWork5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Work5(numberWork5));
                    Console.ReadKey();
                    break; 
                #endregion

                case 6:
                    #region Case6
                    Console.WriteLine(Work6());

                    Console.ReadKey();
                    break; 
                    #endregion

                case 7:
                    #region Case7
                    int days = 1;
                    double distance = 10;
                    double percent = 0.05 * distance;

                    Console.WriteLine(Work7(days, distance, percent));
                    Console.ReadKey();
                    break; 
                    #endregion

                case 8:
                    #region Case8
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
                #endregion

                case 9:
                    #region Case9
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
                    #endregion
            }
        }
    }
}
