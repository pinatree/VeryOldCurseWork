namespace Kursovaya_Voroshilov_A_I
{
    partial class ServerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridView_Connections = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ServerStatisticGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Connections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerStatisticGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(48, 153);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(218, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Использовать NAT (пробросить порт)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(48, 176);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(122, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Использовать SSL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 96);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(243, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Использовать все доступные интерфейсы";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Запустить сервер";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DataGridView_Connections
            // 
            this.DataGridView_Connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Connections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.Port,
            this.Login,
            this.Time});
            this.DataGridView_Connections.Location = new System.Drawing.Point(957, 249);
            this.DataGridView_Connections.Name = "DataGridView_Connections";
            this.DataGridView_Connections.Size = new System.Drawing.Size(445, 276);
            this.DataGridView_Connections.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1230, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Список соединений";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Остановить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ServerStatisticGraphic
            // 
            chartArea2.Name = "ChartArea1";
            this.ServerStatisticGraphic.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 5;
            legend2.Name = "Legend1";
            this.ServerStatisticGraphic.Legends.Add(legend2);
            this.ServerStatisticGraphic.Location = new System.Drawing.Point(757, 12);
            this.ServerStatisticGraphic.Name = "ServerStatisticGraphic";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Legend1";
            series3.Name = "Трафик";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Кол-во соединений";
            this.ServerStatisticGraphic.Series.Add(series3);
            this.ServerStatisticGraphic.Series.Add(series4);
            this.ServerStatisticGraphic.Size = new System.Drawing.Size(646, 218);
            this.ServerStatisticGraphic.TabIndex = 23;
            this.ServerStatisticGraphic.Text = "chart1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(860, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Общее количество";
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 537);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ServerStatisticGraphic);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DataGridView_Connections);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button1);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Connections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerStatisticGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGridView_Connections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ServerStatisticGraphic;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}