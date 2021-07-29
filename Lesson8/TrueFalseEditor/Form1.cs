using System;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Form1 : Form
    {

        TrueFalse database = new TrueFalse();

        public Form1()
        {
            InitializeComponent();
            changeActive(false);
        }

        #region Контекстное меню Файл
        /// <summary>
        /// Создание новой базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = saveFileDialog.FileName;
                database.Add("", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        /// <summary>
        /// Открыть файл с базой вопросов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = true;
            openFileDialog.DefaultExt = "xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = openFileDialog.FileName;

                database.Load();
                if (database.Count != 0)
                {
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                    tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                    changeActive(true);
                }
            }
        }

        /// <summary>
        /// Сохранить базу вопросов в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database.FileName = saveFileDialog.FileName;
                database.Save();
            }
        }

        /// <summary>
        /// Показать справку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор - Кравчук Василий", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Завершить работу приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Кнопки и NumericUpDown под окном текста
        /// <summary>
        /// Обработчик изменений элемента NumericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumber.Value == 0)
            {
                tbQuestion.Text = "";
            }
            else
            {
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                if (database[(int)nudNumber.Value - 1].TrueFalse)
                {
                    rbYes.Checked = true;
                }
                else
                {
                    rbNo.Checked = true;
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            changeActive(true);
            tbQuestion.Text = "";
            database.Add(tbQuestion.Text, rbYes.Checked);
            nudNumber.Minimum = 1;
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        /// <summary>
        /// Обработчик нажатия кнопки Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database.Count <= 1)
                changeActive(false);

            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
        }

        /// <summary>
        /// Обработчик нажатия кнопки Save changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            if (rbYes.Checked)
            {
                database[(int)nudNumber.Value - 1].TrueFalse = true;
            }
            else
            {
                database[(int)nudNumber.Value - 1].TrueFalse = false;
            }
        }
        #endregion

        /// <summary>
        /// Активирование/деактивирование критических компонентов
        /// </summary>
        /// <param name="isOn"></param>
        private void changeActive(bool isOn)
        {
            menuItemSave.Enabled = isOn;

            btnDelete.Enabled = isOn;
            btnSave.Enabled = isOn;

            nudNumber.Enabled = isOn;

            tbQuestion.Enabled = isOn;

            rbNo.Enabled = isOn;
            rbYes.Enabled = isOn;
        }
    }
}
