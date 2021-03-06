using EF_School_DB_Managment.Controllers;
using EF_School_DB_Managment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_School_DB_Managment.Views
{
    public partial class StudentPage : Form
    {
        private readonly UserManager manager = new UserManager(); //менеджер юзеров
        private Student User { get; set; } //текущий пользователь

        //конструктор с инициализацией ученика
        public StudentPage(Student student)
        {
            User = student;
            InitializeComponent();
        }

        //заполнение профиля пользовательскими данными
        private void InitializeProfilePage()
        {
            //проверка на сущ-ие класса
            if (User.ClassId == null)
            {
                className.Text = classTeacher.Text = "-";
            }
            else
            {
                className.Text = User.Class.Name;
                classTeacher.Text = User.Class.ClassTeacher;
            }

            lastName.Text = User.FirstName;
            firstName.Text = User.LastName;
            patronymic.Text = User.Patronymic;
            login.Text = User.Login;
            email.Text = User.Email;
            phoneNumber.Text = User.PhoneNumber;
            birthday.Value = User.Birthday;
            role.Text = User.Role;
            nameSchool.Text = User.BaseStudent.SchoolName;
            adress.Text = User.BaseStudent.Adress;
            socialLink.Text = User.BaseStudent.SocialLink;
            parentsPhone.Text = User.BaseStudent.ParentsPhone;
        }

        //заполнение расписания
        private void InitializeTimeTable()
        {
            //блокируем ввод значений
            timeTable.ReadOnly = true;
            //проверка на сущ-ие класса
            if (User.Class != null)
            {
                //добавляем строки для уроков 
                for (int i = 0; i < 6; i++) timeTable.Rows.Add();
                //заполняем расписание
                for (int i = 0; i < User.Class.TimeTable.Count; i++)
                {
                    timeTable.Rows[User.Class.TimeTable[i].NumberLesson].Cells[0].Value = User.Class.TimeTable[i].NumberLesson + 1;
                    timeTable.Rows[User.Class.TimeTable[i].NumberLesson].Cells[1].Value = User.Class.TimeTable[i].BeginTime.ToString("t");
                    timeTable.Rows[User.Class.TimeTable[i].NumberLesson].Cells[2].Value = User.Class.TimeTable[i].EndTime.ToString("t");
                    timeTable.Rows[User.Class.TimeTable[i].NumberLesson].Cells[User.Class.TimeTable[i].DayOfWeek + 3].Value = User.Class.TimeTable[i].Subject;
                }
            }
        }

        //закрытие приложения при закрытии формы
        private void StudentPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //загрузка формы
        private async void StudentPage_Load(object sender, EventArgs e)
        {
            //получение связанных данных для тек.юзера
            User = await manager.GetStudentAllAsync(User.Email);
            InitializeProfilePage();
            InitializeTimeTable();
        }

        //кнопка вкл. изменения данных
        private void update_Click(object sender, EventArgs e)
        {
            ChangeUpdateFlag();
        }

        //кнопка сохранения
        private async void Save_Click(object sender, EventArgs e)
        {
            User.Login = login.Text;
            User.Birthday = birthday.Value;
            User.PhoneNumber = phoneNumber.Text;
            User.BaseStudent.Adress = adress.Text;
            User.BaseStudent.ParentsPhone = parentsPhone.Text;
            User.BaseStudent.SocialLink = socialLink.Text;
            User.BaseStudent.SchoolName = nameSchool.Text;

            //сохраняем данные и возвращаем true/false
            if (await manager.UpdateStudentAsync(User))
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранение данных профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Данные не сохранены. Проверьте корректность введённых данных.", "Сохранение данных профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ChangeUpdateFlag();
        }

        //вкл./выкл. полей ввода
        private void ChangeUpdateFlag()
        {
            login.Enabled = !login.Enabled;
            phoneNumber.Enabled = !phoneNumber.Enabled;
            birthday.Enabled = !birthday.Enabled;
            adress.Enabled = !adress.Enabled;
            parentsPhone.Enabled = !parentsPhone.Enabled;
            socialLink.Enabled = !socialLink.Enabled;
            nameSchool.Enabled = !nameSchool.Enabled;
        }

        //загрузка уроков и оценок
        private async void OpenRatingLesson_Click(object sender, EventArgs e)
        {
            //получаем список уроков за дату
            var lessons = await manager.GetLessonByDateAsync(User.Class.Id, dateLesson.Value);
            //проверка на сущ-ие уроков в этот день
            if (lessons.Count != 0)
            {
                //очищаем таблицу
                LessonRatingTable.Rows.Clear();               
                //получаем список оценок за дату
                var ratings = await manager.GetRatingsByDateAsync(User.Id, dateLesson.Value);
                //заполняем таблицу
                for (int i = 0; i < lessons.Count; i++)
                {
                    LessonRatingTable.Rows.Add();
                    LessonRatingTable.Rows[i].Cells[0].Value = lessons[i].Subject;
                    LessonRatingTable.Rows[i].Cells[1].Value = lessons[i].HomeWork;
                    //получаем оценку по предмету данного урока
                    var rate = ratings.Where(x => x.Subject == lessons[i].Subject);
                    //перебираем оценки и комменты (может быть несколько)
                    foreach (var r in rate)
                    {
                        LessonRatingTable.Rows[i].Cells[2].Value += r.Rate + " ";
                        LessonRatingTable.Rows[i].Cells[3].Value += r.Comment + " ";
                    }
                }
                //запрет на редактирование таблицы
                LessonRatingTable.ReadOnly = true;
            }
            else MessageBox.Show("Урока за указанную дату нету", "История уроков", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //средняя оценка за период по предмету
        private async void Average_Click(object sender, EventArgs e)
        {
            //проверка введенных дат
            if (BeginOrderRating.Value.Date <= EndOrderRating.Value.Date && SubjectAverage.Text.Trim().Length != 0)
            {
                try
                {
                    //получаем ср.значение по датам
                    float average = await manager.GetAverageBySubjectAsync(User.Id, SubjectAverage.Text, BeginOrderRating.Value, EndOrderRating.Value);
                    MessageBox.Show($"Предмет: {SubjectAverage.Text}\nСреднее значение: {average}\nДиапазон дат: от {BeginOrderRating.Value:d} до {EndOrderRating.Value:d}", "Средняя оценка по предмету", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Данные заполнены некорректно. Проверьте даты и существование предмета", "Средняя оценка по предмету", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            } 
        }

        //экспорт оценок в эксель
        private void ExportRatingToExcel_Click(object sender, EventArgs e)
        {            
            manager.ExportRatingToExcelAsync(User.Id, BeginOrderRating.Value, EndOrderRating.Value);
        }
    }
}
