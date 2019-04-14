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
    public partial class Find_Vacansy : Form
    {
        Worker4Admin W4A = null;

        internal Find_Vacansy(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void FindButton_Click_1(object sender, EventArgs e)
        {
            if(!((checkBox1.Checked) || (checkBox3.Checked) || (checkBox4.Checked) || (checkBox5.Checked)))
            {
                dataGridView1.DataSource = W4A.GetTableFromZapros("select * from Вакансии");
                return;
            }

            string Zapros = "select * from Вакансии where ";

            bool NeedAnd = false;

            if(checkBox1.Checked)
            {
                bool first = true;

                string[] Specizlices = textBox1.Text.Split(' ');
                string insert = "(";
                foreach(string x in Specizlices)
                {
                    if(first)
                    {
                        insert = insert + "'" + x + "'";
                        first = false;
                    }
                    else
                    {
                        insert = insert + ",'" + x + "'";
                    }
                    
                }
                insert = insert + ")";

                if (NeedAnd)
                {
                    Zapros = Zapros + " and ";
                }
                else
                {
                    NeedAnd = true;
                }

                Zapros = Zapros + "Специальность in " + insert;
            }

            if(checkBox3.Checked)
            {
                if (NeedAnd)
                {
                    Zapros = Zapros + " and ";
                }
                else
                {
                    NeedAnd = true;
                }

                Zapros = Zapros + "Можно_до_18 = " + checkBox2.Checked;
            }

            if(checkBox4.Checked)
            {
                if (NeedAnd)
                {
                    Zapros = Zapros + " and ";
                }
                else
                {
                    NeedAnd = true;
                }

                Zapros = Zapros + "Заявленная_заработная_плата >= " + textBox2.Text;

            }

            if (checkBox5.Checked)
            {
                bool first = true;

                string[] Specizlices = textBox3.Text.Split(' ');
                string insert = "(";
                foreach (string x in Specizlices)
                {
                    if (first)
                    {
                        insert = insert + "'" + x + "'";
                        first = false;
                    }
                    else
                    {
                        insert = insert + ",'" + x + "'";
                    }

                }
                insert = insert + ")";

                if (NeedAnd)
                {
                    Zapros = Zapros + " and ";
                }
                else
                {
                    NeedAnd = true;
                }

                Zapros = Zapros + "График in" + insert;
            }
            Zapros = Zapros + ";";

            dataGridView1.DataSource = W4A.GetTableFromZapros(Zapros);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).SelectedCells[0].ColumnIndex == 2)
            {
                if (MessageBox.Show(("Открыть страницу предприятия под кодом " + ((DataGridView)sender).SelectedCells[0].Value.ToString()) + "?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new Find_Zapis_Predpriyatiya(W4A, ((DataGridView)sender).SelectedCells[0].Value.ToString()).Show();
                }
            }
        }
    }
}
