using System;
using System.Collections.Generic;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson4
{
    /// <summary>
    /// Класс третьего задания о массивах
    /// </summary>
    class ArrayTask3
    {
        #region Fields
        private int[] arrayInt;
        #endregion

        #region Constructors
        public ArrayTask3(int[] arr)
        {
            arrayInt = arr;
        }

        /// <summary>
        /// Конструктор, создающий массив размера length и заполняющий числами от начального значения startNumber с заданным шагом step.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="startNumber"></param>
        /// <param name="step"></param>
        public ArrayTask3(int length, int startNumber, int step)
        {
            arrayInt = new int[length];
            arrayInt[0] = startNumber;

            for (int i = 1; i < length; i++)
            {
                arrayInt[i] = arrayInt[i - 1] + step;
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        public int sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arrayInt.Length; i++)
                {
                    sum += arrayInt[i];
                }
                return sum;
            }
        }

        /// <summary>
        /// Количество максимальных элементов
        /// </summary>
        public int MaxCount
        {
            get
            {
                int[] arraySorted = new int[arrayInt.Length];
                int i = arraySorted.Length - 1;

                Array.Copy(arrayInt, arraySorted, arrayInt.Length);
                Array.Sort(arraySorted);

                while (i > 0 && arraySorted[i] == arraySorted[i - 1])
                {
                    i--;
                }

                return arraySorted.Length - i;
            }
        }

        /// <summary>
        /// Доступ к элементам массива по индексам
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return arrayInt[index];
            }
            set
            {
                arrayInt[index] = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string result = "Element\tValue\n";
            for (int i = 0; i < arrayInt.Length; i++)
            {
                result += $"{i + 1:D2}\t{arrayInt[i]}\n";
            }
            return result;
        }

        /// <summary>
        /// Возвращает новый массив с измененными знаками у всех элементов входного массива
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            int[] arrayInverse = new int[arrayInt.Length];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInverse[i] = -arrayInt[i];
            }
            return arrayInverse;
        }

        /// <summary>
        /// Умножение каждого элемента массива на заданное число
        /// </summary>
        /// <param name="a"></param>
        public void Multi(int a)
        {
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] *= a;
            }
        }

        /// <summary>
        /// Частотный массив
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, int> frequencyDictionary()
        {
            //int count = 1;
            Array.Sort(arrayInt);
            Dictionary<int, int> result = new Dictionary<int, int>();
            result.Add(arrayInt[0], 1);

            for (int i = 1; i < arrayInt.Length; i++)
			{
                if (arrayInt[i] == arrayInt[i-1])
                {
                    result[arrayInt[i]]++;
                }
                else
                {
                    result.Add(arrayInt[i], 1);
                }
			}
            return result;
        }
        #endregion
    }
}
