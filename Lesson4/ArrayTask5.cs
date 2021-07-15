using System;
using System.IO;
/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson4
{
    /// <summary>
    /// Класс для работы с двумерными массивами
    /// </summary>
    class ArrayTask5
    {
        #region Fields
        private int[,] arr;
        #endregion

        #region Constructors
        public ArrayTask5(int[,] arr)
        {
            this.arr = arr;
        }

        /// <summary>
        /// Конструктор, заполняющий массив случайными числами
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public ArrayTask5(int x, int y, int minA, int maxA)
        {
            arr = new int[x, y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = r.Next(minA, maxA + 1);
                }
            }
        }

        /// <summary>
        /// Конструктор, заполняющий массив из файла path, элементы разделены separator
        /// </summary>
        /// <param name="path"></param>
        /// <param name="separator"></param>
        public ArrayTask5(string path, char separator)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл {path} не найден.");

            StreamReader sr = new StreamReader(path);
            string[] forX = File.ReadAllLines(path);
            sr.Close();

            string[] forY = forX[0].Split(separator);

            arr = new int[forX.Length, forY.Length];

            for (int i = 0; i < forX.Length; i++)
            {
                forY = forX[i].Split(separator);
                for (int j = 0; j < forY.Length; j++)
                {
                    arr[i, j] = int.Parse(forY[j]);
                }
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Поиск минимального значения
        /// </summary>
        public int min
        {
            get
            {
                int res = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < res)
                        {
                            res = arr[i, j];
                        }
                    }
                }
                return res;
            }
        }

        /// <summary>
        /// Поиск максимального значения
        /// </summary>
        public int max
        {
            get
            {
                int res = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > res)
                        {
                            res = arr[i, j];
                        }
                    }
                }
                return res;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Сумма всех элементов
        /// </summary>
        /// <returns></returns>
        public int sum()
        {
            int res = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    res += arr[i, j];
                }
            }
            return res;
        }

        /// <summary>
        /// Сумма всех элементов массива больше заданного
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int sum(int a)
        {
            int res = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > a)
                    {
                        res += arr[i, j];
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// Метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void whereMax(out int x, out int y)
        {
            x = 0;
            y = 0;
            int max = arr[x, y];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод массива в файл
        /// </summary>
        /// <param name="path"></param>
        public void Print(string path)
        {
            if (File.Exists(path))
                throw new IOException($"Такой файл ({path}) уже существует.");
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sw.Write(arr[i, j] + "\t");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
        #endregion
    }
}
