using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            goto Label;
            #region Задание 1. Делегаты.
            // 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double(double, double).
            //    Продемонстрировать работу на функции с функцией a * x ^ 2 и функцией a * sin(x).

            Console.WriteLine("Задание 1. Делегаты.\n");

            #region Исходная часть из методички
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");

            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");

            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");

            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);
            #endregion

            // Демонстрация вывода таблицы с новой функцией
            Console.WriteLine("\nТаблица функции a*x^2");
            Table(delegate (double a, double x) { return a * x * x; }, 2, 0, 3);
            Console.WriteLine("Таблица функции a*sin(x)");
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, 2, 0, 3);

            next();
            #endregion

            #region Задание 2. Минимум функции.
            // 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
            //    а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
            //    Использовать массив (или список) делегатов, в котором хранятся различные функции.
            //    б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
            //    Пусть она возвращает минимум через параметр (с использованием модификатора out). 

            Console.WriteLine("Задание 2. Минимум функции.\n");

            Console.WriteLine("Участок из исходной программы.\n");
            SaveFunc("data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            //Console.ReadKey();
            Console.WriteLine("Конец участка из исходной программы.\n");

            Console.WriteLine("\n\nВыберите функцию : \n" +
                "1 : Функция из методички\n" +
                "2 : x^2\n" +
                "3 : sin(x)\n");

            Fun[] arrOfFunctions = { F, xPov2, sinX };

            int choise = int.Parse(Console.ReadLine());

            Console.WriteLine("\nУкажите границы отрезка : ");
            Console.Write("  начальное значение : ");
            double start = double.Parse(Console.ReadLine());
            Console.Write("  конечное значение : ");
            double stop = double.Parse(Console.ReadLine());
            Console.Write("  шаг : ");
            double step = double.Parse(Console.ReadLine());

            SaveFunc("data.bin", arrOfFunctions[choise - 1], start, stop, step);
            Load("data.bin", out double minValue);
            Console.WriteLine($"\nmin = {minValue:F2}");

            next();
        #endregion

        Label:;
            #region Задание 3. Коллекции и студенты.
            // 3. Переделать программу Пример использования коллекций для решения следующих задач:
            //    а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (* частотный массив);
            //    в) отсортировать список по возрасту студента;
            //    г) * отсортировать список по курсу и возрасту студента;

            Console.WriteLine("Задание 3. Коллекции и студенты.\n");

            int bakalavr = 0;
            int magistr = 0;

            int countCourse5 = 0;
            int countCourse6 = 0;

            // Частотный массив
            Dictionary<int, int> dictionaryForAgeAndCourses = new Dictionary<int, int>
            {
                { 18, 0 },
                { 19, 0 },
                { 20, 0 }
            };

            // Создаем список студентов
            List<Student> list = new List<Student>();

            DateTime dt = DateTime.Now;

            StreamReader sr = new StreamReader("students.csv");

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[6]), int.Parse(s[5]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5) bakalavr++;
                    else
                    {
                        magistr++;
                        if (list[list.Count - 1].course == 5)
                            countCourse5++;
                        else
                            countCourse6++;
                    }
                    if (list[list.Count - 1].age >= 18 && list[list.Count - 1].age <= 20)
                        dictionaryForAgeAndCourses[list[list.Count - 1].age]++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка! ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegat));
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            foreach (var v in list) Console.WriteLine(v.firstName);
            Console.WriteLine(DateTime.Now - dt);
            
            Console.WriteLine($"\nНа 5-ом курсе : {countCourse5}");
            Console.WriteLine($"На 6-ом курсе : {countCourse6}");

            Console.WriteLine("\nЧасотный массив :");
            foreach (KeyValuePair<int, int> item in dictionaryForAgeAndCourses)
            {
                Console.WriteLine($"Возраст {item.Key}, количество студентов - {item.Value}");
            }

            //list.Sort(list.);

            next();
            #endregion

            #region Задание 4. Считывание файла
            // 4. ** Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
            //    Создайте методы, которые возвращают массив byte(FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
            #endregion

        }

        #region Methods for Task 3
        // Создаем метод для сравнения для экземпляров
        static int MyDelegat(Student st1, Student st2)
        {
            return String.Compare(st1.firstName, st2.firstName); // Сравниваем две строки
        }


        #endregion

        #region Methods for Task 2

        #region Из методички
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        #endregion

        #region Изменённые методы

        /// <summary>
        /// sin(x)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double sinX(double x)
        {
            return Math.Sin(x);
        }

        /// <summary>
        /// x ^ 2
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double xPov2(double x)
        {
            return x * x;
        }

        /// <summary>
        /// Перегрузка для принятия функции с одной переменной в виде делегата (сигнатура из Задания 1)
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="F"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="h"></param>
        public static void SaveFunc(string fileName, Fun F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Перегрузка для возвращения массива считанных значений минимального через модификатор
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="min"></param>
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            int arrLength = (int)(fs.Length / sizeof(double));
            double[] result = new double[arrLength];
            double d;
            for (int i = 0; i < arrLength; i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                result[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return result;
        }

        #endregion

        #endregion

        #region Methods for Task 1
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        /// <summary>
        /// Построение таблицы делегата с параметрами a, min, max
        /// </summary>
        /// <param name="F"></param>
        /// <param name="a"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void Table(Fun2 F, double a, double min, double max)
        {
            Console.WriteLine(" ----- X ----- Y -----");
            while (min <= max)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", min, F(a, min));
                min += 1;
            }
            Console.WriteLine(" ---------------------");
        }

        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        #endregion

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

    /// <summary>
    /// Класс для Задания 3
    /// </summary>
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

    #region Delegats



    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double x);

    /// <summary>
    /// Делегат для Задания 1
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public delegate double Fun2(double x, double y);
    #endregion
}
