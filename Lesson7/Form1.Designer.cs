
namespace Lesson7
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridForMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStartGameX2 = new System.Windows.Forms.Button();
            this.buttonStartGameGuess = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.buttonX2 = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelLeftTop = new System.Windows.Forms.Label();
            this.labelLeftBottom = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.GridForMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridForMainWindow
            // 
            this.GridForMainWindow.ColumnCount = 5;
            this.GridForMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GridForMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GridForMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.GridForMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GridForMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GridForMainWindow.Controls.Add(this.labelTop, 1, 0);
            this.GridForMainWindow.Controls.Add(this.labelLeftBottom, 1, 3);
            this.GridForMainWindow.Controls.Add(this.buttonRestart, 3, 4);
            this.GridForMainWindow.Controls.Add(this.buttonUndo, 3, 3);
            this.GridForMainWindow.Controls.Add(this.buttonX2, 3, 2);
            this.GridForMainWindow.Controls.Add(this.buttonAdd1, 3, 1);
            this.GridForMainWindow.Controls.Add(this.buttonExit, 2, 6);
            this.GridForMainWindow.Controls.Add(this.buttonStartGameGuess, 2, 3);
            this.GridForMainWindow.Controls.Add(this.buttonStartGameX2, 2, 1);
            this.GridForMainWindow.Controls.Add(this.buttonBack, 3, 6);
            this.GridForMainWindow.Controls.Add(this.labelLeftTop, 1, 1);
            this.GridForMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridForMainWindow.Location = new System.Drawing.Point(0, 0);
            this.GridForMainWindow.Name = "GridForMainWindow";
            this.GridForMainWindow.RowCount = 8;
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GridForMainWindow.Size = new System.Drawing.Size(800, 450);
            this.GridForMainWindow.TabIndex = 0;
            // 
            // buttonStartGameX2
            // 
            this.buttonStartGameX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartGameX2.Location = new System.Drawing.Point(313, 48);
            this.buttonStartGameX2.Name = "buttonStartGameX2";
            this.buttonStartGameX2.Size = new System.Drawing.Size(174, 24);
            this.buttonStartGameX2.TabIndex = 0;
            this.buttonStartGameX2.Text = "Игра \"Удвоитель\"";
            this.buttonStartGameX2.UseVisualStyleBackColor = true;
            this.buttonStartGameX2.Click += new System.EventHandler(this.buttonStartGameX2_Click);
            // 
            // buttonStartGameGuess
            // 
            this.buttonStartGameGuess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartGameGuess.Location = new System.Drawing.Point(313, 108);
            this.buttonStartGameGuess.Name = "buttonStartGameGuess";
            this.buttonStartGameGuess.Size = new System.Drawing.Size(174, 24);
            this.buttonStartGameGuess.TabIndex = 1;
            this.buttonStartGameGuess.Text = "Игра \"Угадай число\"";
            this.buttonStartGameGuess.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Location = new System.Drawing.Point(313, 378);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(174, 24);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Location = new System.Drawing.Point(493, 378);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(149, 24);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "В Главное меню";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd1.Location = new System.Drawing.Point(493, 48);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(149, 24);
            this.buttonAdd1.TabIndex = 4;
            this.buttonAdd1.Text = "Добавить 1";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            // 
            // buttonX2
            // 
            this.buttonX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonX2.Location = new System.Drawing.Point(493, 78);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(149, 24);
            this.buttonX2.TabIndex = 5;
            this.buttonX2.Text = "Умножить на 2";
            this.buttonX2.UseVisualStyleBackColor = true;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUndo.Location = new System.Drawing.Point(493, 108);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(149, 24);
            this.buttonUndo.TabIndex = 6;
            this.buttonUndo.Text = "Отменить шаг";
            this.buttonUndo.UseVisualStyleBackColor = true;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRestart.Location = new System.Drawing.Point(493, 138);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(149, 24);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "Заново";
            this.buttonRestart.UseVisualStyleBackColor = true;
            // 
            // labelLeftTop
            // 
            this.labelLeftTop.AutoSize = true;
            this.labelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftTop.Location = new System.Drawing.Point(158, 45);
            this.labelLeftTop.Name = "labelLeftTop";
            this.GridForMainWindow.SetRowSpan(this.labelLeftTop, 2);
            this.labelLeftTop.Size = new System.Drawing.Size(149, 60);
            this.labelLeftTop.TabIndex = 8;
            this.labelLeftTop.Text = "labelLeftTop";
            // 
            // labelLeftBottom
            // 
            this.labelLeftBottom.AutoSize = true;
            this.labelLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeftBottom.Location = new System.Drawing.Point(158, 105);
            this.labelLeftBottom.Name = "labelLeftBottom";
            this.GridForMainWindow.SetRowSpan(this.labelLeftBottom, 2);
            this.labelLeftBottom.Size = new System.Drawing.Size(149, 60);
            this.labelLeftBottom.TabIndex = 9;
            this.labelLeftBottom.Text = "labelLeftBottom";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.GridForMainWindow.SetColumnSpan(this.labelTop, 3);
            this.labelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTop.Location = new System.Drawing.Point(158, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(484, 45);
            this.labelTop.TabIndex = 10;
            this.labelTop.Text = "labelTop";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridForMainWindow);
            this.Name = "MainWindow";
            this.Text = "Lesson7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GridForMainWindow.ResumeLayout(false);
            this.GridForMainWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GridForMainWindow;
        private System.Windows.Forms.Button buttonStartGameX2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStartGameGuess;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonX2;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelLeftBottom;
        private System.Windows.Forms.Label labelLeftTop;
    }
}

