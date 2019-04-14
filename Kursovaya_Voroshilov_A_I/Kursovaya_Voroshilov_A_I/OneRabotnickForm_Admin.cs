using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.OleDb;
using System.IO;

namespace Kursovaya_Voroshilov_A_I
{
    public partial class OneRabotnickForm_Admin : Form
    {
        Worker4Admin W4A = null;

        internal OneRabotnickForm_Admin(string Code, Worker4Admin W4A)
        {
            InitializeComponent();
            this.Code_Of_Rabotnick_TB.Text = Code;

            DataTable DT = W4A.GetTableFromZapros("select * from ПерсДанныеРаботников where Код_работника = " + Code + ";");
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
            this.Date_TB.Text = DR[5].ToString();

            this.W4A = W4A;
        }

        internal OneRabotnickForm_Admin(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void GoToCode_Btn_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from ПерсДанныеРаботников where Код_работника = " + GoToCode_TB.Text);

            if(DT.Rows.Count <1)
            {
                MessageBox.Show("Пользователь с таким кодом отсутствует");
                return;
            }

            DataRow DR = DT.Rows[0];
            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
            this.Date_TB.Text = DR[5].ToString();
        }

        private void Refresh_Content_Btn_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from ПерсДанныеРаботников where Код_работника = " + Code_Of_Rabotnick_TB.Text);

            DataRow DR = DT.Rows[0];
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
            this.Date_TB.Text = DR[5].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Code_Of_Rabotnick_TB.ReadOnly = checkBox1.Checked;
            Name_TB.ReadOnly = checkBox1.Checked;
            Family_TB.ReadOnly = checkBox1.Checked;
            Otchestvo_TB.ReadOnly = checkBox1.Checked;
            Pol_TB.ReadOnly = checkBox1.Checked;
            Date_TB.ReadOnly = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("update ПерсДанныеРаботников set Имя ='" + Name_TB.Text + "', Фамилия='" + Family_TB.Text + "',Отчество='" + Otchestvo_TB.Text + "', Пол ='" + Pol_TB.Text + "',Дата_рождения=#" + Date_TB.Text.Replace('.','-') + "# where Код_работника =" + Code_Of_Rabotnick_TB.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("delete * from ПерсДанныеРаботников where Код_работника=" + Code_Of_Rabotnick_TB.Text + ";") > 0)
            {
                MessageBox.Show("Запись удалена");
                DataTable DT = W4A.GetTableFromZapros("select top 1 * from ПерсДанныеРаботников");
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
                this.Date_TB.Text = DR[5].ToString();
            }
        }
    }
}
