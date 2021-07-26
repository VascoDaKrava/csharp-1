using System;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class FormForInputNumber : Form
    {
        public int InputtedNumber { get; private set; }

        public FormForInputNumber()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
                InputtedNumber = int.Parse(textBox.Text);
        }

        /// <summary>
        /// Ограничение ввода в текстбокс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}