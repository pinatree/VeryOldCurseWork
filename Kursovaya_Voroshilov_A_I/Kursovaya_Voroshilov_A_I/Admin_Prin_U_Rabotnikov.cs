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
    public partial class Admin_Prin_U_Rabotnikov : Form
    {
        Worker4Admin W4A = null;

        internal Admin_Prin_U_Rabotnikov(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;

            try
            {
                GridViewTable.DataSource = W4A.GetFullTableFromZapros("Принятия_и_увольнения_работников");
                TekZapros_TB.Text = "select * from Принятия_и_увольнения_работников;";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int x = 0; x < PokazStolbChB.Items.Count; x++)
            {
                PokazStolbChB.SetItemChecked(x, true);
            }
        }

        private void CreateSostavniyZapros_Click(object sender, EventArgs e)
        {
            string Zapros = "";

            bool NeedSetAnd = false;


            if (!(Zapros_Code_Of_Rabotnick_ChB.Checked || Zapros_Name_ChB.Checked || checkBox1.Checked || Zapros_Razm_ChB.Checked || Zapros_Date_ChB.Checked || Zapros_Code_Of_Tranzaction_ChB.Checked))
            {
                Zapros = "select * from Принятия_и_увольнения_работников;";

                TekZapros_TB.Text = Zapros;

                GridViewTable.DataSource = W4A.GetTableFromZapros(Zapros);
                return;
            }

            Zapros = "select * from Принятия_и_увольнения_работников where ";

            if (Zapros_Code_Of_Tranzaction_ChB.Checked)
            {
                switch (TabPage_Zapros_Tranzact_Perechisleniye.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = Zapros_TextBox_Code_Tranzact_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_записи", "value", Zapros_ChBox_Code_Tranzact_Value.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] Args = new string[2];
                            Args[0] = Zapros_TextBox_Worker_Tranz_VerkhnZnachemiye.Text;
                            Args[1] = Zapros_TextBox_Worker_Tranzact_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_записи", "region", Zapros_CheckBoxBox_Worker_Tranzact_Region.Text, "int", NeedSetAnd, null, Args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Tranzact_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_записи", "perechisleniye", Zapros_CheckBoxBox_Worker_Tranzact_Perechisleniye.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            if (Zapros_Code_Of_Rabotnick_ChB.Checked)
            {
                switch (TabPage_Zapros_Code_Perechisleniye.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = Zapros_TextBox_Worker_Name_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_работника", "value", Zapros_ChBox_Worker_Name_Value.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] Args = new string[2];
                            Args[0] = Zapros_TextBox_Worker_Name_VerkhnZnachemiye.Text;
                            Args[1] = Zapros_TextBox_Worker_Name_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_работника", "region", Zapros_CheckBoxBox_Worker_Name_Region.Text, "int", NeedSetAnd, null, Args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Name_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_работника", "perechisleniye", Zapros_CheckBoxBox_Worker_Name_Perechisleniye.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            if (Zapros_Name_ChB.Checked)
            {
                switch (Zapros_Name_TabControl.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = TextBox_Zapros_Code_Name_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Событие", "value", CheckBox_Zapros_Code_Name_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = TextBox_Zapros_Code_Name_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Событие", "perechisleniye", ComboBox_Zapros_Code_Name_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            if (Zapros_Razm_ChB.Checked)
            {
                switch (Zapros_Zachisl_TabControl.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = TextBox_Zapros_Code_Razm_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_предприятия", "value", CheckBox_Zapros_Code_Razm_Value.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] Args = new string[2];
                            Args[0] = Zapros_TextBox_Worker_Razm_VerkhnZnachemiye.Text;
                            Args[1] = Zapros_TextBox_Worker_Razm_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_предприятия", "region", Zapros_CheckBoxBox_Worker_Razm_Region.Text, "int", NeedSetAnd, null, Args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Razm_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_предприятия", "perechisleniye", Zapros_CheckBoxBox_Worker_Razm_Perechisleniye.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            if (checkBox1.Checked)
            {
                switch (tabControl1.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = textBox1.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_специальности", "value", comboBox1.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] args = new string[2];
                            args[0] = textBox3.Text;
                            args[1] = textBox2.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_специальности", "region", comboBox2.Text, "int", NeedSetAnd, null, args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = richTextBox1.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_специальности", "perechisleniye", comboBox3.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            if (Zapros_Date_ChB.Checked)
            {
                switch (Zapros_CheckBoxBox_Worker_Date.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = TextBox_Zapros_Code_Date_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Дата", "value", CheckBox_Zapros_Code_Date_Value.Text, "date", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] args = new string[2];
                            args[0] = Zapros_TextBox_Worker_Date_VerkhnZnachemiye.Text;
                            args[1] = Zapros_TextBox_Worker_Date_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Дата", "region", Zapros_CheckBoxBox_Worker_Date_Region.Text, "date", NeedSetAnd, null, args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Date_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Дата", "perechisleniye", ComboBox_Zapros_Code_Date_Perechisleniye.Text, "date", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            Zapros = Zapros + ";";

            try
            {
                GridViewTable.DataSource = W4A.GetTableFromZapros(Zapros);

                Reload_Pokaz_Button_Click(null, null);

                TekZapros_TB.Text = Zapros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reload_Pokaz_Button_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection CLB_CIC1 = PokazStolbChB.CheckedIndices;
            for (int x = GridViewTable.Columns.Count; x > 0; x--)
            {
                if (!CLB_CIC1.Contains(x - 1))
                {
                    if (GridViewTable.Columns[x - 1].Visible)
                    {
                        GridViewTable.Columns[x - 1].Visible = false;
                    }
                }
                else
                {
                    if (!GridViewTable.Columns[x - 1].Visible)
                    {
                        GridViewTable.Columns[x - 1].Visible = true;
                    }
                }
            }
        }

        private void Refresh_With_Zapros_Click(object sender, EventArgs e)
        {
            GridViewTable.DataSource = W4A.GetTableFromZapros(TekZapros_TB.Text);

            Reload_Pokaz_Button_Click(null, null);
        }

        private void ShowFullTable_Click(object sender, EventArgs e)
        {
            GridViewTable.DataSource = W4A.GetFullTableFromZapros("Принятия_и_увольнения_работников");

            TekZapros_TB.Text = "select * from Принятия_и_увольнения_работников;";

            Reload_Pokaz_Button_Click(null, null);
        }

        private void GoTo_Btn_Click(object sender, EventArgs e)
        {
            DataRow DT = null;
            try
            {
                DT = W4A.GetTableFromZapros("select * from Принятия_и_увольнения_работников where Код_записи=" + GoTo_TB.Text + ";").Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось найти указанную запись");
                return;
            }

            DataGridViewRow DR = GridViewTable.Rows[GridViewTable.SelectedCells[0].RowIndex];
            Panel_Tranzaction_Code.Text = DT[0].ToString();
            Panel_Code_Of_Rabotnick.Text = DT[1].ToString();
            Panel_Bank.Text = DT[2].ToString();
            Panel_Type.Text = DT[3].ToString();
            Panel_Razm.Text = DT[4].ToString();
            Panel_Date.Text = DT[5].ToString();
        }

        private void ChangesAccept_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("update Резюме set Код_работника =" + Panel_Code_Of_Rabotnick.Text + ",Событие ='" + Panel_Bank.Text + "', Код_предприятия=" + Panel_Type.Text + ",Код_специальности=" + Panel_Razm.Text + ",Дата=#" + Panel_Date.Text.Replace('.', '-') + "# where Код_записи =" + Panel_Tranzaction_Code.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
                if (Panel_Auto_Refresh_CheckBox.Checked)
                {
                    Refresh_With_Zapros_Click(null, null);
                }
            }
        }

        private void Panel_DeleteZapis_Btn_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("delete * from Принятия_и_увольнения_работников where Код_записи=" + Panel_Tranzaction_Code.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
                if (Panel_Auto_Refresh_CheckBox.Checked)
                {
                    Refresh_With_Zapros_Click(null, null);
                }
            }
        }

        private void GridViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow DR = GridViewTable.Rows[GridViewTable.SelectedCells[0].RowIndex];
            Panel_Tranzaction_Code.Text = DR.Cells[0].Value.ToString();
            Panel_Code_Of_Rabotnick.Text = DR.Cells[1].Value.ToString();
            Panel_Bank.Text = DR.Cells[2].Value.ToString();
            Panel_Type.Text = DR.Cells[3].Value.ToString();
            Panel_Razm.Text = DR.Cells[4].Value.ToString();
            Panel_Date.Text = DR.Cells[5].Value.ToString();
        }

        private void Panel_ReadOnly_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Panel_Tranzaction_Code.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Code_Of_Rabotnick.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Bank.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Type.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Razm.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Date.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
        }

        private void Dobavleniye_Dobavit_Button_Click(object sender, EventArgs e)
        {
            W4A.SetZapros("INSERT INTO Принятия_и_увольнения_работников (Код_работника,Событие,Код_предприятия,Код_специальности,Дата) VALUES (" + Dobavleniye_Name_TB.Text + ",'" + Dobavleniye_Family_TB.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "',#" + textBox6.Text.Replace('.', '-') + "#);");
            if (Dobavleniye_Auto_Refresh_ChB.Checked)
            {
                if (Dobavleniye_Lasy_Zapros_ChB.Checked)
                {
                    try
                    {
                        GridViewTable.DataSource = W4A.GetTableFromZapros(TekZapros_TB.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        GridViewTable.DataSource = W4A.GetTableFromZapros("Select * from Принятия_и_увольнения_работников");
                    }
                }
                else
                {
                    GridViewTable.DataSource = W4A.GetTableFromZapros("Select * from Принятия_и_увольнения_работников");
                }
            }

        }
    }
}
