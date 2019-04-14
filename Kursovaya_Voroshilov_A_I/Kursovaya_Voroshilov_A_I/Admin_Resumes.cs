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
    public partial class Admin_Resumes : Form
    {
        Worker4Admin W4A = null;

        internal Admin_Resumes(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;

            try
            {
                GridViewTable.DataSource = W4A.GetFullTableFromZapros("Резюме");
                TekZapros_TB.Text = "select * from Резюме;";
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


            if (!(Zapros_Code_Of_Tranzaction_ChB.Checked || Zapros_Code_Of_Rabotnick_ChB.Checked || Zapros_Razm_ChB.Checked || checkBox1.Checked || Zapros_Name_ChB.Checked))
            {
                Zapros = "select * from Резюме;";

                TekZapros_TB.Text = Zapros;

                GridViewTable.DataSource = W4A.GetTableFromZapros(Zapros);
                return;
            }

            Zapros = "select * from Резюме where ";

            if (Zapros_Code_Of_Tranzaction_ChB.Checked)
            {
                switch (TabPage_Zapros_Tranzact_Perechisleniye.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = Zapros_TextBox_Code_Tranzact_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_резюме", "value", Zapros_ChBox_Code_Tranzact_Value.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] Args = new string[2];
                            Args[0] = Zapros_TextBox_Worker_Tranz_VerkhnZnachemiye.Text;
                            Args[1] = Zapros_TextBox_Worker_Tranzact_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_резюме", "region", Zapros_CheckBoxBox_Worker_Tranzact_Region.Text, "int", NeedSetAnd, null, Args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Tranzact_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_резюме", "perechisleniye", Zapros_CheckBoxBox_Worker_Tranzact_Perechisleniye.Text, "int", NeedSetAnd, Peredat, null);
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

            if (Zapros_Razm_ChB.Checked)
            {
                switch (Zapros_Zachisl_TabControl.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = TextBox_Zapros_Code_Razm_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Образование", "value", CheckBox_Zapros_Code_Razm_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Razm_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Образование", "perechisleniye", Zapros_CheckBoxBox_Worker_Razm_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
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
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Желаемая_з_п", "value", comboBox1.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] Args = new string[2];
                            Args[0] = textBox3.Text;
                            Args[1] = textBox2.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Желаемая_з_п", "region", comboBox2.Text, "int", NeedSetAnd, null, Args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = richTextBox1.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Желаемая_з_п", "perechisleniye", comboBox3.Text, "int", NeedSetAnd, Peredat, null);
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
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("График", "value", CheckBox_Zapros_Code_Name_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = TextBox_Zapros_Code_Name_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("График", "perechisleniye", ComboBox_Zapros_Code_Name_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
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
            GridViewTable.DataSource = W4A.GetFullTableFromZapros("Резюме");

            TekZapros_TB.Text = "select * from Резюме;";

            Reload_Pokaz_Button_Click(null, null);
        }

        private void GridViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow DR = GridViewTable.Rows[GridViewTable.SelectedCells[0].RowIndex];
            Panel_Tranzaction_Code.Text = DR.Cells[0].Value.ToString();
            Panel_Code_Of_Rabotnick.Text = DR.Cells[1].Value.ToString();
            Panel_Bank.Text = DR.Cells[2].Value.ToString();
            Panel_Type.Text = DR.Cells[3].Value.ToString();
            Panel_Razm.Text = DR.Cells[4].Value.ToString();
        }

        private void GoTo_Btn_Click(object sender, EventArgs e)
        {
            DataRow DT = null;
            try
            {
                DT = W4A.GetTableFromZapros("select * from Резюме where Код_резюме=" + GoTo_TB.Text + ";").Rows[0];
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
        }

        private void ChangesAccept_Click(object sender, EventArgs e)
        {
            int x = -1;
            try
            {
                x = W4A.SetZapros("update Резюме set Код_работника =" + Panel_Code_Of_Rabotnick.Text + ",Специальность ='" + Panel_Bank.Text + "', Желаемая_з_п=" + Panel_Type.Text + ",График='" + Panel_Razm.Text + "' where Код_резюме =" + Panel_Tranzaction_Code.Text + ";");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (x > 0)
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
            if (W4A.SetZapros("delete * from Резюме where Код_резюме=" + Panel_Tranzaction_Code.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
                if (Panel_Auto_Refresh_CheckBox.Checked)
                {
                    Refresh_With_Zapros_Click(null, null);
                }
            }
        }

        private void Panel_ReadOnly_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Panel_Tranzaction_Code.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Code_Of_Rabotnick.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Bank.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Type.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
            Panel_Razm.ReadOnly = Panel_ReadOnly_CheckBox.Checked;
        }

        private void Dobavleniye_Dobavit_Button_Click(object sender, EventArgs e)
        {
            W4A.SetZapros("INSERT INTO Резюме (Код_работника,Специальность,Желаемая_з_п,График) VALUES (" + Dobavleniye_Name_TB.Text + ",'" + Dobavleniye_Family_TB.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "');");
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
                        GridViewTable.DataSource = W4A.GetTableFromZapros("Select * from Резюме");
                    }
                }
                else
                {
                    GridViewTable.DataSource = W4A.GetTableFromZapros("Select * from Резюме");
                }
            }
        }

        private void FindSuitableResumes_Click(object sender, EventArgs e)
        {
            string[] specializes = Panel_Bank.Text.Split(' ');
            string vstavSpecializes = "(";
            bool uje_bilo = false;
            foreach (string x in specializes)
            {
                if(uje_bilo)
                {
                    vstavSpecializes = vstavSpecializes + ",'" + x + "'";
                }
                else
                {
                    vstavSpecializes = vstavSpecializes + "'" + x + "'";
                }
            }
            vstavSpecializes = vstavSpecializes + ")";

            string Est_18 = "false";//Вставить проверку на 18-летие, и потом в запрос
            
            DataRow DT = W4A.GetTableFromZapros("select * from ПерсДанныеРаботников where Код_работника=" + Panel_Tranzaction_Code.Text + ";").Rows[0];

            MessageBox.Show("select * from Вакансии where Код_специальности in " + vstavSpecializes + " and Заявленная_заработная_плата >= " + Panel_Type.Text + ";");

            new Admin_Accept_Resumes(W4A, DT[0].ToString(),DT[1].ToString(),DT[2].ToString(),DT[3].ToString(),DT[4].ToString(),DT[5].ToString(), Panel_Type.Text, Panel_Razm.Text, Panel_Bank.Text, W4A.GetTableFromZapros("select * from Вакансии where Специальность in " + vstavSpecializes + " and Заявленная_заработная_плата >= " + Panel_Type.Text + ";")).Show();
        }
    }
}
