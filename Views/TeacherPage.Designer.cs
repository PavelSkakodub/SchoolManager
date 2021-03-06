namespace EF_School_DB_Managment.Views
{
    partial class TeacherPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TimeTablePage = new System.Windows.Forms.TabPage();
            this.OpenTimeTable = new System.Windows.Forms.Button();
            this.timeTableClass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateLesson = new System.Windows.Forms.Button();
            this.homework = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.classLesson = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dateLesson = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.classRate = new System.Windows.Forms.TextBox();
            this.AddRateClass = new System.Windows.Forms.Button();
            this.AddRateStudent = new System.Windows.Forms.Button();
            this.emailStudent = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dateWork = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
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
            this.Profile = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.baseInfo = new System.Windows.Forms.Panel();
            this.adress = new System.Windows.Forms.TextBox();
            this.schoolName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.classTeacher = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cabinet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.hoursPerWeek = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
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
            this.MainControl = new System.Windows.Forms.TabControl();
            this.TimeTablePage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
            this.Profile.SuspendLayout();
            this.baseInfo.SuspendLayout();
            this.FirstInfo.SuspendLayout();
            this.MainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeTablePage
            // 
            this.TimeTablePage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TimeTablePage.Controls.Add(this.OpenTimeTable);
            this.TimeTablePage.Controls.Add(this.timeTableClass);
            this.TimeTablePage.Controls.Add(this.panel1);
            this.TimeTablePage.Controls.Add(this.label21);
            this.TimeTablePage.Controls.Add(this.label20);
            this.TimeTablePage.Controls.Add(this.timeTable);
            this.TimeTablePage.Location = new System.Drawing.Point(4, 24);
            this.TimeTablePage.Name = "TimeTablePage";
            this.TimeTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTablePage.Size = new System.Drawing.Size(792, 422);
            this.TimeTablePage.TabIndex = 2;
            this.TimeTablePage.Text = "Расписание и уроки";
            // 
            // OpenTimeTable
            // 
            this.OpenTimeTable.BackColor = System.Drawing.Color.GreenYellow;
            this.OpenTimeTable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenTimeTable.Location = new System.Drawing.Point(663, 6);
            this.OpenTimeTable.Name = "OpenTimeTable";
            this.OpenTimeTable.Size = new System.Drawing.Size(110, 27);
            this.OpenTimeTable.TabIndex = 16;
            this.OpenTimeTable.Text = "Загрузить";
            this.OpenTimeTable.UseVisualStyleBackColor = false;
            this.OpenTimeTable.Click += new System.EventHandler(this.OpenTimeTable_Click);
            // 
            // timeTableClass
            // 
            this.timeTableClass.Location = new System.Drawing.Point(547, 8);
            this.timeTableClass.Name = "timeTableClass";
            this.timeTableClass.PlaceholderText = "Название класса";
            this.timeTableClass.Size = new System.Drawing.Size(110, 23);
            this.timeTableClass.TabIndex = 15;
            this.timeTableClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.CreateLesson);
            this.panel1.Controls.Add(this.homework);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.classLesson);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.dateLesson);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.comment);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.classRate);
            this.panel1.Controls.Add(this.AddRateClass);
            this.panel1.Controls.Add(this.AddRateStudent);
            this.panel1.Controls.Add(this.emailStudent);
            this.panel1.Controls.Add(this.rate);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.dateWork);
            this.panel1.Location = new System.Drawing.Point(3, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 122);
            this.panel1.TabIndex = 13;
            // 
            // CreateLesson
            // 
            this.CreateLesson.BackColor = System.Drawing.Color.GreenYellow;
            this.CreateLesson.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateLesson.Location = new System.Drawing.Point(5, 92);
            this.CreateLesson.Name = "CreateLesson";
            this.CreateLesson.Size = new System.Drawing.Size(376, 27);
            this.CreateLesson.TabIndex = 31;
            this.CreateLesson.Text = "Добавить урок";
            this.CreateLesson.UseVisualStyleBackColor = false;
            this.CreateLesson.Click += new System.EventHandler(this.CreateLesson_Click);
            // 
            // homework
            // 
            this.homework.Location = new System.Drawing.Point(208, 66);
            this.homework.Name = "homework";
            this.homework.PlaceholderText = "ДЗ для всего класса";
            this.homework.Size = new System.Drawing.Size(173, 23);
            this.homework.TabIndex = 30;
            this.homework.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Khaki;
            this.label29.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(208, 37);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(173, 23);
            this.label29.TabIndex = 29;
            this.label29.Text = "Домашнее задание";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classLesson
            // 
            this.classLesson.Location = new System.Drawing.Point(127, 66);
            this.classLesson.Name = "classLesson";
            this.classLesson.PlaceholderText = "Класс";
            this.classLesson.Size = new System.Drawing.Size(75, 23);
            this.classLesson.TabIndex = 28;
            this.classLesson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Khaki;
            this.label28.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(127, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 23);
            this.label28.TabIndex = 27;
            this.label28.Text = "Класс";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Khaki;
            this.label27.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(5, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 23);
            this.label27.TabIndex = 26;
            this.label27.Text = "Дата урока";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLesson
            // 
            this.dateLesson.Location = new System.Drawing.Point(5, 66);
            this.dateLesson.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateLesson.MinDate = new System.DateTime(2022, 4, 19, 0, 0, 0, 0);
            this.dateLesson.Name = "dateLesson";
            this.dateLesson.Size = new System.Drawing.Size(116, 23);
            this.dateLesson.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LightSalmon;
            this.label19.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(5, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(376, 23);
            this.label19.TabIndex = 24;
            this.label19.Text = "Добавление урока";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(679, 65);
            this.comment.MaxLength = 200;
            this.comment.Name = "comment";
            this.comment.PlaceholderText = "Комментарий";
            this.comment.Size = new System.Drawing.Size(91, 23);
            this.comment.TabIndex = 23;
            this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Khaki;
            this.label26.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(679, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 23);
            this.label26.TabIndex = 22;
            this.label26.Text = "Коммент";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classRate
            // 
            this.classRate.Location = new System.Drawing.Point(695, 94);
            this.classRate.Name = "classRate";
            this.classRate.PlaceholderText = "Класс";
            this.classRate.Size = new System.Drawing.Size(75, 23);
            this.classRate.TabIndex = 21;
            this.classRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddRateClass
            // 
            this.AddRateClass.BackColor = System.Drawing.Color.GreenYellow;
            this.AddRateClass.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddRateClass.Location = new System.Drawing.Point(545, 92);
            this.AddRateClass.Name = "AddRateClass";
            this.AddRateClass.Size = new System.Drawing.Size(144, 27);
            this.AddRateClass.TabIndex = 20;
            this.AddRateClass.Text = "Всем в классе";
            this.AddRateClass.UseVisualStyleBackColor = false;
            this.AddRateClass.Click += new System.EventHandler(this.AddRateClass_Click);
            // 
            // AddRateStudent
            // 
            this.AddRateStudent.BackColor = System.Drawing.Color.GreenYellow;
            this.AddRateStudent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddRateStudent.Location = new System.Drawing.Point(396, 92);
            this.AddRateStudent.Name = "AddRateStudent";
            this.AddRateStudent.Size = new System.Drawing.Size(143, 27);
            this.AddRateStudent.TabIndex = 19;
            this.AddRateStudent.Text = "Поставить";
            this.AddRateStudent.UseVisualStyleBackColor = false;
            this.AddRateStudent.Click += new System.EventHandler(this.AddRateStudent_Click);
            // 
            // emailStudent
            // 
            this.emailStudent.Location = new System.Drawing.Point(518, 66);
            this.emailStudent.Name = "emailStudent";
            this.emailStudent.PlaceholderText = "Email";
            this.emailStudent.Size = new System.Drawing.Size(77, 23);
            this.emailStudent.TabIndex = 18;
            this.emailStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(601, 66);
            this.rate.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.rate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(72, 23);
            this.rate.TabIndex = 17;
            this.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Khaki;
            this.label25.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(601, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 23);
            this.label25.TabIndex = 16;
            this.label25.Text = "Оценка";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Khaki;
            this.label24.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(518, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 23);
            this.label24.TabIndex = 15;
            this.label24.Text = "Ученик";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Khaki;
            this.label23.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(396, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 23);
            this.label23.TabIndex = 14;
            this.label23.Text = "Дата урока";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.LightSalmon;
            this.label22.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(396, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(374, 23);
            this.label22.TabIndex = 13;
            this.label22.Text = "Выставление оценки ученикам";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateWork
            // 
            this.dateWork.Location = new System.Drawing.Point(396, 66);
            this.dateWork.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateWork.MinDate = new System.DateTime(2022, 4, 19, 0, 0, 0, 0);
            this.dateWork.Name = "dateWork";
            this.dateWork.Size = new System.Drawing.Size(116, 23);
            this.dateWork.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Yellow;
            this.label21.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(3, 257);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(786, 32);
            this.label21.TabIndex = 11;
            this.label21.Text = "Информация по прошедшему уроку";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Yellow;
            this.label20.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(3, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(538, 31);
            this.label20.TabIndex = 9;
            this.label20.Text = "Расписание занятий классов";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTable
            // 
            this.timeTable.AllowUserToDeleteRows = false;
            this.timeTable.AllowUserToResizeColumns = false;
            this.timeTable.AllowUserToResizeRows = false;
            this.timeTable.BackgroundColor = System.Drawing.Color.Moccasin;
            this.timeTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.timeTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.timeTable.EnableHeadersVisualStyles = false;
            this.timeTable.Location = new System.Drawing.Point(3, 37);
            this.timeTable.Name = "timeTable";
            this.timeTable.RowHeadersVisible = false;
            this.timeTable.RowHeadersWidth = 4;
            this.timeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.timeTable.RowTemplate.Height = 27;
            this.timeTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeTable.Size = new System.Drawing.Size(786, 222);
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
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.DeepSkyBlue;
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
            this.update.Location = new System.Drawing.Point(203, 304);
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
            this.label5.Location = new System.Drawing.Point(410, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дополнительная информация";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LimeGreen;
            this.Save.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(69, 304);
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
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Основная информация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseInfo
            // 
            this.baseInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.baseInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.baseInfo.Controls.Add(this.adress);
            this.baseInfo.Controls.Add(this.schoolName);
            this.baseInfo.Controls.Add(this.label18);
            this.baseInfo.Controls.Add(this.label17);
            this.baseInfo.Controls.Add(this.salary);
            this.baseInfo.Controls.Add(this.exp);
            this.baseInfo.Controls.Add(this.label16);
            this.baseInfo.Controls.Add(this.label15);
            this.baseInfo.Controls.Add(this.classTeacher);
            this.baseInfo.Controls.Add(this.label14);
            this.baseInfo.Controls.Add(this.cabinet);
            this.baseInfo.Controls.Add(this.label13);
            this.baseInfo.Controls.Add(this.hoursPerWeek);
            this.baseInfo.Controls.Add(this.subject);
            this.baseInfo.Controls.Add(this.label12);
            this.baseInfo.Controls.Add(this.label11);
            this.baseInfo.Location = new System.Drawing.Point(410, 60);
            this.baseInfo.Name = "baseInfo";
            this.baseInfo.Size = new System.Drawing.Size(360, 284);
            this.baseInfo.TabIndex = 2;
            // 
            // adress
            // 
            this.adress.BackColor = System.Drawing.Color.PeachPuff;
            this.adress.Enabled = false;
            this.adress.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adress.Location = new System.Drawing.Point(181, 46);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(172, 22);
            this.adress.TabIndex = 32;
            this.adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // schoolName
            // 
            this.schoolName.BackColor = System.Drawing.Color.PeachPuff;
            this.schoolName.Enabled = false;
            this.schoolName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.schoolName.Location = new System.Drawing.Point(3, 46);
            this.schoolName.Name = "schoolName";
            this.schoolName.Size = new System.Drawing.Size(172, 22);
            this.schoolName.TabIndex = 31;
            this.schoolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Salmon;
            this.label18.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(181, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 28);
            this.label18.TabIndex = 30;
            this.label18.Text = "Адрес";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Salmon;
            this.label17.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(3, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 28);
            this.label17.TabIndex = 29;
            this.label17.Text = "Школа";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.PeachPuff;
            this.salary.Enabled = false;
            this.salary.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salary.Location = new System.Drawing.Point(181, 244);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(172, 22);
            this.salary.TabIndex = 28;
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.Color.PeachPuff;
            this.exp.Enabled = false;
            this.exp.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exp.Location = new System.Drawing.Point(3, 244);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(172, 22);
            this.exp.TabIndex = 27;
            this.exp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Salmon;
            this.label16.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(181, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 28);
            this.label16.TabIndex = 26;
            this.label16.Text = "Зарплата";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Salmon;
            this.label15.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 28);
            this.label15.TabIndex = 25;
            this.label15.Text = "Стаж";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classTeacher
            // 
            this.classTeacher.BackColor = System.Drawing.Color.PeachPuff;
            this.classTeacher.Enabled = false;
            this.classTeacher.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classTeacher.Location = new System.Drawing.Point(143, 178);
            this.classTeacher.Name = "classTeacher";
            this.classTeacher.Size = new System.Drawing.Size(210, 22);
            this.classTeacher.TabIndex = 24;
            this.classTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Salmon;
            this.label14.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(143, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 28);
            this.label14.TabIndex = 23;
            this.label14.Text = "Классное руководство";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cabinet
            // 
            this.cabinet.BackColor = System.Drawing.Color.PeachPuff;
            this.cabinet.Enabled = false;
            this.cabinet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cabinet.Location = new System.Drawing.Point(3, 178);
            this.cabinet.Name = "cabinet";
            this.cabinet.Size = new System.Drawing.Size(134, 22);
            this.cabinet.TabIndex = 22;
            this.cabinet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Salmon;
            this.label13.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(3, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 28);
            this.label13.TabIndex = 21;
            this.label13.Text = "Кабинет";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursPerWeek
            // 
            this.hoursPerWeek.BackColor = System.Drawing.Color.PeachPuff;
            this.hoursPerWeek.Enabled = false;
            this.hoursPerWeek.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hoursPerWeek.Location = new System.Drawing.Point(181, 112);
            this.hoursPerWeek.Name = "hoursPerWeek";
            this.hoursPerWeek.Size = new System.Drawing.Size(172, 22);
            this.hoursPerWeek.TabIndex = 20;
            this.hoursPerWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.PeachPuff;
            this.subject.Enabled = false;
            this.subject.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subject.Location = new System.Drawing.Point(3, 112);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(172, 22);
            this.subject.TabIndex = 19;
            this.subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Salmon;
            this.label12.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(181, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Часы в неделю";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Salmon;
            this.label11.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Предмет";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstInfo
            // 
            this.FirstInfo.BackColor = System.Drawing.Color.SkyBlue;
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
            this.FirstInfo.Location = new System.Drawing.Point(18, 60);
            this.FirstInfo.Name = "FirstInfo";
            this.FirstInfo.Size = new System.Drawing.Size(360, 227);
            this.FirstInfo.TabIndex = 1;
            // 
            // role
            // 
            this.role.BackColor = System.Drawing.Color.PeachPuff;
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
            this.label10.BackColor = System.Drawing.Color.Salmon;
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
            this.label9.BackColor = System.Drawing.Color.Salmon;
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
            this.phoneNumber.BackColor = System.Drawing.Color.PeachPuff;
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
            this.email.BackColor = System.Drawing.Color.PeachPuff;
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
            this.login.BackColor = System.Drawing.Color.PeachPuff;
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
            this.label8.BackColor = System.Drawing.Color.Salmon;
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
            this.label7.BackColor = System.Drawing.Color.Salmon;
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
            this.label6.BackColor = System.Drawing.Color.Salmon;
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
            this.patronymic.BackColor = System.Drawing.Color.PeachPuff;
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
            this.firstName.BackColor = System.Drawing.Color.PeachPuff;
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
            this.lastName.BackColor = System.Drawing.Color.PeachPuff;
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
            this.label3.BackColor = System.Drawing.Color.Salmon;
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
            this.label2.BackColor = System.Drawing.Color.Salmon;
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
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainControl
            // 
            this.MainControl.Controls.Add(this.Profile);
            this.MainControl.Controls.Add(this.TimeTablePage);
            this.MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControl.Location = new System.Drawing.Point(0, 0);
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(800, 450);
            this.MainControl.TabIndex = 1;
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainControl);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "TeacherPage";
            this.Text = "TeacherPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherPage_FormClosing);
            this.Load += new System.EventHandler(this.TeacherPage_Load);
            this.TimeTablePage.ResumeLayout(false);
            this.TimeTablePage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
            this.Profile.ResumeLayout(false);
            this.baseInfo.ResumeLayout(false);
            this.baseInfo.PerformLayout();
            this.FirstInfo.ResumeLayout(false);
            this.FirstInfo.PerformLayout();
            this.MainControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TimeTablePage;
        private System.Windows.Forms.Label label20;
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
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel baseInfo;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.TextBox schoolName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox classTeacher;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cabinet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox hoursPerWeek;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel FirstInfo;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateWork;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown rate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox emailStudent;
        private System.Windows.Forms.TextBox classRate;
        private System.Windows.Forms.Button AddRateClass;
        private System.Windows.Forms.Button AddRateStudent;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button OpenTimeTable;
        private System.Windows.Forms.TextBox timeTableClass;
        private System.Windows.Forms.TextBox classLesson;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dateLesson;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button CreateLesson;
        private System.Windows.Forms.TextBox homework;
        private System.Windows.Forms.Label label29;
    }
}