using System;
using System.Windows.Forms;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson7
{
    public partial class MainWindow : Form
    {
        // 2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
        //    а человек пытается его угадать за минимальное число попыток.
        //    Компьютер говорит, больше или меньше загаданное число введенного.
        //    a) Для ввода данных от человека используется элемент TextBox;
        //    б) ** Реализовать отдельную форму c TextBox для ввода числа.

        private int hiddenNumber;
        private int inputtedNumber;
        private int countOfTry;

        /// <summary>
        /// Обработчик нажатия кнопки Угадай число
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGameGuess_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            hiddenNumber = r.Next(1, 101);
            countOfTry = 0;
            currentPlace = currentPlaceEnum.GameGuess;
            changeButtonsVisible(mainMenuButtons, false);
            changeButtonsVisible(gameGuessButtons, true);
            changeButtonsEnabled(gameGuessButtons, true);
            labelTop.Text = "Игра \"Угадай число\"\n" +
                "Компьютер загадал число от 1 до 100. Угадайте какое!";
        }

        /// <summary>
        /// Обработчик нажатия кнопки Ввести число
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputNumber_Click(object sender, EventArgs e)
        {

            FormForInputNumber formForInput = new FormForInputNumber();

            formForInput.ShowDialog();
            inputtedNumber = formForInput.InputtedNumber;
            countOfTry++;

            if (inputtedNumber == hiddenNumber)
            {
                labelTop.Text = "Игра \"Угадай число\"\n" +
                    $"Компьютер загадал {inputtedNumber}. Вы угадали!";
                buttonInputNumber.Enabled = false;
            }
            else
                labelTop.Text = "Игра \"Угадай число\"\n" +
                    $"Введённое число {inputtedNumber} {(inputtedNumber > hiddenNumber ? "больше" : "меньше")} загаданного.\n";
            
            labelCenter.Text = $"Попытка : {countOfTry}";
        }
    }
}
