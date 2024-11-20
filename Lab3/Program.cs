using System;

namespace Lab_2
{
    class Program
    {

        static void Ex1()
        {
            Console.Write("Введите номер дня в году: ");
            if (double.TryParse(Console.ReadLine(), out double numOfDay))
            {
                DateTime date = new DateTime(2015, 1, 1);
                date = date.AddDays(numOfDay - 1);
                Console.WriteLine($"{date:M}");
            }
            else
            {
                Console.WriteLine("Неправильный ввод номерa дня");
            }
        }

        static void Ex2()
        {
            Console.Write("Введите номер дня в году: ");
            if (double.TryParse(Console.ReadLine(), out double numOfDay) && (numOfDay > 0 && numOfDay < 366))
            {
                DateTime date = new DateTime(2015, 1, 1);
                date = date.AddDays(numOfDay - 1);
                Console.WriteLine($"{date:M}");
            }
            else
            {
                Console.WriteLine("Неправильный ввод номерa дня");
            }

        }

        static void Ex3()
        {
            Console.Write("Введите год: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                Console.Write("Введите номер дня в году: ");
                if (double.TryParse(Console.ReadLine(), out double numOfDay) && (numOfDay > 0 && numOfDay < 366))
                {
                    DateTime date = new DateTime(year, 1, 1);
                    date = date.AddDays(numOfDay - 1);
                    Console.WriteLine(DateTime.IsLeapYear(year) ? $"Високосный год, {date:M}" : $"Не високосный год, {date:M}");
                }
                else
                {
                    Console.WriteLine("Неправильный ввод номерa дня");
                }
            }
            else
            {
                Console.WriteLine("Неправильный ввод номерa дня");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1");
            /*Написать программу, которая читает с экрана число от 1 до 365 (номер дня
    в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
    февраля (високосный год не учитывать).*/
            Ex1();

            Console.WriteLine("Упражнение 4.2");
            /*Добавить к задаче из предыдущего упражнения проверку числа введенного
    пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
    исключение, и выдавать на экран сообщение.*/
            Ex2();

            Console.WriteLine("Домашнее задание 4.1");
            /*Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
    учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он
    делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
    год. Однако, если он делится без остатка на 400, это високосный год.)*/
            Ex3();
        }
    }


}