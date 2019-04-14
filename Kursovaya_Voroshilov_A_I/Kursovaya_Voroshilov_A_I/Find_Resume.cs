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
    public partial class Find_Resume : Form
    {
        Worker4Admin W4A = null;

        internal Find_Resume(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string[] specializes = textBox1.Text.Split(' ');
            string vstavSpecializes = "(";
            bool uje_bilo = false;
            foreach (string x in specializes)
            {
                if (uje_bilo)
                {
                    vstavSpecializes = vstavSpecializes + ",'" + x + "'";
                }
                else
                {
                    vstavSpecializes = vstavSpecializes + "'" + x + "'";
                    uje_bilo = true;
                }
            }
            vstavSpecializes = vstavSpecializes + ")";


            string[] graphic1 = textBox3.Text.Split(' ');
            string graphic2 = "(";
            bool uje_bilo1 = false;
            foreach (string x in graphic1)
            {
                if (uje_bilo1)
                {
                    graphic2 = graphic2 + ",'" + x + "'";
                }
                else
                {
                    graphic2 = graphic2 + "'" + x + "'";
                    uje_bilo1 = true;
                }
            }
            graphic2 = graphic2 + ")";

            DataTable DT = W4A.GetTableFromZapros("select * from Резюме where Специальность in " + vstavSpecializes + " and Желаемая_з_п <= " + textBox2.Text + " and График in " + graphic2 + ";");
            dataGridView1.DataSource = DT;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).SelectedCells[0].ColumnIndex == 1)
            {
                if (MessageBox.Show(("Открыть страницу пользователя под кодом " + ((DataGridView)sender).SelectedCells[0].Value.ToString()) + "?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new OneRabotnickForm_Admin(((DataGridView)sender).SelectedCells[0].Value.ToString(), W4A).Show();
                }
            }
        }
    }
}
