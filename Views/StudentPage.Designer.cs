namespace EF_School_DB_Managment.Views
{
    partial class StudentPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainControl = new System.Windows.Forms.TabControl();
            this.Profile = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.baseInfo = new System.Windows.Forms.Panel();
            this.socialLink = new System.Windows.Forms.TextBox();
            this.parentsPhone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.classTeacher = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.nameSchool = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FirstInfo = new System.Windows.Forms.Panel();
            this.role = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeTablePage = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.timeTable = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainControl.SuspendLayout();
            this.Profile.SuspendLayout();
            this.baseInfo.SuspendLayout();
            this.FirstInfo.SuspendLayout();
            this.TimeTablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.Profile);
            this.MainControl.Controls.Add(this.TimeTablePage);
            this.MainControl.Controls.Add(this.tabPage1);
            this.MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControl.Location = new System.Drawing.Point(0, 0);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(800, 450);
            this.MainControl.TabIndex = 0;
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.LightCoral;
            this.Profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Profile.Controls.Add(this.update);
            this.Profile.Controls.Add(this.label5);
            this.Profile.Controls.Add(this.Save);
            this.Profile.Controls.Add(this.label4);
            this.Profile.Controls.Add(this.baseInfo);
            this.Profile.Controls.Add(this.FirstInfo);
            this.Profile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Profile.Location = new System.Drawing.Point(4, 24);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(3);
            this.Profile.Size = new System.Drawing.Size(792, 422);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Профиль";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkOrange;
            this.update.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(328, 304);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(128, 40);
            this.update.TabIndex = 17;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(412, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дополнительная информация";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Gold;
            this.Save.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(328, 350);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(128, 40);
            this.Save.TabIndex = 16;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Основная информация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseInfo
            // 
            this.baseInfo.BackColor = System.Drawing.Color.LightSalmon;
            this.baseInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.baseInfo.Controls.Add(this.socialLink);
            this.baseInfo.Controls.Add(this.parentsPhone);
            this.baseInfo.Controls.Add(this.label16);
            this.baseInfo.Controls.Add(this.label15);
            this.baseInfo.Controls.Add(this.classTeacher);
            this.baseInfo.Controls.Add(this.label14);
            this.baseInfo.Controls.Add(this.className);
            this.baseInfo.Controls.Add(this.label13);
            this.baseInfo.Controls.Add(this.adress);
            this.baseInfo.Controls.Add(this.nameSchool);
            this.baseInfo.Controls.Add(this.label12);
            this.baseInfo.Controls.Add(this.label11);
            this.baseInfo.Location = new System.Drawing.Point(410, 75);
            this.baseInfo.Name = "baseInfo";
            this.baseInfo.Size = new System.Drawing.Size(360, 223);
            this.baseInfo.TabIndex = 2;
            // 
            // socialLink
            // 
            this.socialLink.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.socialLink.Enabled = false;
            this.socialLink.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.socialLink.Location = new System.Drawing.Point(181, 178);
            this.socialLink.Name = "socialLink";
            this.socialLink.Size = new System.Drawing.Size(172, 22);
            this.socialLink.TabIndex = 28;
            this.socialLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parentsPhone
            // 
            this.parentsPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.parentsPhone.Enabled = false;
            this.parentsPhone.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parentsPhone.Location = new System.Drawing.Point(3, 178);
            this.parentsPhone.Name = "parentsPhone";
            this.parentsPhone.Size = new System.Drawing.Size(172, 22);
            this.parentsPhone.TabIndex = 27;
            this.parentsPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Turquoise;
            this.label16.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(181, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 28);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ссылка на соц. сеть";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Turquoise;
            this.label15.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 28);
            this.label15.TabIndex = 25;
            this.label15.Text = "Телефон родителей";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classTeacher
            // 
            this.classTeacher.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.classTeacher.Enabled = false;
            this.classTeacher.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classTeacher.Location = new System.Drawing.Point(143, 112);
            this.classTeacher.Name = "classTeacher";
            this.classTeacher.Size = new System.Drawing.Size(210, 22);
            this.classTeacher.TabIndex = 24;
            this.classTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Turquoise;
            this.label14.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(143, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 28);
            this.label14.TabIndex = 23;
            this.label14.Text = "Классный руководитель";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // className
            // 
            this.className.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.className.Enabled = false;
            this.className.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.className.Location = new System.Drawing.Point(3, 112);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(134, 22);
            this.className.TabIndex = 22;
            this.className.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Turquoise;
            this.label13.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 28);
            this.label13.TabIndex = 21;
            this.label13.Text = "Класс";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adress
            // 
            this.adress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.adress.Enabled = false;
            this.adress.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adress.Location = new System.Drawing.Point(181, 46);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(172, 22);
            this.adress.TabIndex = 20;
            this.adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameSchool
            // 
            this.nameSchool.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameSchool.Enabled = false;
            this.nameSchool.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameSchool.Location = new System.Drawing.Point(3, 46);
            this.nameSchool.Name = "nameSchool";
            this.nameSchool.Size = new System.Drawing.Size(172, 22);
            this.nameSchool.TabIndex = 19;
            this.nameSchool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Turquoise;
            this.label12.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(181, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Адрес";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Turquoise;
            this.label11.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Школа";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstInfo
            // 
            this.FirstInfo.BackColor = System.Drawing.Color.LightSalmon;
            this.FirstInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstInfo.Controls.Add(this.role);
            this.FirstInfo.Controls.Add(this.label10);
            this.FirstInfo.Controls.Add(this.birthday);
            this.FirstInfo.Controls.Add(this.label9);
            this.FirstInfo.Controls.Add(this.phoneNumber);
            this.FirstInfo.Controls.Add(this.email);
            this.FirstInfo.Controls.Add(this.login);
            this.FirstInfo.Controls.Add(this.label8);
            this.FirstInfo.Controls.Add(this.label7);
            this.FirstInfo.Controls.Add(this.label6);
            this.FirstInfo.Controls.Add(this.patronymic);
            this.FirstInfo.Controls.Add(this.firstName);
            this.FirstInfo.Controls.Add(this.lastName);
            this.FirstInfo.Controls.Add(this.label3);
            this.FirstInfo.Controls.Add(this.label2);
            this.FirstInfo.Controls.Add(this.label1);
            this.FirstInfo.Location = new System.Drawing.Point(18, 75);
            this.FirstInfo.Name = "FirstInfo";
            this.FirstInfo.Size = new System.Drawing.Size(360, 223);
            this.FirstInfo.TabIndex = 1;
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.role.Enabled = false;
            this.role.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.role.Location = new System.Drawing.Point(207, 178);
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Size = new System.Drawing.Size(146, 22);
            this.role.TabIndex = 15;
            this.role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Turquoise;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(207, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Роль";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthday
            // 
            this.birthday.CalendarFont = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.birthday.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.birthday.Enabled = false;
            this.birthday.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.birthday.Location = new System.Drawing.Point(3, 178);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(198, 26);
            this.birthday.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Turquoise;
            this.label9.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Дата рождения";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneNumber.Enabled = false;
            this.phoneNumber.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(245, 112);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(108, 22);
            this.phoneNumber.TabIndex = 11;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(118, 112);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 22);
            this.email.TabIndex = 10;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.login.Enabled = false;
            this.login.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(3, 112);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(109, 22);
            this.login.TabIndex = 9;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Turquoise;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(245, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Телефон";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Turquoise;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(118, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Turquoise;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Логин";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patronymic
            // 
            this.patronymic.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.patronymic.Enabled = false;
            this.patronymic.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patronymic.Location = new System.Drawing.Point(226, 46);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(127, 22);
            this.patronymic.TabIndex = 5;
            this.patronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.firstName.Enabled = false;
            this.firstName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(138, 46);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(82, 22);
            this.firstName.TabIndex = 4;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastName.Enabled = false;
            this.lastName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(3, 46);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(129, 22);
            this.lastName.TabIndex = 3;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Turquoise;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(226, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeTablePage
            // 
            this.TimeTablePage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TimeTablePage.Controls.Add(this.label20);
            this.TimeTablePage.Controls.Add(this.timeTable);
            this.TimeTablePage.Location = new System.Drawing.Point(4, 24);
            this.TimeTablePage.Name = "TimeTablePage";
            this.TimeTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTablePage.Size = new System.Drawing.Size(792, 422);
            this.TimeTablePage.TabIndex = 1;
            this.TimeTablePage.Text = "Расписание";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Yellow;
            this.label20.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(796, 34);
            this.label20.TabIndex = 9;
            this.label20.Text = "Расписание занятий";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTable
            // 
            this.timeTable.AllowUserToDeleteRows = false;
            this.timeTable.AllowUserToResizeColumns = false;
            this.timeTable.AllowUserToResizeRows = false;
            this.timeTable.BackgroundColor = System.Drawing.Color.Moccasin;
            this.timeTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.timeTable.ColumnHeadersHeight = 32;
            this.timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.timeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.BeginTime,
            this.EndTime,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.timeTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.timeTable.EnableHeadersVisualStyles = false;
            this.timeTable.Location = new System.Drawing.Point(3, 37);
            this.timeTable.Name = "timeTable";
            this.timeTable.RowHeadersVisible = false;
            this.timeTable.RowHeadersWidth = 4;
            this.timeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.timeTable.RowTemplate.Height = 27;
            this.timeTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeTable.Size = new System.Drawing.Size(786, 225);
            this.timeTable.TabIndex = 8;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.MaxInputLength = 5;
            this.Number.Name = "Number";
            this.Number.Width = 25;
            // 
            // BeginTime
            // 
            this.BeginTime.HeaderText = "Начало";
            this.BeginTime.MaxInputLength = 100;
            this.BeginTime.Name = "BeginTime";
            this.BeginTime.Width = 55;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "Конец";
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 55;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Понедельник";
            this.Monday.Name = "Monday";
            this.Monday.Width = 108;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Вторник";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Width = 108;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Среда";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Width = 108;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Четверг";
            this.Thursday.Name = "Thursday";
            this.Thursday.Width = 108;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Пятница";
            this.Friday.Name = "Friday";
            this.Friday.Width = 108;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Суббота";
            this.Saturday.Name = "Saturday";
            this.Saturday.Width = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Дневник";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainControl);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "StudentPage";
            this.Text = "StudentPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentPage_FormClosing);
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.MainControl.ResumeLayout(false);
            this.Profile.ResumeLayout(false);
            this.baseInfo.ResumeLayout(false);
            this.baseInfo.PerformLayout();
            this.FirstInfo.ResumeLayout(false);
            this.FirstInfo.PerformLayout();
            this.TimeTablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TabPage TimeTablePage;
        private System.Windows.Forms.Panel baseInfo;
        private System.Windows.Forms.Panel FirstInfo;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox nameSchool;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox classTeacher;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox parentsPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox socialLink;
        private System.Windows.Forms.DataGridView timeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage1;
    }
}