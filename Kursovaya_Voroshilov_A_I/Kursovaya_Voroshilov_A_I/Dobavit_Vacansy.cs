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
    public partial class Dobavit_Vacansy : Form
    {
        Worker4Admin W4A = null;

        internal Dobavit_Vacansy(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
                if (W4A.SetZapros("INSERT INTO Вакансии (Специальность,Код_предприятия, Можно_до_18,Заявленная_заработная_плата,График) VALUES ('" + textBox1.Text + "'," + textBox4.Text + "," + checkBox2.Checked + "," + textBox2.Text + ",'" + textBox3.Text + "');") != 0)
                {
                    MessageBox.Show("Запись добавлена");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить запись");
                }
        }
    }
}
