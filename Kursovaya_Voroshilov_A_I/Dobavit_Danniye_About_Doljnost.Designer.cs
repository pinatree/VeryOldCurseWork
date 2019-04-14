namespace Kursovaya_Voroshilov_A_I
{
    partial class Dobavit_Danniye_About_Doljnost
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Family_TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Уровень образования";
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name_TB.Location = new System.Drawing.Point(136, 21);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(289, 20);
            this.Name_TB.TabIndex = 62;
            // 
            // Family_TB
            // 
            this.Family_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Family_TB.Location = new System.Drawing.Point(136, 65);
            this.Family_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Family_TB.Name = "Family_TB";
            this.Family_TB.Size = new System.Drawing.Size(289, 20);
            this.Family_TB.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 64;
            this.button1.Text = "Добавить должность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dobavit_Danniye_About_Doljnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Family_TB);
            this.Name = "Dobavit_Danniye_About_Doljnost";
            this.Text = "Добавить должность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Family_TB;
        private System.Windows.Forms.Button button1;
    }
}