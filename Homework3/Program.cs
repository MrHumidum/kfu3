using System;

namespace Lab_2
{
    /// <summary>
    /// Главный класс программы для выполнения различных упражнений.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Перечисление дней недели.
        /// </summary>
        enum DayOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        /// <summary>
        /// Перечисление  достоинств игральных карт.
        /// </summary>
        enum CardsNames
        {
            Шестёрка = 6,
            Семёрка = 7,
            Восьмёрка = 8,
            Девятка = 9,
            Десятка = 10,
            Валет = 11,
            Дама = 12,
            Король = 13,
            Туз = 14
        }

        /// <summary>
        /// Проверяет, является ли последовательность из 10 чисел возрастающей, и выводит номер первого числа, нарушающего последовательность.
        /// </summary>
        static void Ex1()
        {
            bool flag = true;
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 цифр через enter (каждое новое число на новой строке)");

            for (int i = 0; i < 10; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    numbers[i] = num;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Console.WriteLine($"Число под номером {i + 2} нарушает последовательность");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
        }

        /// <summary>
        /// Определяет достоинство игральной карты по её порядковому номеру.
        /// Использует конструкцию try-catch-finally для обработки ошибок ввода.
        /// </summary>
        static void Ex2()
        {
            Console.Write("Введите порядковый номер карты (от 6 до 14): ");
            try
            {
                if (int.TryParse(Console.ReadLine(), out int num) && (num >= 6 && num <= 14))
                {
                    Console.WriteLine($"Достоинство карты: {(CardsNames)num}");
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный ввод");
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }
        }

        /// <summary>
        /// Преобразует входную строку в формат, где каждое слово начинается с заглавной буквы.
        /// Затем выводит сообщение в зависимости от входных данных.
        /// </summary>
        static void Ex3()
        {
            Console.Write("Введите входные данные: ");
            string input = Console.ReadLine();
            input = string.Join(" ", input.ToLower().Split(" ").Select(s => char.ToUpperInvariant(s[0]) + s.Substring(1)));
            switch (input)
            {
                case "Jabroni":
                    Console.WriteLine("Patron Tequilla");
                    break;
                case "School Counselor":
                    Console.WriteLine("Patron Tequilla");
                    break;
                case "Programmer":
                    Console.WriteLine("Hipsters Craft Beer");
                    break;
                case "Bike Gang Member":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "Rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }

        /// <summary>
        /// Определяет название дня недели на основе его порядкового номера.
        /// Использует перечисление DayOfTheWeek.
        /// </summary>
        static void Ex4()
        {
            Console.Write("Введите порядковый номер дня недели: ");
            if (int.TryParse(Console.ReadLine(), out int num) && (num > 0 && num < 8))
            {
                Console.WriteLine((DayOfTheWeek)num);
            }
            else
            {
                Console.WriteLine("Неправильный ввод порядкового номера дня недели");
            }
        }

        /// <summary>
        /// Обходит массив строк, собирая куклы ("Hello Kitty" и "Barbie doll") в "сумку".
        /// Выводит количество кукол и их список.
        /// </summary>
        static void Ex5()
        {
            string[] toys = { "Teddy Bear", "Hello Kitty", "Toy Car", "Barbie doll", "LEGO Set", "Hello Kitty", "Hello Kitty", "Hello Kitty", "Hello Kitty" };

            int dollCount = 0;
            string bag = "";

            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    bag += toy + ", ";
                    dollCount++;
                }
            }
            if (bag.Length > 0)
            {
                bag = bag.Substring(0, bag.Length - 2);
            }
            Console.WriteLine($"В сумке {dollCount} кукол: {bag}");
        }

        /// <summary>
        /// Главный метод программы. Выполняет вызов методов в зависимости от выбранного упражнения.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("№1");
            /*Дана последовательность из 10 чисел. Определить, является ли эта последовательность
упорядоченной по возрастанию. В случае отрицательного ответа определить
порядковый номер первого числа, которое нарушает данную последовательность.
Использовать break.*/
            Ex1();

            Console.WriteLine("№2");
            /*Игральным картам условно присвоены следующие порядковые номера в зависимости от
их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
Порядковые номера остальных карт соответствуют их названиям («шестерка»,
«девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
соответствующей карты. Использовать try-catch-finally.*/
            Ex2();

            Console.WriteLine("№3");
            /*Напишите программу, которая принимает на вход е строку и производит выходные
данные в соответствии со следующей таблицей:
Примечание. По умолчанию используется “все остальное”: если входные данные
функции не соответствуют ни одному из значений в таблице, то возвращаемое значение
должно быть «Beer».
Убедитесь, что вы охватили случаи, когда некоторые слова не отображаются с
правильным написанием заглавных букв. Например, ввод «pOLitiCIaN» должен
по-прежнему возвращать «Your tax dollars».*/
            Ex3();

            Console.WriteLine("№4");
            /*Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
...,7) выводит на экран его название (понедельник, вторник, ..., воскресенье).
Использовать enum.*/
            Ex4();

            Console.WriteLine("№5");
            /*Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
результату. Вывести на экран сколько кукол в “сумке”.*/
            Ex5();


        }
    }


}
