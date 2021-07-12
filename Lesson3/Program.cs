using System;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto Label;
            #region Задание 1. О комплексных числах
            // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            //    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //    в) Добавить диалог с использованием switch демонстрирующий работу класса.
            Console.WriteLine("Задание 1. О комплексных числах (КЧ).\n");
            ComplexStruct complexStruct_1;
            ComplexStruct complexStruct_2;
            complexStruct_1.re = 1;
            complexStruct_1.im = 2;
            complexStruct_2.re = 3;
            complexStruct_2.im = 4;
            Console.WriteLine("Демонстрация работы структуры.\n");
            Console.WriteLine($"Первое КЧ : {complexStruct_1}");
            Console.WriteLine($"Второе КЧ : {complexStruct_2}");
            Console.WriteLine($"Их сумма : {complexStruct_1.Plus(complexStruct_2)}");
            Console.WriteLine($"Их разность : {complexStruct_1.Minus(complexStruct_2)}");

            next();

            Complex complex_1 = new Complex(1, 2);
            Complex complex_2 = new Complex(3, 4);
            byte choise = 1;

            while (choise != 9)
            {
                Console.WriteLine("Задание 1. О комплексных числах (КЧ).\n");
                Console.WriteLine("Демонстрация работы класса.\n");
                Console.WriteLine($"Первое КЧ : {complex_1}");
                Console.WriteLine($"Второе КЧ : {complex_2}\n");

                Console.WriteLine("Сделайте свой выбор и нажмите Enter :\n" +
                    "1. Изменить КЧ\n" +
                    "2. Рассчитать сумму КЧ\n" +
                    "3. Рассчитать разность КЧ\n" +
                    "4. Рассчитать произведение КЧ\n" +
                    "9. Завершить демонстрацию\n");

                if (byte.TryParse(Console.ReadLine(), out choise)) ;
                switch (choise)
                {
                    case 1:
                        Console.Write($"Введите дейтвительную часть первого КЧ : ");
                        complex_1.Re = int.Parse(Console.ReadLine());
                        Console.Write($"Введите мнимую часть первого КЧ : ");
                        complex_1.Im = int.Parse(Console.ReadLine());

                        Console.Write($"Введите дейтвительную часть второго КЧ : ");
                        complex_2.Re = int.Parse(Console.ReadLine());
                        Console.Write($"Введите мнимую часть второго КЧ : ");
                        complex_2.Im = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine($"Сумма : {complex_1 + complex_2}");
                        break;

                    case 3:
                        Console.WriteLine($"Разность : {complex_1 - complex_2}");
                        break;

                    case 4:
                        Console.WriteLine($"Произведение : {complex_1 * complex_2}");
                        break;

                    case 9:
                        Console.WriteLine("Завершение демонстрации.");
                        break;

                    default:
                        Console.WriteLine($"Неверный выбор, попробуйте ещё раз.");
                        break;
                }
                next();
            }
            #endregion

            #region Задание 2. tryParse
            // 2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
            //    Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
            Console.WriteLine("Задание 2. tryParse. Сумма всех нечётных положительных чисел.\n");

            string listOfNumbers = ""; // Строка для вывода списка чисел. В задаче требуется лишь вывод, без последующих действий над этими числами.
                                       // Можно использовать коллекции (думаю, наиболее удобно будет) или массивы, но мы их ещё не изучали.
            int a = 1;
            int sum = 0;

            while (a != 0)
            {
                Console.Write("Введите число : ");
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if (isOddPositive(a) > 0)
                    {
                        sum += isOddPositive(a);
                        listOfNumbers += a + "\n";
                    }
                }
                else
                    a = 1;
            }

            Console.WriteLine("\nСписок подходящих чисел : \n\n" +
                listOfNumbers +
                "\n=======\n\n" +
                "Их сумма : " +
                sum);

            next();
        #endregion
        //Label:;

            #region Задание 3. Дроби
            // 3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
            //    Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
            //    * Добавить свойства типа int для доступа к числителю и знаменателю;
            //    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
            //    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException ("Знаменатель не может быть равен 0");
            //    *** Добавить упрощение дробей.

            Fraction fraction_1 = new Fraction(-1, 2);
            Fraction fraction_2 = new Fraction(3, 4);

            choise = 1;

            while (choise != 9)
            {
                Console.WriteLine("Задание 3. Дроби.\n");
                Console.WriteLine($"Первая дробь : {fraction_1}");
                Console.WriteLine($"Вторая дробь : {fraction_2}\n");

                Console.WriteLine("Сделайте свой выбор и нажмите Enter :\n" +
                    "1. Изменить дроби\n" +
                    "2. Рассчитать сумму дробей\n" +
                    "3. Рассчитать разность дробей\n" +
                    "4. Рассчитать произведение дробей\n" +
                    "5. Рассчитать деление дробей\n" +
                    "6. Упростить дробь\n" +
                    "7. Отобразить дроби в десятичном виде\n" +
                    "9. Завершить демонстрацию\n");

                if (byte.TryParse(Console.ReadLine(), out choise)) ;
                switch (choise)
                {
                    case 1:
                        Console.Write($"Введите числитель первой дроби : ");
                        fraction_1.Numerator = int.Parse(Console.ReadLine());
                        Console.Write($"Введите знаменатель первой дроби : ");
                        fraction_1.Denominator = int.Parse(Console.ReadLine());

                        Console.Write($"Введите числитель второй дроби : ");
                        fraction_2.Numerator = int.Parse(Console.ReadLine());
                        Console.Write($"Введите знаменатель второй дроби : ");
                        fraction_2.Denominator = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine($"Сумма : {fraction_1 + fraction_2}");
                        break;

                    case 3:
                        Console.WriteLine($"Разность : {fraction_1 - fraction_2}");
                        break;

                    case 4:
                        Console.WriteLine($"Произведение : {fraction_1 * fraction_2}");
                        break;

                    case 5:
                        Console.WriteLine($"Частное : {fraction_1 / fraction_2}");
                        break;

                    case 6:
                        Console.WriteLine($"Упрощение первой дроби : {fraction_1.Simplification}");
                        Console.WriteLine($"Упрощение второй дроби : {fraction_2.Simplification}");
                        break;

                    case 7:
                        Console.WriteLine($"Первая дробь в десятичном виде : {fraction_1.DecimalFraction}");
                        Console.WriteLine($"Вторая дробь в десятичном виде : {fraction_2.DecimalFraction}");
                        break;

                    case 9:
                        Console.WriteLine("Завершение демонстрации.");
                        break;

                    default:
                        Console.WriteLine($"Неверный выбор, попробуйте ещё раз.");
                        break;
                }
                next();
            }

            #endregion

        }

        /// <summary>
        /// Класс, описывающий десятичные дроби и действия над ними
        /// </summary>
        class Fraction
        {
            #region Методы
            /// <summary>
            /// Сложение дробей
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Fraction operator +(Fraction a, Fraction b)
            {
                return new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
            }

            /// <summary>
            /// Вычитание дробей
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Fraction operator -(Fraction a, Fraction b)
            {
                return new Fraction(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
            }

            /// <summary>
            /// Умножение дробей
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Fraction operator *(Fraction a, Fraction b)
            {
                return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
            }

            /// <summary>
            /// Деление дробей
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static Fraction operator /(Fraction a, Fraction b)
            {
                return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
            }

            public override string ToString()
            {
                if (numerator == 0)
                    return "0";
                else
                {
                    if (numerator * denominator < 0)
                        return $"-{Math.Abs(numerator)}/{Math.Abs(denominator)}";
                    else
                        return $"{Math.Abs(numerator)}/{Math.Abs(denominator)}";
                }
            }
            #endregion

            #region Конструкторы
            public Fraction() { }

            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;

                if (denominator != 0)
                    this.denominator = denominator;
                else
                    throw new ArgumentException("Знаменатель не может быть равен 0");
            }

            #endregion

            #region Поля
            int numerator;
            int denominator;
            #endregion

            #region Свойства
            /// <summary>
            /// Числитель
            /// </summary>
            public int Numerator
            {
                get
                {
                    return numerator;
                }

                set
                {
                    numerator = value;
                }
            }

            /// <summary>
            /// Знаменатель
            /// </summary>
            public int Denominator
            {
                get
                {
                    return denominator;
                }

                set
                {
                    if (value != 0)
                        denominator = value;
                    else
                        throw new ArgumentException("Знаменатель не может быть равен 0");
                }
            }

            /// <summary>
            /// Десятичная дробь
            /// </summary>
            public double DecimalFraction
            {
                get
                {
                    return (double)numerator / denominator;
                }
            }

            /// <summary>
            /// Упрощение дроби
            /// </summary>
            public Fraction Simplification
            {
                get
                {
                    int nod = NOD(numerator, denominator);
                    numerator /= nod;
                    denominator /= nod;
                    return this;
                }
            }
            #endregion

            /// <summary>
            /// Нахождение наибольшего общего делителя двух чисел
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            static int NOD(int a, int b)
            {
                if (b == 0)
                    return a;
                else
                    return NOD(b, a % b);
            }
        }

        /// <summary>
        /// Проверка числа на четность и положительность. Возвращает это число, если оно соответствует условиям, иначе возвращает ноль
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int isOddPositive(int a)
        {
            if (a > 0 && a % 2 == 0)
                return a;
            else
                return 0;
        }

        /// <summary>
        /// Структура, описывающая комплексные числа и действия над ними
        /// </summary>
        struct ComplexStruct
        {
            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            public double re;

            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>
            public double im;

            /// <summary>
            /// Сложение комплексных чисел
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public ComplexStruct Plus(ComplexStruct other)
            {
                ComplexStruct res;

                res.re = re + other.re;
                res.im = im + other.im;

                return res;
            }

            /// <summary>
            /// Вычитание комплексных чисел
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public ComplexStruct Minus(ComplexStruct other)
            {
                ComplexStruct res;

                res.re = re - other.re;
                res.im = im - other.im;

                return res;
            }

            public override string ToString()
            {
                return $"{re} + {im}i";
            }
        }

        /// <summary>
        /// Класс, описываюий комплексные числа и действия над ними
        /// </summary>
        class Complex
        {

            #region Public Methods
            /// <summary>
            /// Сложение комплексных чисел
            /// </summary>
            /// <param name="complex">Комплексное число</param>
            /// <returns>Результат сложения комплексных чисел</returns>
            public Complex Plus(Complex complex)
            {
                Complex c = new Complex();
                c.Re = _re + complex.Re;
                c._im = _im + complex._im;
                return c;
            }

            /// <summary>
            /// Перегрузка оператора +, сложение комплексных чисел
            /// </summary>
            /// <param name="complex1">Комплексное число</param>
            /// <param name="complex2">Комплексное число</param>
            /// <returns>Результат сложения комплексных чисел</returns>
            public static Complex operator +(Complex complex1, Complex complex2)
            {
                return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
            }

            /// <summary>
            /// Вычитание
            /// </summary>
            /// <param name="complex1"></param>
            /// <param name="complex2"></param>
            /// <returns></returns>
            public static Complex operator -(Complex complex1, Complex complex2)
            {
                return new Complex { Re = complex1.Re - complex2.Re, Im = complex1.Im - complex2.Im };
            }

            /// <summary>
            /// Произведение
            /// </summary>
            /// <param name="complex1"></param>
            /// <param name="complex2"></param>
            /// <returns></returns>
            public static Complex operator *(Complex complex1, Complex complex2)
            {
                return new Complex { Re = complex1.Re * complex2.Re - complex1.Im * complex2.Im, Im = complex1.Im * complex2.Re + complex1.Re * complex2.Im };
            }

            public override string ToString()
            {
                string res = "";
                if (_re != 0)
                    res += _re + " ";

                if (_im != 0)
                    if (_im > 0)
                        if (_re == 0)
                            res = $"{_im}i";
                        else
                            res += $"+ {_im}i";
                    else
                        res += $"- {-_im}i";

                return res;
            }
            #endregion

            #region Constructors

            public Complex() { }

            public Complex(double re, double im)
            {
                _re = re;
                this._im = im;
            }

            #endregion

            #region Fields

            private double _re;
            private double _im;

            #endregion

            #region Properties

            public double Re
            {
                get { return _re; }
                set { _re = value; }
            }

            public double Im
            {
                get { return _im; }
                set { _im = value; }
            }

            #endregion
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
    }
}
