﻿namespace Kursovaya_Voroshilov_A_I
{
    partial class Pokaz_history_Uvol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV = new System.Windows.Forms.DataGridView();
            this.GoToCode_Btn = new System.Windows.Forms.Button();
            this.GoToCode_TB = new System.Windows.Forms.TextBox();
            this.Code_Of_Rabotnick_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pol_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Otchestvo_TB = new System.Windows.Forms.TextBox();
            this.Family_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(20, 266);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(471, 315);
            this.DGV.TabIndex = 64;
            // 
            // GoToCode_Btn
            // 
            this.GoToCode_Btn.Location = new System.Drawing.Point(497, 266);
            this.GoToCode_Btn.Name = "GoToCode_Btn";
            this.GoToCode_Btn.Size = new System.Drawing.Size(87, 40);
            this.GoToCode_Btn.TabIndex = 63;
            this.GoToCode_Btn.Text = "Перейти к рабочему...";
            this.GoToCode_Btn.UseVisualStyleBackColor = true;
            this.GoToCode_Btn.Click += new System.EventHandler(this.GoToCode_Btn_Click);
            // 
            // GoToCode_TB
            // 
            this.GoToCode_TB.Location = new System.Drawing.Point(590, 277);
            this.GoToCode_TB.Name = "GoToCode_TB";
            this.GoToCode_TB.Size = new System.Drawing.Size(100, 20);
            this.GoToCode_TB.TabIndex = 62;
            // 
            // Code_Of_Rabotnick_TB
            // 
            this.Code_Of_Rabotnick_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Code_Of_Rabotnick_TB.Location = new System.Drawing.Point(109, 11);
            this.Code_Of_Rabotnick_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Code_Of_Rabotnick_TB.Name = "Code_Of_Rabotnick_TB";
            this.Code_Of_Rabotnick_TB.ReadOnly = true;
            this.Code_Of_Rabotnick_TB.Size = new System.Drawing.Size(289, 20);
            this.Code_Of_Rabotnick_TB.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Пол";
            // 
            // Date_TB
            // 
            this.Date_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date_TB.Location = new System.Drawing.Point(109, 231);
            this.Date_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Date_TB.Name = "Date_TB";
            this.Date_TB.ReadOnly = true;
            this.Date_TB.Size = new System.Drawing.Size(289, 20);
            this.Date_TB.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Дата рождения";
            // 
            // Pol_TB
            // 
            this.Pol_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pol_TB.Location = new System.Drawing.Point(109, 187);
            this.Pol_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Pol_TB.Name = "Pol_TB";
            this.Pol_TB.ReadOnly = true;
            this.Pol_TB.Size = new System.Drawing.Size(289, 20);
            this.Pol_TB.TabIndex = 59;
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name_TB.Location = new System.Drawing.Point(109, 55);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.ReadOnly = true;
            this.Name_TB.Size = new System.Drawing.Size(289, 20);
            this.Name_TB.TabIndex = 56;
            // 
            // Otchestvo_TB
            // 
            this.Otchestvo_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Otchestvo_TB.Location = new System.Drawing.Point(109, 143);
            this.Otchestvo_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Otchestvo_TB.Name = "Otchestvo_TB";
            this.Otchestvo_TB.ReadOnly = true;
            this.Otchestvo_TB.Size = new System.Drawing.Size(289, 20);
            this.Otchestvo_TB.TabIndex = 58;
            // 
            // Family_TB
            // 
            this.Family_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Family_TB.Location = new System.Drawing.Point(109, 99);
            this.Family_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Family_TB.Name = "Family_TB";
            this.Family_TB.ReadOnly = true;
            this.Family_TB.Size = new System.Drawing.Size(289, 20);
            this.Family_TB.TabIndex = 57;
            // 
            // Pokaz_history_Uvol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 590);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.GoToCode_Btn);
            this.Controls.Add(this.GoToCode_TB);
            this.Controls.Add(this.Code_Of_Rabotnick_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pol_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Otchestvo_TB);
            this.Controls.Add(this.Family_TB);
            this.Name = "Pokaz_history_Uvol";
            this.Text = "Трудовая история сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button GoToCode_Btn;
        private System.Windows.Forms.TextBox GoToCode_TB;
        private System.Windows.Forms.TextBox Code_Of_Rabotnick_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Date_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pol_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Otchestvo_TB;
        private System.Windows.Forms.TextBox Family_TB;
    }
}