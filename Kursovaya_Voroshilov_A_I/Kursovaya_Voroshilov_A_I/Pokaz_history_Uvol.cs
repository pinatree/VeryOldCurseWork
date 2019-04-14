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
    public partial class Pokaz_history_Uvol : Form
    {
        Worker4Admin W4A = null;

        internal Pokaz_history_Uvol(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;

            DataTable DT = W4A.GetTableFromZapros("select top 1 * from ПерсДанныеРаботников");
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
            this.Date_TB.Text = DR[5].ToString();

            DataTable DT2 = W4A.GetTableFromZapros("select * from Принятия_и_увольнения_работников where Код_работника=" + Code_Of_Rabotnick_TB.Text + ";");
            if (DT2.Rows.Count != 0)
            {
                DGV.DataSource = DT2;
            }
        }

        private void GoToCode_Btn_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from ПерсДанныеРаботников where Код_работника = " + GoToCode_TB.Text);

            if (DT.Rows.Count < 1)
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

            DataTable DT2 = W4A.GetTableFromZapros("select * from Принятия_и_увольнения_работников where Код_работника=" + Code_Of_Rabotnick_TB.Text + ";");
            if (DT2.Rows.Count != 0)
            {
                DGV.DataSource = DT2;
            }
            else
            {
                MessageBox.Show("Пользователь с таким кодом отсутствует");
            }
        }
    }
}
