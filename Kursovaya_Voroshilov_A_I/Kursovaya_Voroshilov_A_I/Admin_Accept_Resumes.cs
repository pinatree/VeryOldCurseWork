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
    public partial class Admin_Accept_Resumes : Form
    {
        Worker4Admin W4A = null;

        internal Admin_Accept_Resumes(Worker4Admin W4A, string CodeOfRabotnick, string name, string family,string otchestvo,string Pol,string date,string JelauemayaZP, string graph,string Specializes, DataTable Table)
        {
            InitializeComponent();
            this.W4A = W4A;

            textBox1.Text = name;
            textBox2.Text = family;
            textBox3.Text = otchestvo;
            textBox4.Text = date;
            textBox5.Text = JelauemayaZP;
            textBox6.Text = graph;
            textBox7.Text = Pol;
            textBox8.Text = CodeOfRabotnick;
            richTextBox1.Text = Specializes;
            dataGridView1.DataSource = Table;
        }
    }
}
