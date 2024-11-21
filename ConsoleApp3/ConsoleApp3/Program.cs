using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
        static void Task1()
        {
            // Task 1
            Console.WriteLine("Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.В случае отрицательного ответа определить порядковый номер первого числа, которое нарушает данную последовательность. Использовать break.");
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Введите элемент массива под номером {i}");
                num[i] = checkingint();
            }
            for (int j = 1; j < 10; j++)
            {
                if (num[j] < num[j - 1])
                {
                    Console.WriteLine($"Число {num[j]} под номером {j}");
                    break;
                }
                else if (j == 9)
                {
                    Console.WriteLine("Упорядоченное");
                }
            }
        }
        static void Task2()
        {
            // Task 2
            Console.WriteLine("Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям(«шестерка», «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство соответствующей карты.Использовать try-catch-finally.");
            try
            {
                Console.WriteLine("Введите номер карты");
                int k = int.Parse(Console.ReadLine());
                if (6 <= k && k <= 14)
                {
                    switch (k)
                    {
                        case 6:
                            Console.WriteLine("Шестерка");
                            break;
                        case 7:
                            Console.WriteLine("Семерка");
                            break;
                        case 8:
                            Console.WriteLine("Восьмерка");
                            break;
                        case 9:
                            Console.WriteLine("Девятка");
                            break;
                        case 10:
                            Console.WriteLine("Десятка");
                            break;
                        case 11:
                            Console.WriteLine("Валет");
                            break;
                        case 12:
                            Console.WriteLine("Дама");
                            break;
                        case 13:
                            Console.WriteLine("Король");
                            break;
                        case 14:
                            Console.WriteLine("Туз");
                            break;

                        default:
                            Console.WriteLine("Вы ввели неверное число");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное число");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
            finally
            {
                Console.WriteLine("Отработал");
            }
        }
        static void Task3()
        {
            // Task 3
            Console.WriteLine("Напишите программу, которая принимает на входе строку и производит выходные данные");
            Console.WriteLine("Введите данные");
            string line = Console.ReadLine();
            switch (line.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
        static void Task4()
        {
            // Task 4
            Console.WriteLine("Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье). Использовать enum.");
            Console.WriteLine("Введите номер дня недели от 1 до 7");
            int dday = checkingint();
            if (dday > 0 && dday < 8)
            {
                Console.WriteLine($"{dday} день недели - {(Weekdays)dday}");
            }
            else
            {
                Console.WriteLine("Нет такого дня недели");
            }
        }
        static void Task5()
        {
            // Task 5
            Console.WriteLine("Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента Hello Kitty или Barbie doll необходимо положить их в “сумку”, т.е.прибавить к результату.Вывести на экран сколько кукол в “сумке”.");
            Console.WriteLine("Введите длину массива");
            int numerus = int.Parse(Console.ReadLine());
            string[] arraytoys = new string[numerus];
            for (int p = 0; p < numerus; p++)
            {
                Console.WriteLine($"Введите элемент массива под номером {p}");
                arraytoys[p] = Console.ReadLine();
            }
            int bag = 0;
            foreach (string elem in arraytoys)
            {
                if (elem.ToLower() == "hello kitty" || elem.ToLower() == "barbie doll")
                {
                    bag++;
                }
            }
            Console.WriteLine($"{bag} элементов в сумке");
        }
        public enum Weekdays
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
