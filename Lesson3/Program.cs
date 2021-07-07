using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
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
