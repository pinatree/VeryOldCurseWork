using System;
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
    public partial class Find_Zapis_Predpriyatiya : Form
    {
        Worker4Admin W4A = null;

        internal Find_Zapis_Predpriyatiya(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;

            DataTable DT = W4A.GetTableFromZapros("select top 1 * from Предприятия");
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
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
        }
        internal Find_Zapis_Predpriyatiya(Worker4Admin W4A, string code)
        {
            InitializeComponent();
            this.W4A = W4A;

            DataTable DT = W4A.GetTableFromZapros("select * from Предприятия where Код_предприятия = " + code + ";");
            DataRow DR = null;
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Запись отсутствует");
                this.Close();
            }

            DR = DT.Rows[0];

            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
        }

        private void GoToCode_Btn_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from Предприятия where Код_предприятия = " + GoToCode_TB.Text + ";");

            if (DT.Rows.Count < 1)
            {
                MessageBox.Show("Запись не найдена");
                return;
            }

            DataRow DR = DT.Rows[0];
            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from Предприятия where Название = '" + textBox1.Text + "';");

            if (DT.Rows.Count < 1)
            {
                MessageBox.Show("Запись не найдена");
                return;
            }

            DataRow DR = DT.Rows[0];
            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("update Предприятия set Название='" + Name_TB.Text + "', Адрес='" + Family_TB.Text + "',Телефон='" + Otchestvo_TB.Text + "',Количество_работников = '" + Pol_TB.Text + "' where Код_предприятия =" + Code_Of_Rabotnick_TB.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("delete * from Предприятия where Код_предприятия=" + Code_Of_Rabotnick_TB.Text + ";") > 0)
            {
                MessageBox.Show("Запись удалена");
                DataTable DT = W4A.GetTableFromZapros("select top 1 * from Предприятия");
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
                this.Otchestvo_TB.Text = DR[3].ToString();
                this.Pol_TB.Text = DR[4].ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Code_Of_Rabotnick_TB.ReadOnly = checkBox1.Checked;
            this.Name_TB.ReadOnly = checkBox1.Checked;
            this.Family_TB.ReadOnly = checkBox1.Checked;
            this.Otchestvo_TB.ReadOnly = checkBox1.Checked;
            this.Pol_TB.ReadOnly = checkBox1.Checked;
        }
    }
}
