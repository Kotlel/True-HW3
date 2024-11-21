using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static int checkingint()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("Неверный ввод!\nПовторите: ");
            return x;
        }
        static void Task4_1()
        {
            // 4.1
            Console.WriteLine("Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9 февраля(високосный год не учитывать).");
            int day = 0;
            Console.WriteLine("Введите число от 1 до 365");
            day = checkingint();
            DateTime date = new DateTime(1, 1, 1);
            Console.WriteLine($"{day} соответствует: {date.AddDays(day - 1).ToString("dd MMMM")}");
        }
        static void Task4_2()
        {
            // 4.2
            Console.WriteLine("Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать исключение, и выдавать на экран сообщение.");
            int dayexc = 0;
            while (true)
            {
                Console.WriteLine("Введите число от 1 до 365");
                dayexc = checkingint();
                if (dayexc <= 365 && dayexc > 0) break;
                else Console.WriteLine("Ошибка");
            }

            DateTime dateexc = new DateTime(1, 1, 1);
            Console.WriteLine($"{dayexc} соответствует: {dateexc.AddDays(dayexc - 1).ToString("dd MMMM")}");
        }
        static void Htask4_1()
        {
            // 4.1
            Console.WriteLine("Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год(високосный или нет).Год вводится с экрана. (Год високосный, если он делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный год.Однако, если он делится без остатка на 400, это високосный год.)");
            int year = 0;
            Console.WriteLine("Введите год");
            year = checkingint();
            if ((year % 4 == 0 && (year % 100 != 0)) || (year % 400 == 0))
            {
                int dayleap = 0;
                while (true)
                {
                    Console.WriteLine("Введите число от 1 до 366");
                    dayleap = checkingint();
                    if (dayleap <= 366 && dayleap > 0) break;
                    else Console.WriteLine("Ошибка");
                }

                DateTime dateleap = new DateTime(year, 1, 1);
                Console.WriteLine($"{dayleap} соответствует: {dateleap.AddDays(dayleap - 1).ToString("dd MMMM yyyy")}");
            }
            else
            {
                int daynotleap = 0;
                while (true)
                {
                    Console.WriteLine("Введите число от 1 до 365");
                    daynotleap = checkingint();
                    if (daynotleap <= 365 && daynotleap > 0) break;
                    else Console.WriteLine("Ошибка");
                }

                DateTime datenotleap = new DateTime(year, 1, 1);
                Console.WriteLine($"{daynotleap} соответствует: {datenotleap.AddDays(daynotleap - 1).ToString("dd MMMM yyyy")}");
            }
        }
        static void Main(string[] args)
        {
            Task4_1();
            Task4_2();
            Htask4_1();
        }
    }
}
