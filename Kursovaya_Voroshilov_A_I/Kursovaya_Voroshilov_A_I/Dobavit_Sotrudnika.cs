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
    public partial class Dobavit_Sotrudnika : Form
    {
        Worker4Admin W4A = null;
        internal Dobavit_Sotrudnika(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(W4A.SetZapros("INSERT INTO ПерсДанныеРаботников (Имя,Фамилия,Отчество,Пол,Дата_рождения) VALUES ('" + Name_TB.Text + "','" + Family_TB.Text + "','" + Otchestvo_TB.Text + "','" + Pol_TB.Text + "',#" + Date_TB.Text.Replace('.', '-') + "#);")!= 0)
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
