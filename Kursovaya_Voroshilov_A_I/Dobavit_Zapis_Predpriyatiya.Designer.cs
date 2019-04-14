namespace Kursovaya_Voroshilov_A_I
{
    partial class Dobavit_Zapis_Predpriyatiya
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pol_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Otchestvo_TB = new System.Windows.Forms.TextBox();
            this.Family_TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "К-во работников";
            // 
            // Pol_TB
            // 
            this.Pol_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pol_TB.Location = new System.Drawing.Point(124, 153);
            this.Pol_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Pol_TB.Name = "Pol_TB";
            this.Pol_TB.Size = new System.Drawing.Size(289, 20);
            this.Pol_TB.TabIndex = 57;
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name_TB.Location = new System.Drawing.Point(124, 21);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(289, 20);
            this.Name_TB.TabIndex = 54;
            // 
            // Otchestvo_TB
            // 
            this.Otchestvo_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Otchestvo_TB.Location = new System.Drawing.Point(124, 109);
            this.Otchestvo_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Otchestvo_TB.Name = "Otchestvo_TB";
            this.Otchestvo_TB.Size = new System.Drawing.Size(289, 20);
            this.Otchestvo_TB.TabIndex = 56;
            // 
            // Family_TB
            // 
            this.Family_TB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Family_TB.Location = new System.Drawing.Point(124, 65);
            this.Family_TB.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.Family_TB.Name = "Family_TB";
            this.Family_TB.Size = new System.Drawing.Size(289, 20);
            this.Family_TB.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 58;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dobavit_Zapis_Predpriyatiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pol_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Otchestvo_TB);
            this.Controls.Add(this.Family_TB);
            this.Name = "Dobavit_Zapis_Predpriyatiya";
            this.Text = "Добавить запись предприятия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pol_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Otchestvo_TB;
        private System.Windows.Forms.TextBox Family_TB;
        private System.Windows.Forms.Button button1;
    }
}