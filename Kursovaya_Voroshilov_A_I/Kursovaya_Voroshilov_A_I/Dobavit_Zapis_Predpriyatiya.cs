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
    public partial class Dobavit_Zapis_Predpriyatiya : Form
    {
        Worker4Admin W4A = null;

        internal Dobavit_Zapis_Predpriyatiya(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (W4A.SetZapros("INSERT INTO Предприятия (Название,Адрес,Телефон,Количество_работников) VALUES ('" + Name_TB.Text + "','" + Family_TB.Text + "','" + Otchestvo_TB.Text + "'," + Pol_TB.Text + ");") != 0)
                {
                    MessageBox.Show("Запись добавлена");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить запись");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
