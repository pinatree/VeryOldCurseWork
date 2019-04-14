using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursovaya_Voroshilov_A_I
{
    public partial class Form1 : Form
    {
        Worker4Admin W4A = null;
        public Form1()
        {
            InitializeComponent();
            Local_Rasp_TB.Text = Directory.GetCurrentDirectory() + @"\Copy_of_cursach.mdb";
        }

        private void Udal_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Udal_RB.Checked)
            {
                Password_TB.ReadOnly = true;
            }
            else
            {
                Password_TB.ReadOnly = false;
            }
        }

        private void ChangeDirectory_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                Local_Rasp_TB.Text = OFD.FileName;
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (Local_RB.Checked)
            {
                if(!File.Exists(Local_Rasp_TB.Text))
                {
                    MessageBox.Show("Указанного файла не существует");
                    return;
                }

                try
                {
                    if(Password_TB.Text == "")
                    {
                        W4A = new Worker4Admin(true, Local_Rasp_TB.Text);
                    }
                    else
                    {
                        W4A = new Worker4Admin(true, Local_Rasp_TB.Text, Password_TB.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удается подключиться у указанной базе данных");                    
                    return;
                }

                MessageBox.Show("Вы авторизованы!");

                Form x = new AsAdministrator(W4A);
                x.Show();
            }
            else
            {
                if (!File.Exists(Local_Rasp_TB.Text))
                {
                    MessageBox.Show("Указанного файла не существует");
                    return;
                }

                try
                {
                    W4A = new Worker4Admin(false, Local_Rasp_TB.Text, "qwerty");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удается подключиться у указанной базе данных");
                    return;
                }

                MessageBox.Show("Вы авторизованы!");

                Form x = new AsAdministrator(W4A);
                x.Show();
            }
        }
    }
}
