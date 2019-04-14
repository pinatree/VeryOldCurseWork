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
    public partial class OnePredpritatiyeForm_Admin : Form
    {
        Worker4Admin W4A = null;

        internal OnePredpritatiyeForm_Admin(string code, string nazv, string address, string telephone, string colvo, DataTable RabotnikyPredpriyatiya, Worker4Admin W4A)
        {
            InitializeComponent();

            this.W4A = W4A;

            this.Code_Of_Rabotnick_TB.Text = code;
            this.Name_TB.Text = nazv;
            this.Family_TB.Text = address;
            this.Otchestvo_TB.Text = telephone;
            this.Pol_TB.Text = colvo;

            this.DGV_Prin_Uvol_History.DataSource = RabotnikyPredpriyatiya;
        }

        private void GoToCode_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
