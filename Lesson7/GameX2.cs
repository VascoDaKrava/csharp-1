using System;
using System.Collections.Generic;
using System.Windows.Forms;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson7
{
    public partial class MainWindow : Form
    {
        // 1.
        //    а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        //    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        //       Игрок должен получить это число за минимальное количество ходов.
        //    в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
        //       Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int> Stack.
        //    Вся логика игры должна быть реализована в классе с удвоителем.


        private int requiredNumber;
        private int minStep;
        private Stack<int> steps = new Stack<int>();

        /// <summary>
        /// Обработчик нажатия кнопки "Игра удвоитель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGameX2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            requiredNumber = r.Next(2, 101);
            minStep = minSteps(requiredNumber);
            steps.Clear();
            steps.Push(1);
            currentPlace = currentPlaceEnum.GameX2;
            changeButtonsVisible(mainMenuButtons, false);
            changeButtonsVisible(gameX2Buttons, true);
            changeButtonsEnabled(gameX2Buttons, true);
            labelTop.Text = "Игра \"Удвоитель\"\n" +
                "Необходимо получить число за минимальное количество ходов.";
            drowTextForGameX2();
        }

        /// <summary>
        /// Обработчик нажатия Добавить 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            steps.Push(steps.Peek() + 1);
            drowTextForGameX2();
        }

        /// <summary>
        /// Обработчик нажатия *2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX2_Click(object sender, EventArgs e)
        {
            steps.Push(steps.Peek() * 2);
            drowTextForGameX2();
        }

        /// <summary>
        /// Обработчик нажатия Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (steps.Count > 1)
                steps.Pop();
            drowTextForGameX2();
        }

        /// <summary>
        /// Обработчик нажатия Заново 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            steps.Clear();
            steps.Push(1);
            drowTextForGameX2();
        }

        /// <summary>
        /// Определение минимального числа ходов
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int minSteps(int a)
        {
            int result = 0;
            while (a != 1)
            {
                if (a % 2 == 0)
                {
                    a /= 2;
                    result++;
                }
                else
                {
                    a--;
                    result++;
                }
            }
            return result;
        }

        /// <summary>
        /// Отрисовка текстов и проверка победителя
        /// </summary>
        private void drowTextForGameX2()
        {
            labelLeftTop.Text = $"Требуется получить {requiredNumber}.\n\n" +
                $"Текущее значение : {steps.Peek()}";
            labelLeftBottom.Text = $"Минимальное число ходов:\n{minStep}\n\n" +
                $"Текущий ход : {steps.Count - 1}";
            if (steps.Count > minStep && steps.Peek() != requiredNumber)
            {
                labelTop.Text = "Игра \"Удвоитель\"\n" +
                    "Вы проиграли.";
                stopGameX2();
            }
            if (steps.Peek() == requiredNumber)
            {
                labelTop.Text = "Игра \"Удвоитель\"\n" +
                    "Вы выиграли!";
                stopGameX2();
            }
        }

        private void stopGameX2()
        {
            changeButtonsEnabled(gameX2Buttons, false);
            buttonBack.Enabled = true;
        }
    }
}
