﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Voroshilov_A_I
{
    public partial class Find_Danniye_About_Doljnost : Form
    {
        Worker4Admin W4A = null;

        internal Find_Danniye_About_Doljnost(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;

            DataTable DT = W4A.GetTableFromZapros("select top 1 * from Специальности");
            DataRow DR = null;
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Записей нет");
                this.Close();
            }

            DR = DT.Rows[0];

            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
        }

        private void GoToCode_Btn_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from Специальности where Код_специальности = " + GoToCode_TB.Text);

            if (DT.Rows.Count < 1)
            {
                MessageBox.Show("Запись не найдена");
                return;
            }

            DataRow DR = DT.Rows[0];
            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Code_Of_Rabotnick_TB.ReadOnly = checkBox1.Checked;
            Name_TB.ReadOnly = checkBox1.Checked;
            Family_TB.ReadOnly = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (W4A.SetZapros("update Специальности set Название_специальности ='" + Name_TB.Text + "', Уровень_образования='" + Family_TB.Text + "' where Код_специальности =" + Code_Of_Rabotnick_TB.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("delete * from Специальности where Код_специальности=" + Code_Of_Rabotnick_TB.Text + ";") > 0)
            {
                MessageBox.Show("Запись удалена");
                DataTable DT = W4A.GetTableFromZapros("select top 1 * from Специальности");
                DataRow DR = null;
                if (DT.Rows.Count == 0)
                {
                    MessageBox.Show("Записей больше нет");
                    this.Close();
                }

                DR = DT.Rows[0];

                this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
                this.Name_TB.Text = DR[1].ToString();
                this.Family_TB.Text = DR[2].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from Специальности where Название_специальности = '" + textBox1.Text + "';");

            if (DT.Rows.Count < 1)
            {
                MessageBox.Show("Должность не найдена");
                return;
            }

            DataRow DR = DT.Rows[0];
            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
        }
    }
}
