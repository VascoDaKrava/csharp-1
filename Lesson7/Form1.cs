using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class MainWindow : Form
    {

        private enum currentPlaceEnum { MainMenu, GameX2, GameGuess };

        private currentPlaceEnum currentPlace;

        private static List<Button> mainMenuButtons = new List<Button>();
        private static List<Button> gameX2Buttons = new List<Button>();
        private static List<Button> gameGuessButtons = new List<Button>();
        private static List<Label> labels = new List<Label>();

        #region Fields for GameX2
        private int requiredNumber;
        private int minStep;
        private int currentStep;
        private int currentValue;
        #endregion

        #region Methods
        /// <summary>
        ///  Включение или отключение списка кнопок
        /// </summary>
        /// <param name="list"></param>
        /// <param name="on"></param>
        private void changeButtonsVisible(List<Button> list, bool on)
        {
            foreach (Button item in list)
            {
                if (on)
                {
                    item.Show();
                }
                else
                {
                    item.Hide();
                }
            }
        }

        /// <summary>
        /// Очистка списка элементов Label
        /// </summary>
        /// <param name="labels"></param>
        private void clearLabels(List<Label> labels)
        {
            foreach (Label item in labels)
            {
                item.Text = "";
            }
        }
        #endregion

        #region Methods for Game X2
        /// <summary>
        /// Обработчик нажатия Добавить 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            currentValue++;
        }

        /// <summary>
        /// Обработчик нажатия *2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик нажатия Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUndo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик нажатия Заново 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestart_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Определение минимального числа ходов
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int minSteps(int a)
        {
            return a - (int)Math.Sqrt(a) * (int)Math.Sqrt(a) + (int)Math.Sqrt(a);
        }
        #endregion


        public MainWindow()
        {
            InitializeComponent();

            labels.Add(labelTop);
            labels.Add(labelLeftTop);
            labels.Add(labelLeftBottom);

            mainMenuButtons.Add(buttonStartGameGuess);
            mainMenuButtons.Add(buttonStartGameX2);
            mainMenuButtons.Add(buttonExit);

            gameX2Buttons.Add(buttonAdd1);
            gameX2Buttons.Add(buttonX2);
            gameX2Buttons.Add(buttonUndo);
            gameX2Buttons.Add(buttonRestart);
            gameX2Buttons.Add(buttonBack);

            currentPlace = currentPlaceEnum.MainMenu;
            changeButtonsVisible(gameX2Buttons, false);
            clearLabels(labels);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик нажатия кнопки Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Игра удвоитель"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGameX2_Click(object sender, EventArgs e)
        {
            // 1.
            //    а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
            //    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
            //       Игрок должен получить это число за минимальное количество ходов.
            //    в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
            //       Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int> Stack.
            //    Вся логика игры должна быть реализована в классе с удвоителем.

            Random r = new Random();
            requiredNumber = r.Next(0, 101);
            minStep = minSteps(requiredNumber);
            currentStep = 0;
            currentValue = 1;
            currentPlace = currentPlaceEnum.GameX2;
            changeButtonsVisible(mainMenuButtons, false);
            changeButtonsVisible(gameX2Buttons, true);
            labelTop.Text = "Игра \"Удвоитель\"\n" +
                "Необходимо получить число за минимальное количество ходов.";
            labelLeftTop.Text = $"Требуется получить {requiredNumber}.\n\n" +
                $"Текущее значение : {currentValue}";
            labelLeftBottom.Text = $"Минимальное число ходов:\n{minStep}\n\n" +
                $"Текущий ход : {currentStep}";
        }

        /// <summary>
        /// Обработчик нажатия кнопки "В Главное меню"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            labelTop.Text = "";
            switch (currentPlace)
            {
                case currentPlaceEnum.GameX2:
                    changeButtonsVisible(gameX2Buttons, false);
                    break;

                case currentPlaceEnum.GameGuess:
                    changeButtonsVisible(gameGuessButtons, false);
                    break;

                default:
                    break;
            }

            clearLabels(labels);
            changeButtonsVisible(mainMenuButtons, true);
        }

    }
}
