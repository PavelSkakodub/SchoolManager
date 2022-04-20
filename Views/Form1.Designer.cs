namespace EF_School_DB_Managment
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SignIn = new System.Windows.Forms.Button();
            this.login_pas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.login_log = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.confirm_pas = new System.Windows.Forms.TextBox();
            this.register_pas = new System.Windows.Forms.TextBox();
            this.register_log = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CodeRegistration = new System.Windows.Forms.TextBox();
            this.RegistrationCodeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SignIn);
            this.splitContainer1.Panel1.Controls.Add(this.login_pas);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.login_log);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.help);
            this.splitContainer1.Panel2.Controls.Add(this.Email);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneNumber);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.SignUp);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.confirm_pas);
            this.splitContainer1.Panel2.Controls.Add(this.register_pas);
            this.splitContainer1.Panel2.Controls.Add(this.register_log);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.CodeRegistration);
            this.splitContainer1.Panel2.Controls.Add(this.RegistrationCodeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.UserRole);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.birthday);
            this.splitContainer1.Panel2.Controls.Add(this.patronymic);
            this.splitContainer1.Panel2.Controls.Add(this.firstName);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.lastName);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(597, 340);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.SteelBlue;
            this.SignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignIn.Location = new System.Drawing.Point(62, 211);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(110, 37);
            this.SignIn.TabIndex = 18;
            this.SignIn.Text = "Вход";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // login_pas
            // 
            this.login_pas.Location = new System.Drawing.Point(62, 174);
            this.login_pas.Name = "login_pas";
            this.login_pas.PasswordChar = '*';
            this.login_pas.Size = new System.Drawing.Size(110, 23);
            this.login_pas.TabIndex = 17;
            this.login_pas.Text = "Pimenova2712";
            this.login_pas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Aquamarine;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(62, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Пароль";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_log
            // 
            this.login_log.Location = new System.Drawing.Point(62, 112);
            this.login_log.Name = "login_log";
            this.login_log.Size = new System.Drawing.Size(110, 23);
            this.login_log.TabIndex = 15;
            this.login_log.Text = "alex.johns.2000@mail.ru";
            this.login_log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Aquamarine;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(62, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Емейл";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Khaki;
            this.help.Location = new System.Drawing.Point(265, 9);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 27;
            this.help.Text = "Подсказка";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(200, 252);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(117, 23);
            this.Email.TabIndex = 26;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Aquamarine;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(200, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Email";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(200, 200);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(117, 23);
            this.PhoneNumber.TabIndex = 24;
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Aquamarine;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(200, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Номер телефона";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Salmon;
            this.SignUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUp.Location = new System.Drawing.Point(180, 286);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(160, 37);
            this.SignUp.TabIndex = 19;
            this.SignUp.Text = "Регистрация";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Aquamarine;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(24, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Подтверждение";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm_pas
            // 
            this.confirm_pas.Location = new System.Drawing.Point(24, 300);
            this.confirm_pas.Name = "confirm_pas";
            this.confirm_pas.PasswordChar = '*';
            this.confirm_pas.Size = new System.Drawing.Size(135, 23);
            this.confirm_pas.TabIndex = 21;
            this.confirm_pas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_pas
            // 
            this.register_pas.Location = new System.Drawing.Point(24, 251);
            this.register_pas.Name = "register_pas";
            this.register_pas.PasswordChar = '*';
            this.register_pas.Size = new System.Drawing.Size(135, 23);
            this.register_pas.TabIndex = 20;
            this.register_pas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_log
            // 
            this.register_log.Location = new System.Drawing.Point(24, 200);
            this.register_log.Name = "register_log";
            this.register_log.Size = new System.Drawing.Size(135, 23);
            this.register_log.TabIndex = 19;
            this.register_log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Aquamarine;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(24, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Пароль";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Aquamarine;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Логин";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodeRegistration
            // 
            this.CodeRegistration.Location = new System.Drawing.Point(24, 132);
            this.CodeRegistration.Name = "CodeRegistration";
            this.CodeRegistration.Size = new System.Drawing.Size(191, 23);
            this.CodeRegistration.TabIndex = 14;
            this.CodeRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegistrationCodeLabel
            // 
            this.RegistrationCodeLabel.BackColor = System.Drawing.Color.Aquamarine;
            this.RegistrationCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegistrationCodeLabel.Location = new System.Drawing.Point(24, 105);
            this.RegistrationCodeLabel.Name = "RegistrationCodeLabel";
            this.RegistrationCodeLabel.Size = new System.Drawing.Size(191, 20);
            this.RegistrationCodeLabel.TabIndex = 13;
            this.RegistrationCodeLabel.Text = "Код регистрации";
            this.RegistrationCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Aquamarine;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(221, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ваша роль";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserRole
            // 
            this.UserRole.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UserRole.FormattingEnabled = true;
            this.UserRole.Items.AddRange(new object[] {
            "Ученик",
            "Учитель",
            "Админ"});
            this.UserRole.Location = new System.Drawing.Point(221, 132);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(117, 23);
            this.UserRole.TabIndex = 11;
            this.UserRole.Text = "Выберите роль";
            this.UserRole.SelectedIndexChanged += new System.EventHandler(this.UserRole_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(221, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата рождения";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(221, 75);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(117, 23);
            this.birthday.TabIndex = 9;
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(154, 75);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(61, 23);
            this.patronymic.TabIndex = 8;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(100, 75);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(44, 23);
            this.firstName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aquamarine;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(154, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Отчество";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Фамилия";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(24, 75);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(65, 23);
            this.lastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрация";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 340);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(613, 379);
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.ComboBox UserRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label RegistrationCodeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodeRegistration;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox login_pas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox login_log;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox confirm_pas;
        private System.Windows.Forms.TextBox register_pas;
        private System.Windows.Forms.TextBox register_log;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button help;
    }
}
