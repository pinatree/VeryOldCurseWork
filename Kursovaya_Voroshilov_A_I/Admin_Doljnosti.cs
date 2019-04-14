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
    public partial class Admin_Doljnosti : Form
    {
        Worker4Admin W4A = null;

        internal Admin_Doljnosti(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;

            try
            {
                GridViewTable.DataSource = W4A.GetFullTableFromZapros("Специальности");
                TekZapros_TB.Text = "select * from Специальности;";
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


            if (!(Zapros_Code_Of_Rabotnick_ChB.Checked || Zapros_Name_ChB.Checked || Zapros_Family_ChB.Checked))
            {
                Zapros = "select * from Специальности;";

                TekZapros_TB.Text = Zapros;

                GridViewTable.DataSource = W4A.GetTableFromZapros(Zapros);
                return;
            }

            Zapros = "select * from Специальности where ";

            if (Zapros_Code_Of_Rabotnick_ChB.Checked)
            {
                switch (TabPage_Zapros_Code_Perechisleniye.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = Zapros_TextBox_Worker_Name_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_специальности", "value", Zapros_ChBox_Worker_Name_Value.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] Args = new string[2];
                            Args[0] = Zapros_TextBox_Worker_Name_VerkhnZnachemiye.Text;
                            Args[1] = Zapros_TextBox_Worker_Name_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_специальности", "region", Zapros_CheckBoxBox_Worker_Name_Region.Text, "int", NeedSetAnd, null, Args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Name_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_специальности", "perechisleniye", Zapros_CheckBoxBox_Worker_Name_Perechisleniye.Text, "int", NeedSetAnd, Peredat, null);
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
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Название_специальности", "value", CheckBox_Zapros_Code_Name_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = TextBox_Zapros_Code_Name_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Название_специальности", "perechisleniye", ComboBox_Zapros_Code_Name_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            if (Zapros_Family_ChB.Checked)
            {
                switch (Zapros_Family_TabControl.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = TextBox_Zapros_Code_Family_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Уровень_образования", "value", CheckBox_Zapros_Code_Family_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = TextBox_Zapros_Code_Family_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Уровень_образования", "perechisleniye", ComboBox_Zapros_Code_Family_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
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
            GridViewTable.DataSource = W4A.GetFullTableFromZapros("Предприятия");

            TekZapros_TB.Text = "select * from Предприятия;";

            Reload_Pokaz_Button_Click(null, null);
        }

        private void GridViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow DR = GridViewTable.Rows[GridViewTable.SelectedCells[0].RowIndex];
            Panel_Code_Of_Spec.Text = DR.Cells[0].Value.ToString();
            Panel_Name_Of_Spec.Text = DR.Cells[1].Value.ToString();
            Panel_Educate_Level_Spec.Text = DR.Cells[2].Value.ToString();
        }

        private void GoTo_Btn_Click(object sender, EventArgs e)
        {
            DataRow DT = null;
            try
            {
                DT = W4A.GetTableFromZapros("select * from Специальности where Код_специальности=" + GoTo_TB.Text + ";").Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось найти указанную запись");
                return;
            }
                        
            Panel_Code_Of_Spec.Text = DT[0].ToString();
            Panel_Name_Of_Spec.Text = DT[1].ToString();
            Panel_Educate_Level_Spec.Text = DT[2].ToString();
        }

        private void Panel_ReadOnly_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Panel_Name_Of_Spec.ReadOnly = ((CheckBox)sender).Checked;
            Panel_Educate_Level_Spec.ReadOnly = ((CheckBox)sender).Checked;
        }

        private void ChangesAccept_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("update Специальности set Название_специальности ='" + Panel_Name_Of_Spec.Text + "',Уровень_образования ='" + Panel_Educate_Level_Spec.Text + "' where Код_специальности =" + Panel_Code_Of_Spec.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
                if(Panel_Auto_Refresh_CheckBox.Checked)
                {
                    Refresh_With_Zapros_Click(null, null);
                }
            }

        }

        private void Panel_DeleteZapis_Btn_Click(object sender, EventArgs e)
        {
            if (W4A.SetZapros("delete * from Специальности where Код_специальности =" + Panel_Code_Of_Spec.Text + ";") > 0)
            {
                MessageBox.Show("Запись обновлена");
                if (Panel_Auto_Refresh_CheckBox.Checked)
                {
                    Refresh_With_Zapros_Click(null, null);
                }
            }
        }

        private void Dobavleniye_Dobavit_Button_Click(object sender, EventArgs e)
        {
            try
            { 
            W4A.SetZapros("INSERT INTO Специальности (Название_специальности,Уровень_образования) VALUES ('" + Dobavleniye_Name_TB.Text + "','" + Dobavleniye_Family_TB.Text + "');");
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
                            GridViewTable.DataSource = W4A.GetTableFromZapros("Select * from Специальности");
                        }
                    }
                    else
                    {
                        GridViewTable.DataSource = W4A.GetTableFromZapros("Select * from Специальности");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
