using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            goto Next;

            #region Задание 1
            // 1. Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Задание 1. Минимальное из трёх.\n");
            Console.Write("Введите первое значение : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе значение : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье значение : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nМинимальное значение : {getMin(a, b, c)}");
            next();
        #endregion

            #region Задание 2
            // 2. Написать метод подсчета количества цифр числа.
            Console.WriteLine("Задание 2. Количество цифр в числе.\n");
            Console.Write("Введите число : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр : {quantityDigits(a)}");
            next();
            #endregion

        Next:;
            #region Задание 3
            // 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            #endregion

            #region Задание 4
            // 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //    С помощью цикла do while ограничить ввод пароля тремя попытками.
            #endregion

            #region Задание 5
            // 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            #endregion

            #region Задание 6
            // 6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.
            //    Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            #endregion

            #region Задание 7
            // 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a < b).
            //    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            #endregion

        }


        /// <summary>
        /// Подсчёт количества цифр с использованием рекурсии
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int quantityDigits(int a)
        {
            // Если число не делится на 10, то это одна цифра. Иначе убираем один разряд делением на 10 и вызываем себя рекурсивно
            if (a / 10 == 0)
                return 1;
            else
                return quantityDigits(a / 10) + 1;
        }


        /// <summary>
        /// По нажатию Enter очищает экран
        /// </summary>
        static void next()
        {
            Console.Write("\nДля продолжения нажмите Enter..");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// Поиск минимального из трёх значений
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int getMin(int a, int b, int c)
        {
            int min = a < b ? a : b;
            return min < c ? min : c;
        }
    }
}
