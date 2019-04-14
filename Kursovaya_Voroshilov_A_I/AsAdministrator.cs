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
    public partial class AsAdministrator : Form
    {
        Worker4Admin W4A = null;

        internal AsAdministrator(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void SelectTables_LB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (((ListView)sender).SelectedItems[0].Text)
            {
                case ("Персональные данные работников"):
                    {
                        if(!W4A.AsAdmin)
                        {
                            MessageBox.Show("С таблицами напрямую могут работать только администраторы. Вы можете воспользоваться для этого выделенными вами инструментами.");
                            return;
                        }
                        new Admin_Person_danniye(W4A).Show();
                        break;
                    }
                case ("Предприятия"):
                    {
                        if (!W4A.AsAdmin)
                        {
                            MessageBox.Show("С таблицами напрямую могут работать только администраторы. Вы можете воспользоваться для этого выделенными вами инструментами.");
                            return;
                        }
                        new Admin_Predpriyatiya(W4A).Show();
                        break;
                    }

                case ("Должности"):
                    {
                        if (!W4A.AsAdmin)
                        {
                            MessageBox.Show("С таблицами напрямую могут работать только администраторы. Вы можете воспользоваться для этого выделенными вами инструментами.");
                            return;
                        }
                        new Admin_Doljnosti(W4A).Show();
                        break;
                    }

                case ("Зарплата"):
                    {
                        if (!W4A.AsAdmin)
                        {
                            MessageBox.Show("С таблицами напрямую могут работать только администраторы. Вы можете воспользоваться для этого выделенными вами инструментами.");
                            return;
                        }
                        new Admin_Zachisleniya_Zarplat(W4A).Show();
                        //Code4Aechive
                        break;
                    }
                case ("Трудовая история работников"):
                    {
                        if (!W4A.AsAdmin)
                        {
                            MessageBox.Show("С таблицами напрямую могут работать только администраторы. Вы можете воспользоваться для этого выделенными вами инструментами.");
                            return;
                        }
                        new Admin_Prin_U_Rabotnikov(W4A).Show();
                        //Code4Aechive
                        break;
                    }
                case ("Вакансии"):
                    {
                        if (!W4A.AsAdmin)
                        {
                            MessageBox.Show("С таблицами напрямую могут работать только администраторы. Вы можете воспользоваться для этого выделенными вами инструментами.");
                            return;
                        }
                        new Admin_Vacancyes(W4A).Show();
                        break;
                    }
                case ("Резюме"):
                    {
                        if (!W4A.AsAdmin)
                        {
                            MessageBox.Show("С таблицами напрямую могут работать только администраторы. Вы можете воспользоваться для этого выделенными вами инструментами.");
                            return;
                        }
                        new Admin_Resumes(W4A).Show();
                        break;
                    }
                case ("Найти персональные данные работника"):
                    {
                        new OneRabotnickForm_Admin(W4A).Show();
                        break;
                    }
                case ("Добавить нового сотрудника"):
                    {
                        new Dobavit_Sotrudnika(W4A).Show();
                        break;
                    }
                case ("Показать историю зачислений З/П работника"):
                    {
                        new Pokaz_History_Zachisleniya(W4A).Show();
                        break;
                    }
                case ("Вывести историю принятий на работу и увольнений работника"):
                    {
                        new Pokaz_history_Uvol(W4A).Show();
                        break;
                    }
                case ("Найти данные о должности"):
                    {
                        new Find_Danniye_About_Doljnost(W4A).Show();
                        break;
                    }
                case ("Добавить должность"):
                    {
                        new Dobavit_Danniye_About_Doljnost(W4A).Show();
                        break;
                    }
                case ("Найти запись предприятия"):
                    {
                        new Find_Zapis_Predpriyatiya(W4A).Show();
                        break;
                    }
                case ("Добавить новое предприятие"):
                    {
                        new Dobavit_Zapis_Predpriyatiya(W4A).Show();
                        break;
                    }
                case ("Найти подходящее резюме"):
                    {
                        new Find_Resume(W4A).Show();
                        break;
                    }
                case ("Добавить резюме"):
                    {
                        new Dobavit_Resume(W4A).Show();
                        break;
                    }
                case ("Найти вакансию"):
                    {
                        new Find_Vacansy(W4A).Show();
                        break;
                    }
                case ("Добавить вакансию"):
                    {
                        new Dobavit_Vacansy(W4A).Show();
                        break;
                    }
                case ("Зачисления зарплат"):
                    {
                        new Admin_Zachisleniya_Zarplat(W4A).Show();
                        break;
                    }
            }
        }
    }
}
