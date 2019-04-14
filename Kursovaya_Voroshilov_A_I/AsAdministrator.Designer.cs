namespace Kursovaya_Voroshilov_A_I
{
    partial class AsAdministrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Данные таблиц", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Действия с сотрудником", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Действия с должностями", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Действия с трудовой историей", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Действия с предприятиями", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Действия с вакансиями и резюме", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Должности", 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Зарплата", 3);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Персональные данные работников", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Предприятия", 4);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Трудовая история работников", 5);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Вакансии", 7);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Резюме", 8);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Найти персональные данные работника", 2);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Добавить нового сотрудника", 2);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Показать историю зачислений З/П работника", 2);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Вывести историю принятий на работу и увольнений работника", 2);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Найти данные о должности", 1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Добавить должность", 1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Найти запись предприятия", 4);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Добавить новое предприятие", 4);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Найти подходящее резюме", 8);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Добавить резюме", 8);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Найти вакансию", 7);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Добавить вакансию", 7);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Зачисления зарплат", 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsAdministrator));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTables_LB = new System.Windows.Forms.ListView();
            this.ImagesOfTables = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите интересующую вас таблицу:";
            // 
            // SelectTables_LB
            // 
            listViewGroup1.Header = "Данные таблиц";
            listViewGroup1.Name = "Table_Danniye";
            listViewGroup1.Tag = "";
            listViewGroup2.Header = "Действия с сотрудником";
            listViewGroup2.Name = "Options1";
            listViewGroup3.Header = "Действия с должностями";
            listViewGroup3.Name = "Options2";
            listViewGroup4.Header = "Действия с трудовой историей";
            listViewGroup4.Name = "Options3";
            listViewGroup5.Header = "Действия с предприятиями";
            listViewGroup5.Name = "Options4";
            listViewGroup6.Header = "Действия с вакансиями и резюме";
            listViewGroup6.Name = "Options5";
            this.SelectTables_LB.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup1;
            listViewItem8.Group = listViewGroup2;
            listViewItem9.Group = listViewGroup2;
            listViewItem10.Group = listViewGroup2;
            listViewItem11.Group = listViewGroup2;
            listViewItem12.Group = listViewGroup3;
            listViewItem13.Group = listViewGroup3;
            listViewItem14.Group = listViewGroup5;
            listViewItem15.Group = listViewGroup5;
            listViewItem16.Group = listViewGroup6;
            listViewItem17.Group = listViewGroup6;
            listViewItem18.Group = listViewGroup6;
            listViewItem19.Group = listViewGroup6;
            listViewItem20.Group = listViewGroup4;
            this.SelectTables_LB.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.SelectTables_LB.LargeImageList = this.ImagesOfTables;
            this.SelectTables_LB.Location = new System.Drawing.Point(15, 25);
            this.SelectTables_LB.MultiSelect = false;
            this.SelectTables_LB.Name = "SelectTables_LB";
            this.SelectTables_LB.Size = new System.Drawing.Size(779, 712);
            this.SelectTables_LB.TabIndex = 1;
            this.SelectTables_LB.UseCompatibleStateImageBehavior = false;
            this.SelectTables_LB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectTables_LB_MouseDoubleClick);
            // 
            // ImagesOfTables
            // 
            this.ImagesOfTables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesOfTables.ImageStream")));
            this.ImagesOfTables.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesOfTables.Images.SetKeyName(0, "Archive.png");
            this.ImagesOfTables.Images.SetKeyName(1, "Doljnost.png");
            this.ImagesOfTables.Images.SetKeyName(2, "Lichiye_Danniye.jpg");
            this.ImagesOfTables.Images.SetKeyName(3, "Oplata.png");
            this.ImagesOfTables.Images.SetKeyName(4, "Predpriyatiye.jpg");
            this.ImagesOfTables.Images.SetKeyName(5, "Личность.png");
            this.ImagesOfTables.Images.SetKeyName(6, "dostup.png");
            this.ImagesOfTables.Images.SetKeyName(7, "vacansy.png");
            this.ImagesOfTables.Images.SetKeyName(8, "Rezyume.png");
            // 
            // AsAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 744);
            this.Controls.Add(this.SelectTables_LB);
            this.Controls.Add(this.label1);
            this.Name = "AsAdministrator";
            this.Text = "Выберите таблицу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView SelectTables_LB;
        private System.Windows.Forms.ImageList ImagesOfTables;
    }
}