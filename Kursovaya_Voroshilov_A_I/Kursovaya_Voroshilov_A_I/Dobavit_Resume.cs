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
    public partial class Dobavit_Resume : Form
    {
        Worker4Admin W4A = null;

        internal Dobavit_Resume(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("INSERT INTO Резюме (Код_работника,Специальность,Желаемая_з_п, График) VALUES (" + textBox4.Text + ",'" + textBox1.Text + "'," + textBox2.Text + ",'" + textBox3.Text + "');") != 0)
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
