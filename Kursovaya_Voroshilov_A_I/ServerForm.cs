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
    public partial class ServerForm : Form
    {
        Worker4Admin W4A = null;

        internal ServerForm(Worker4Admin W4A)
        {
            InitializeComponent();
            DataGridView_Connections.Rows.Add("192.168.0.1","1234","DefaultLogin","21.12.21");
            this.W4A = W4A;
        }
    }
}
