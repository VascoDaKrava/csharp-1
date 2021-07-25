using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class MainWindow : Form
    {
        delegate void buttonState();

        private enum currentPlaceEnum { MainMenu, GameX2, GameGuess };

        private currentPlaceEnum currentPlace;

        private static List<Button> mainMenuButtons = new List<Button>();
        private static List<Button> gameX2Buttons = new List<Button>();
        private static List<Button> gameGuessButtons = new List<Button>();
        private static List<Label> labels = new List<Label>();
        
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

        #region Methods
        /// <summary>
        ///  Включение или отключение видимости списка кнопок
        /// </summary>
        /// <param name="list">Список кнопок</param>
        /// <param name="on">Показать/скрыть</param>
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
        /// Включение и отключение списка кнопок
        /// </summary>
        /// <param name="list"></param>
        /// <param name="state"></param>
        private void changeButtonsEnabled(List<Button> list, bool state)
        {
            foreach (Button item in list)
            {
                    item.Enabled = state;
            }
        }

        //private void changeButtonsVisible(List<Button> list, Control control)
        //{
        //    foreach (Button item in list)
        //    {
        //        if (control == )
        //    }
        //}

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
