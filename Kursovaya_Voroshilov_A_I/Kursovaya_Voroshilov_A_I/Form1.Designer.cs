namespace Kursovaya_Voroshilov_A_I
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Local_Rasp_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Local_RB = new System.Windows.Forms.RadioButton();
            this.Udal_RB = new System.Windows.Forms.RadioButton();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChangeDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здраствуйте! Вас приветствует курсовая работа Ворошилова А.И. Под какой учетной з" +
    "аписью вы хотели бы войти?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Данное ПО обеспечивает доступ к базе данных, реализованной в БД Microsoft Access";
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(348, 100);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(200, 20);
            this.Password_TB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // Local_Rasp_TB
            // 
            this.Local_Rasp_TB.Location = new System.Drawing.Point(182, 55);
            this.Local_Rasp_TB.Name = "Local_Rasp_TB";
            this.Local_Rasp_TB.Size = new System.Drawing.Size(200, 20);
            this.Local_Rasp_TB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Расположение файла базы данных";
            // 
            // Local_RB
            // 
            this.Local_RB.AutoSize = true;
            this.Local_RB.Checked = true;
            this.Local_RB.Location = new System.Drawing.Point(378, 126);
            this.Local_RB.Name = "Local_RB";
            this.Local_RB.Size = new System.Drawing.Size(157, 17);
            this.Local_RB.TabIndex = 17;
            this.Local_RB.TabStop = true;
            this.Local_RB.Text = "Войти как администратор";
            this.Local_RB.UseVisualStyleBackColor = true;
            // 
            // Udal_RB
            // 
            this.Udal_RB.AutoSize = true;
            this.Udal_RB.Location = new System.Drawing.Point(56, 101);
            this.Udal_RB.Name = "Udal_RB";
            this.Udal_RB.Size = new System.Drawing.Size(150, 17);
            this.Udal_RB.TabIndex = 18;
            this.Udal_RB.Text = "Войти как пользователь";
            this.Udal_RB.UseVisualStyleBackColor = true;
            this.Udal_RB.CheckedChanged += new System.EventHandler(this.Udal_RB_CheckedChanged);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(232, 143);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(150, 50);
            this.GoButton.TabIndex = 19;
            this.GoButton.Text = "Войти";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChangeDirectory
            // 
            this.ChangeDirectory.Location = new System.Drawing.Point(388, 53);
            this.ChangeDirectory.Name = "ChangeDirectory";
            this.ChangeDirectory.Size = new System.Drawing.Size(75, 23);
            this.ChangeDirectory.TabIndex = 20;
            this.ChangeDirectory.Text = "Изменить";
            this.ChangeDirectory.UseVisualStyleBackColor = true;
            this.ChangeDirectory.Click += new System.EventHandler(this.ChangeDirectory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(629, 240);
            this.Controls.Add(this.ChangeDirectory);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.Udal_RB);
            this.Controls.Add(this.Local_RB);
            this.Controls.Add(this.Local_Rasp_TB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Local_Rasp_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Local_RB;
        private System.Windows.Forms.RadioButton Udal_RB;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button ChangeDirectory;
    }
}

