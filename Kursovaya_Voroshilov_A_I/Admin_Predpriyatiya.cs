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
    public partial class Admin_Predpriyatiya : Form
    {
        Worker4Admin W4A = null;

        internal Admin_Predpriyatiya(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;

            try
            {
                GridViewTable.DataSource = W4A.GetFullTableFromZapros("Предприятия");
                TekZapros_TB.Text = "select * from Предприятия;";
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


            if (!(Zapros_Code_Of_Rabotnick_ChB.Checked || Zapros_Name_ChB.Checked || Zapros_Family_ChB.Checked || Zapros_Otchestvo_ChB.Checked || Zapros_Date_ChB.Checked))
            {
                Zapros = "select * from Предприятия;";

                TekZapros_TB.Text = Zapros;

                GridViewTable.DataSource = W4A.GetTableFromZapros(Zapros);
                return;
            }

            Zapros = "select * from Предприятия where ";

            if (Zapros_Code_Of_Rabotnick_ChB.Checked)
            {
                switch (TabPage_Zapros_Code_Perechisleniye.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = Zapros_TextBox_Worker_Name_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_предприятия", "value", Zapros_ChBox_Worker_Name_Value.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] Args = new string[2];
                            Args[0] = Zapros_TextBox_Worker_Name_VerkhnZnachemiye.Text;
                            Args[1] = Zapros_TextBox_Worker_Name_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_предприятия", "region", Zapros_CheckBoxBox_Worker_Name_Region.Text, "int", NeedSetAnd, null, Args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Name_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Код_предприятия", "perechisleniye", Zapros_CheckBoxBox_Worker_Name_Perechisleniye.Text, "int", NeedSetAnd, Peredat, null);
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
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Название", "value", CheckBox_Zapros_Code_Name_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = TextBox_Zapros_Code_Name_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Название", "perechisleniye", ComboBox_Zapros_Code_Name_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
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
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Адрес", "value", CheckBox_Zapros_Code_Family_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = TextBox_Zapros_Code_Family_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Адрес", "perechisleniye", ComboBox_Zapros_Code_Family_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                }

                NeedSetAnd = true;
            }

            if (Zapros_Otchestvo_ChB.Checked)
            {
                switch (Zapros_Otchestvo_TabControl.SelectedTab.Text)
                {
                    case ("Значение"):
                        {
                            string[] Peredat = new string[1];
                            Peredat[0] = TextBox_Zapros_Code_Otchestvo_Value.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Телефон", "value", CheckBox_Zapros_Code_Otchestvo_Value.Text, "string", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = TextBox_Zapros_Code_Otchestvo_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Телефон", "perechisleniye", ComboBox_Zapros_Code_Otchstvo_Perechisleniye.Text, "string", NeedSetAnd, Peredat, null);
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
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Количество_работников", "value", CheckBox_Zapros_Code_Date_Value.Text, "int", NeedSetAnd, Peredat, null);
                            break;
                        }
                    case ("Регион"):
                        {
                            string[] args = new string[2];
                            args[0] = Zapros_TextBox_Worker_Date_VerkhnZnachemiye.Text;
                            args[1] = Zapros_TextBox_Worker_Date_NijnZnachemiye.Text;
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Количество_работников", "region", Zapros_CheckBoxBox_Worker_Date_Region.Text, "int", NeedSetAnd, null, args);
                            break;
                        }
                    case ("Перечисление"):
                        {
                            string[] Peredat = Zapros_TextBoxBox_Worker_Date_Perechisleniye.Text.Split(' ');
                            Zapros = Zapros + W4A.ReturnChastZaprosaFromArguments("Количество_работников", "perechisleniye", ComboBox_Zapros_Code_Date_Perechisleniye.Text, "int", NeedSetAnd, Peredat, null);
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

        }

        private void Dobavleniye_Dobavit_Button_Click(object sender, EventArgs e)
        {
            try
            { 
            W4A.SetZapros("INSERT INTO Предприятия (Название, Адрес, Телефон, Количество_работников) VALUES ('" + Dobavleniye_Name_TB.Text + "','" + Dobavleniye_Family_TB.Text + "','" + Dobavleniye_Othcestvo_TB.Text + "'," + Dobavleniye_Pol_TB.Text + ");");
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
                            GridViewTable.DataSource = W4A.GetTableFromZapros("select * from Предприятия");
                        }
                    }
                    else
                    {
                        try
                        {
                            GridViewTable.DataSource = W4A.GetTableFromZapros("Select * from Предприятия");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
