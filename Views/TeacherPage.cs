using EF_School_DB_Managment.Controllers;
using EF_School_DB_Managment.Models;
using System;
using System.Windows.Forms;

namespace EF_School_DB_Managment.Views
{
    public partial class TeacherPage : Form
    {
        private readonly UserManager manager = new UserManager(); //менеджер юзеров
        private Teacher User { get; set; } //текущий пользователь

        public TeacherPage(Teacher teacher)
        {
            User = teacher;
            InitializeComponent();
        }

        //загрузка формы
        private async void TeacherPage_Load(object sender, EventArgs e)
        {
            //получение связанных данных для тек.юзера
            User = await manager.GetTeacherAllAsync(User.Email);
            InitializeProfilePage();
            //заполняет расписание если клюруководитель
            if (User.Class != null) SetTimeTable(User.Class);
        }

        //закрытие приложения при закрытии формы
        private void TeacherPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //заполнение профиля пользовательскими данными
        private void InitializeProfilePage()
        {
            //проверка клас.руководство если есть - возвращаем
            if (User.ClassId == null) classTeacher.Text = "";
            else classTeacher.Text = User.Class.Name;

            lastName.Text = User.FirstName;
            firstName.Text = User.LastName;
            patronymic.Text = User.Patronymic;
            login.Text = User.Login;
            email.Text = User.Email;
            phoneNumber.Text = User.PhoneNumber;
            birthday.Value = User.Birthday;
            role.Text = User.Role;
            schoolName.Text = User.BaseTeacher.SchoolName;
            adress.Text = User.BaseTeacher.Adress;
            subject.Text = User.BaseTeacher.Subject;
            hoursPerWeek.Text = User.BaseTeacher.HoursPerWeek.ToString();
            cabinet.Text = User.BaseTeacher.Cabinet.ToString();
            exp.Text = User.BaseTeacher.Exp.ToString();
            salary.Text = User.BaseTeacher.Salary.ToString();
        }

        //метод заполнения таблицы расписания
        private void SetTimeTable(Class @class)
        {
            timeTable.Rows.Clear();
            //блокируем ввод значений
            timeTable.ReadOnly = true;
            //добавляем строки для уроков 
            for (int i = 0; i < 6; i++) timeTable.Rows.Add();
            //заполняем расписание
            for (int i = 0; i < @class.TimeTable.Count; i++)
            {
                timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[0].Value = @class.TimeTable[i].NumberLesson + 1;
                timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[1].Value = @class.TimeTable[i].BeginTime.ToString("t");
                timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[2].Value = @class.TimeTable[i].EndTime.ToString("t");
                timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[@class.TimeTable[i].DayOfWeek + 3].Value = @class.TimeTable[i].Subject;
            }
        }

        //вкл./выкл. полей ввода
        private void ChangeUpdateFlag()
        {
            login.Enabled = !login.Enabled;
            phoneNumber.Enabled = !phoneNumber.Enabled;
            birthday.Enabled = !birthday.Enabled;
            schoolName.Enabled = !schoolName.Enabled;
            adress.Enabled = !adress.Enabled;
        }

        //кнопка вкл. изменения данных
        private void update_Click(object sender, EventArgs e)
        {
            ChangeUpdateFlag();
        }

        //кнопка сохранения изменений
        private async void Save_Click(object sender, EventArgs e)
        {
            User.Login = login.Text;
            User.Birthday = birthday.Value;
            User.PhoneNumber = phoneNumber.Text;
            User.BaseTeacher.Adress = adress.Text;
            User.BaseTeacher.SchoolName = schoolName.Text;

            //сохраняем данные и возвращаем true/false
            if (await manager.UpdateTeacherAsync(User))
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранение данных профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Данные не сохранены. Проверьте корректность введённых данных.", "Сохранение данных профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ChangeUpdateFlag();
        }

        //выставление оценки ученику
        private async void AddRateStudent_Click(object sender, EventArgs e)
        {
            //проверка введенных данных
            if (dateWork.Value.Date <= DateTime.Now && emailStudent.Text.Trim().Length != 0)
            {
                //получаем ученика по емейлу
                var student = await manager.GetStudentAsync(emailStudent.Text);
                //проверка на сущ-и ученика
                if (student != null)
                {
                    //добавляем оценку с предметом тек.учителя
                    if (await manager.SetRateStudentAsync(student.Email, new Rating()
                    {
                        Subject = User.BaseTeacher.Subject,
                        Rate = (sbyte)rate.Value,
                        Comment = comment.Text,
                        Date = dateWork.Value,
                    })) MessageBox.Show("Оценка успешно выставлена", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("В этот день нету урока. Проверьте дату или создайте урок", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Такого ученика не существует", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Данные введены некорректно, дата не должна быть больше сег. дня", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //выставление оценки всему классу
        private async void AddRateClass_Click(object sender, EventArgs e)
        {
            //проверка введенных данных
            if (dateWork.Value.Year <= DateTime.Now.Year && dateWork.Value.Month <= DateTime.Today.Month && classRate.Text.Trim().Length != 0)
            {
                //получаем ученика по емейлу
                var @class = await manager.GetClassAsync(classRate.Text);
                //проверка на сущ-и учителя
                if (@class != null)
                {
                    //добавляем оценку с предметом тек.учителя
                    if (await manager.SetRateClassAsync(@class.Id, User.BaseTeacher.Subject, (sbyte)rate.Value, dateWork.Value, comment.Text))
                        MessageBox.Show("Оценка всем ученикам успешно выставлена", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("В этот день нету урока. Проверьте дату или создайте урок", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else MessageBox.Show("Такого класса не существует", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Данные введены некорректно, дата не должна быть больше сег. дня", "Выставление оценки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //открытие расписания классов
        private async void OpenTimeTable_Click(object sender, EventArgs e)
        {
            //проверка ввода
            if (timeTableClass.Text.Trim().Length != 0)
            {
                //получаем класс по названию и проверяем его
                var @class = await manager.GetClassTimeTableAsync(timeTableClass.Text);
                if (@class != null) SetTimeTable(@class);
                else MessageBox.Show("Такого класса не существует", "Расписание классов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Некорректно заполнено название класса", "Расписание классов", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //создаём урок
        private async void CreateLesson_Click(object sender, EventArgs e)
        {
            //проверка ввода
            if (classLesson.Text.Trim().Length != 0 && homework.Text.Trim().Length != 0)
            {
                //урок должен быть раньше тек.даты
                if (dateLesson.Value <= DateTime.Now)
                {
                    //получаем класс по названию
                    var @class = await manager.GetClassAsync(classLesson.Text);
                    //если класс сущ-ует
                    if (@class != null)
                    {
                        //создаём урок
                        if (await manager.CreateLessonAsync(@class.Name, new Lesson()
                        {
                            Subject = User.BaseTeacher.Subject,
                            Date = dateLesson.Value,
                            HomeWork = homework.Text
                        })) MessageBox.Show("Урок успешно добавлен", "Создание урока", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Такой урок уже существует", "Создание урока", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Такого класса не существует", "Создание урока", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Дата урока может быть сегодняшней или ранее", "Создание урока", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Заполните все поля корректно", "Создание урока", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
