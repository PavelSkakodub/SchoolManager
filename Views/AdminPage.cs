using EF_School_DB_Managment.Controllers;
using EF_School_DB_Managment.Models;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using ConvertApiDotNet;
using Microsoft.EntityFrameworkCore;

namespace EF_School_DB_Managment.Views
{
    public partial class AdminPage : Form
    {
        private readonly UserManager manager = new UserManager(); //менеджер юзеров
        private Admin Admin { get; set; } //текущий пользователь
        private string Message { get; set; } //сообщение для отправки на почту
        private string FilePath { get; set; } //путь к файлу для конвертации

        public AdminPage(Admin admin)
        {
            Admin = admin;
            InitializeComponent();
        }

        //закрытие приложения при закрытии формы
        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Сведения по ученикам

        //зачислить ученика в класс
        private async void SetStudentsClass_Click(object sender, EventArgs e)
        {
            //проверка на пустые поля
            if (emailAddClass.Text.Trim().Length != 0 && classNameAdd.Text.Trim().Length != 0)
            {
                //ищем ученика по емейлу
                var student = await manager.GetStudentAsync(emailAddClass.Text);
                //проверка на сущ-ие класса
                if (await manager.GetClassAsync(classNameAdd.Text) != null)
                {
                    //проверка на сущ-ие ученика
                    if (student != null)
                    {
                        if (student.ClassId == null)
                        {
                            //зачисление в класс
                            await Admin.AddStudentToClassAsync(emailAddClass.Text, classNameAdd.Text);
                            MessageBox.Show($"Ученик {emailAddClass.Text} успешно добавлен в класс {classNameAdd.Text}", "Зачисление в класс", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show($"Ученик {emailAddClass.Text} состоит в классе {student.Class.Name}", "Зачисление в класс", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show($"Ученика {emailAddClass.Text} не существует", "Зачисление в класс", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show($"Класса {classNameAdd.Text} не существует", "Зачисление в класс", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        //отчислить ученика из класса
        private async void DeleteStudent_Click(object sender, EventArgs e)
        {
            //проверка на пустое поле ввода
            if (deleteEmail.Text.Trim().Length != 0)
            {
                //ищем ученика по емейлу
                var student = await manager.GetStudentAsync(deleteEmail.Text);
                //проверка на сущ-ие ученика
                if (student != null)
                {
                    //если ученик состоит в классе
                    if (student.ClassId != null)
                    {
                        //отчисляем передав Id класса ученика и его email
                        await Admin.DeleteStudentFromClassAsync((int)student.ClassId, student.Email);
                        MessageBox.Show($"Ученик {deleteEmail.Text} отчислен из класса {student.Class.Name}", "Отчисление из класса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show($"Ученик {deleteEmail.Text} не зачислен ни в один класс", "Отчисление из класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show($"Ученика {deleteEmail.Text} не существует", "Отчисление из класса", MessageBoxButtons.OK, MessageBoxIcon.Error);                          
            }
        }

        //найти ученика
        private async void checkClass_Click(object sender, EventArgs e)
        {
            //поиск ученика по емейлу
            var student = await manager.GetStudentAllAsync(findName.Text);

            //проверка на сущ-ие ученика
            if (student != null)
            {
                string className, classTeacher;
                //проверка что класс у ученика сущ-ет
                if (student.ClassId != null)
                {
                    className = student.Class.Name;
                    classTeacher = student.Class.ClassTeacher;
                }
                else className = classTeacher = "-";

                MessageBox.Show(
                    $"Ученик {student.Login}: {student.LastName} {student.FirstName} {student.Patronymic}\n" +
                    $"Школа: {student.BaseStudent.SchoolName}\n" +
                    $"Класс: {className}, кл. руководитель: {classTeacher}\n" +
                    $"Адрес: {student.BaseStudent.Adress}\n" +
                    $"Номер личный: {student.PhoneNumber}, номер родителей: {student.BaseStudent.ParentsPhone}\n" +
                    $"Дата рождения: {student.Birthday.ToString("d")}", "Информация о студенте");
            }
            else MessageBox.Show($"Ученик с емейлом {emailAddClass.Text} не найден.", "Поиск ученика", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //выгрузить учеников в эксель
        private async void downloadToExcel_Click(object sender, EventArgs e)
        {
            //получение списка учеников с связями
            var students = await manager.GetStudentsListAsync();
            //экспорт и открытие эксель файла
            Admin.ExportStudentsExcel(students);
        }
        #endregion

        #region Сведения по учителям

        //увольнение учителя
        private async void DeleteTeacher_Click(object sender, EventArgs e)
        {
            //проверка на пустое поле ввода
            if (teacher.Text.Trim().Length != 0)
            {
                //ищем учителя по емейлу
                var _teacher = await manager.GetTeacherAsync(teacher.Text);
                //проверка на сущ-ие учителя
                if (_teacher != null)
                {
                    //увольняем учителя
                    await Admin.DeleteTeacherAsync(teacher.Text);
                    MessageBox.Show($"Учитель {teacher.Text} уволен", "Увольнение учителя", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else MessageBox.Show($"Учителя {teacher.Text} не существует", "Увольнение учителя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //назначение предмета учителю
        private async void AddTeacherSubject_Click(object sender, EventArgs e)
        {
            //проверка на пустой ввод
            if (teacher.Text.Trim().Length != 0 && teacherSubject.Text.Trim().Length != 0)
            {
                //ищем учителя по емейлу
                var _teacher = await manager.GetTeacherAsync(teacher.Text);
                //проверка на сущ-ие учителя
                if (_teacher != null)
                {
                    //назначаем предмет
                    await Admin.AddTeacherSubjectAsync(teacher.Text, teacherSubject.Text);
                    MessageBox.Show($"Учителю {teacher.Text} назначен предмет {teacherSubject.Text}", "Увольнение учителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Учителя {teacher.Text} не существует", "Назначение предмета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //назначение кабинета учителю
        private async void AddTeacherCabinet_Click(object sender, EventArgs e)
        {
            //проверка на пустой ввод
            if (teacher.Text.Trim().Length != 0 && sbyte.TryParse(cabinetNumber.Text, out sbyte res))
            {
                //ищем учителя по емейлу
                var _teacher = await manager.GetTeacherAsync(teacher.Text);
                //проверка на сущ-ие учителя
                if (_teacher != null)
                {
                    //назначаем кабинет
                    await Admin.AddTeacherCabinetAsync(teacher.Text, sbyte.Parse(cabinetNumber.Text));
                    MessageBox.Show($"Учителю {teacher.Text} назначен кабинет {cabinetNumber.Text}", "Назначение кабинета", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Учителя {teacher.Text} не существует", "Назначение кабинета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Поля заполнены некорректно. Номер кабинета это целое число от -127 до 127", "Назначение кабинета", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //назначение часов учителю
        private async void AddTeacherHours_Click(object sender, EventArgs e)
        {
            //проверка на ввод
            if (teacher.Text.Trim().Length != 0 && sbyte.TryParse(hoursWork.Text, out sbyte res))
            {
                //ищем учителя по емейлу
                var _teacher = await manager.GetTeacherAsync(teacher.Text);
                //проверка на сущ-ие учителя
                if (_teacher != null)
                {
                    //назначаем нагрузку
                    await Admin.AddHoursWorkTeacherAsync(teacher.Text, sbyte.Parse(hoursWork.Text));
                    MessageBox.Show($"Учителю {teacher.Text} назначена нагрузка {hoursWork.Text}", "Назначение нагрузки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Учителя {teacher.Text} не существует", "Назначение нагрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Поля заполнены некорректно. Нагрузка в неделю это целое число до 40", "Назначение нагрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //назначение опыта учителю
        private async void AddExpTeacher_Click(object sender, EventArgs e)
        {
            //проверка на ввод
            if (teacher.Text.Trim().Length != 0 && sbyte.TryParse(exp.Text, out sbyte res))
            {
                //ищем учителя по емейлу
                var _teacher = await manager.GetTeacherAsync(teacher.Text);
                //проверка на сущ-ие учителя
                if (_teacher != null)
                {
                    //назначаем опыт
                    await Admin.AddExpTeacherAsync(teacher.Text, sbyte.Parse(exp.Text));
                    MessageBox.Show($"Учителю {teacher.Text} установлен опыт работы {exp.Text}", "Назначение опыта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Учителя {teacher.Text} не существует", "Назначение опыта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Поля заполнены некорректно. Опыт работы это целое число до 75", "Назначение опыта", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //назначение зарплаты учителю
        private async void AddTeacherSalary_Click(object sender, EventArgs e)
        {
            //проверка на ввод
            if (teacher.Text.Trim().Length != 0 && ushort.TryParse(salary.Text, out ushort res))
            {
                //ищем учителя по емейлу
                var _teacher = await manager.GetTeacherAsync(teacher.Text);
                //проверка на сущ-ие учителя
                if (_teacher != null)
                {
                    //назначаем зарплату
                    await Admin.AddSalaryTeacherAsync(teacher.Text, ushort.Parse(salary.Text));
                    MessageBox.Show($"Учителю {teacher.Text} установлена зарплата {salary.Text}", "Назначение зарплаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Учителя {teacher.Text} не существует", "Назначение зарплаты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Поля заполнены некорректно. Зарплата это целое число не более 200 000", "Назначение зарплаты", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //поиск учителя
        private async void FindTeacher_Click(object sender, EventArgs e)
        {
            //поиск учителя по емейлу
            var teacher = await manager.GetTeacherAllAsync(emailTeacherFind.Text);

            //проверка на сущ-ие учителя
            if (teacher != null)
            {
                string className;
                //проверка на кл.руководство
                if (teacher.ClassId != null) className = teacher.Class.Name;
                else className = "-";

                MessageBox.Show(
                    $"Учитель {teacher.Login}: {teacher.LastName} {teacher.FirstName} {teacher.Patronymic}\n" +
                    $"Школа: {teacher.BaseTeacher.SchoolName}\n" +
                    $"Классное руководство: {className}\n" +
                    $"Предмет: {teacher.BaseTeacher.Subject}\n" +
                    $"Кабинет: {teacher.BaseTeacher.Cabinet}\n" +
                    $"Часов в неделю: {teacher.BaseTeacher.HoursPerWeek}, зарплата: {teacher.BaseTeacher.Salary}\n" +
                    $"Опыт работы: {teacher.BaseTeacher.Exp}\n" +
                    $"Адрес: {teacher.BaseTeacher.Adress}\n" +
                    $"Номер личный: {teacher.PhoneNumber}\n" +
                    $"Дата рождения: {teacher.Birthday.ToString("d")}", "Информация о учителе");
            }
            else MessageBox.Show($"Учитель с емейлом {emailTeacherFind.Text} не найден.", "Поиск учителя", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //экспорт списка учителей в эесель
        private async void ExportTeachers_Click(object sender, EventArgs e)
        {
            //получение списка учителей с связями
            var teachers = await manager.GetTeacherListAsync();
            //экспорт и открытие эксель файла
            Admin.ExportTeachersExcel(teachers);
        }

        #endregion

        #region Сведения по классам

        //кнопка создания класса
        private async void CreateClass_Click(object sender, EventArgs e)
        {
            //если поле не пустое
            if (AddClassName.Text.Trim().Length != 0)
            {
                //проверка на сущ-ие класса
                if (await manager.GetClassAsync(AddClassName.Text) == null)
                {
                    //добавляем в БД новый класс
                    await Admin.CreateClassAsync(Admin.InitializeTimeTable(new Class() { Name = AddClassName.Text }));
                    MessageBox.Show($"Класс {AddClassName.Text} успешно создан", "Удаление класса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Класс c именем {AddClassName.Text} уже существует", "Создание класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //кнопка удаления класса
        private async void OnDeleteClass_Click(object sender, EventArgs e)
        {
            //проверка на пустое поле ввода
            if (deleteClass.Text.Trim().Length != 0)
            {
                //находим класс по названию
                var findClass = await manager.GetClassAsync(deleteClass.Text);
                //проверка на сущ-ие класса
                if (findClass != null)
                {
                    //удаление класса и сообщение
                    await Admin.DeleteClassAsync(findClass.Name);
                    MessageBox.Show($"Класс {deleteClass.Text} успешно удалён", "Удаление класса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Класса с именем {deleteClass.Text} не существует", "Удаление класса", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }         
        }

        //кнопка добавления классного руководителя
        private async void AddClassTeacher_Click(object sender, EventArgs e)
        {
            //проверка на пустые поля
            if (emailClassTeacher.Text.Trim().Length != 0 && emailClassTeacher.Text.Trim().Length != 0)
            {
                //проверка на сущ-ие класса
                if (await manager.GetClassAsync(classTeacher.Text) != null)
                {
                    //проверка на сущ-ие учителя
                    if (await manager.GetTeacherAsync(emailClassTeacher.Text) != null)
                    {
                        //назначение классного руководителя
                        await Admin.AddClassTeacherAsync(emailClassTeacher.Text, classTeacher.Text);
                        MessageBox.Show($"Учитель {emailClassTeacher.Text} назначен классным руководителем класса {classTeacher.Text}", "Назначение классного руководителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show($"Учителя {emailClassTeacher.Text} не существует", "Назначение классного руководителя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show($"Класса {classTeacher.Text} не существует", "Назначение классного руководителя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //кнопка добавления старосты
        private async void AddHeadMan_Click(object sender, EventArgs e)
        {
            //проверка на пустое поле
            if (emailHeadMan.Text.Trim().Length != 0)
            {
                //получаем ученика
                var student = await manager.GetStudentAsync(emailHeadMan.Text);

                //проверка на сущ-ие ученика
                if (student != null)
                {
                    //если ученик зачислен в класс
                    if (student.Class != null)
                    {
                        //назначение старосты
                        await Admin.AddClassHeadmanAsync(emailHeadMan.Text);
                        MessageBox.Show($"Ученик {emailHeadMan.Text} назначен старостой класса {student.Class.Name}", "Назначение старосты класса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show($"Ученика {emailHeadMan.Text} нет ни в одном классе", "Назначение старосты класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show($"Ученика {emailHeadMan.Text} не существует", "Назначение старосты класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //поиск класса
        private async void ClassFindByName_Click(object sender, EventArgs e)
        {
            //проверка на пустую строку
            if (findClass.Text.Trim().Length != 0)
            {
                //поиск класса по названию
                var @class = await manager.GetClassAsync(findClass.Text);

                //проверка на сущ-ие класса
                if (@class != null)
                {
                    byte count;
                    //проверка что у класса есть ученики
                    if (@class.Students != null) count = (byte)@class.Students.Count;
                    else count = 0;

                    MessageBox.Show(
                        $"Название: {@class.Name}\n" +
                        $"Количество учеников: {count}\n" +
                        $"Классный руководитель: {@class.ClassTeacher}", "Информация о классе");
                }
                else MessageBox.Show($"Класса с названием {findClass.Text} не существует.", "Поиск класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        //кнопка выгрузки данных класса в эксель
        private async void ExportClassToExcel_Click(object sender, EventArgs e)
        {
            //проверка на пустую строку
            if (findClass.Text.Trim().Length != 0)
            {
                //получение класса с учениками
                var @class = await manager.GetClassAsync(findClass.Text);
                //экспорт и открытие эксель файла
                Admin.ExportClassExcel(@class);
            }
            else MessageBox.Show("Сначала заполните название класса.", "Выгрузка данных класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Расписание

        //загрузить расписание класса
        private async void OpenTimeTable_Click(object sender, EventArgs e)
        {
            if (timeTableClass.Text.Trim().Length != 0)
            {
                //ищем класс с его расписанием
                var @class = await manager.GetClassTimeTableAsync(timeTableClass.Text);
                //проверка на сущ-ие класса
                if (@class != null)
                {
                    //блокируем ввод значений
                    timeTable.ReadOnly = true;
                    //очистка прежних строк
                    timeTable.Rows.Clear();
                    //добавляем строки для уроков и запрещаем изменять номера уроков
                    for (int i = 0; i < 6; i++)
                    {
                        timeTable.Rows.Add();
                        timeTable.Rows[i].Cells[0].ReadOnly = true;
                    }

                    for (int i = 0; i < @class.TimeTable.Count; i++)
                    {
                        timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[0].Value = @class.TimeTable[i].NumberLesson + 1;
                        timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[1].Value = @class.TimeTable[i].BeginTime.ToString("t");
                        timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[2].Value = @class.TimeTable[i].EndTime.ToString("t");
                        timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[@class.TimeTable[i].DayOfWeek + 3].Value = @class.TimeTable[i].Subject;
                    }
                }
                else MessageBox.Show($"Класса {timeTableClass.Text} не существует", "Расписание класса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //изменить расписание
        private void EditTimeTable_Click(object sender, EventArgs e)
        {
            timeTable.ReadOnly = !timeTable.ReadOnly;
            //запрет изменения номеров занятий
            for (int i = 0; i < timeTable.Rows.Count; i++)
            {
                timeTable.Rows[i].Cells[0].ReadOnly = true;
            }
        }

        //сохранить изменения в расписании
        private async void SaveTimeTable_Click(object sender, EventArgs e)
        {
            //проверка что название класса не стерто
            if (timeTableClass.Text.Trim().Length != 0)
            {
                //используем контекст БД
                using var context = new SchoolDbContext();
                var @class = await context.Classes.Include(x => x.TimeTable).FirstOrDefaultAsync(x => x.Name == timeTableClass.Text);
                //проверка на сущ-ие класса
                if (@class != null)
                {
                    try
                    {
                        //асинхр-но выполняем изменение данных
                        await Task.Run(() =>
                        {
                            for (int i = 0; i < @class.TimeTable.Count; i++)
                            {
                                @class.TimeTable[i].BeginTime = Convert.ToDateTime(timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[1].Value.ToString());
                                @class.TimeTable[i].EndTime = Convert.ToDateTime(timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[2].Value.ToString());
                                @class.TimeTable[i].Subject = timeTable.Rows[@class.TimeTable[i].NumberLesson].Cells[@class.TimeTable[i].DayOfWeek + 3].Value.ToString();
                            }
                        });
                        //сохраняем все данные в БД
                        context.SaveChanges();
                        timeTable.ReadOnly = true;
                        MessageBox.Show($"Расписание класса {timeTableClass.Text} успешно изменено", "Изменение расписания", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Изменение расписания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region Уведомления и конвертация

        //сообщение для отправки
        private void EmailMessage_Click(object sender, EventArgs e)
        {
            //настройки диалогового окна
            FileDialog.FileName = "Выберите файл";
            FileDialog.Filter = "Text files (*.txt)|*.txt|(*.html)|*.html";
            FileDialog.Title = "Откройте текстовый файл";

            //открываем окно выбора файла
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //считываем файл в строку сообщения
                    Message = new StreamReader(FileDialog.FileName).ReadToEnd();
                    MessageBox.Show("Сообщение успешно загружено, можно отправлять", "Загрузка сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //отправка сообщения одному пользователю
        private async void SendEmail_Click(object sender, EventArgs e)
        {
            //проверка на ввод полей
            if (FromEmailSend.Text.Trim().Length != 0 && nameSendEmail.Text.Trim().Length != 0 && titleSendEmail.Text.Trim().Length != 0)
            {
                //проверка на пустое сообщение
                if (Message != null && Message.Trim().Length != 0)
                {
                    //ищем юзера которому отправим сообщение
                    var user = (User)await manager.GetUserByEmailAsync(FromEmailSend.Text);
                    //проверка на сущ-ие юзера
                    if (user != null)
                    {
                        try
                        {
                            //запускаем асинх-ое выполнение
                            await Task.Run(() =>
                            {
                                //объект класса отправки
                                EmailSender emailSender = new EmailSender();
                                //отправка сообщения
                                emailSender.SendEmail(nameSendEmail.Text, user.Email, titleSendEmail.Text, Message);
                                //очистка сообщения
                                Message = "";
                                MessageBox.Show($"Сообщение успешно отправлено на емейл {FromEmailSend.Text}", "Отправка сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            });                            
                        }
                        catch (Exception ex)
                        {
                            LogList.ForeColor = System.Drawing.Color.Red;
                            LogList.Items.Add($"Email: {user.Email}, ошибка: {ex.Message}");
                        }
                    }
                    else MessageBox.Show("Такого пользователя не существует", "Отправка сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Сначала загрузите сообщение", "Отправка сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Заполните необходимые поля (имя, кому, заголовок и сообщение)", "Отправка сообщения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //отправка сообщения всему классу
        private async void MoreSend_Click(object sender, EventArgs e)
        {
            //проверка на ввод полей
            if (classSend.Text.Trim().Length != 0 && nameSendEmail.Text.Trim().Length != 0 && titleSendEmail.Text.Trim().Length != 0)
            {
                //проверка на пустое сообщение
                if (Message != null && Message.Trim().Length != 0)
                {
                    //ищем юзера которому отправим сообщение
                    var @class = await manager.GetClassAsync(classSend.Text);
                    //проверка на сущ-ие юзера
                    if (@class != null)
                    {
                        //объект класса отправки
                        EmailSender emailSender = new EmailSender();
                        LogList.Items.Clear(); //очищаем прежнией лог

                        foreach (Student user in @class.Students)
                        {
                            try
                            {
                                //запускаем асинх-ое выполнение
                                await Task.Run(() =>
                                {
                                    //отправка сообщения
                                    emailSender.SendEmail(nameSendEmail.Text, user.Email, titleSendEmail.Text, Message);
                                });

                                //записываем успех зелёным
                                LogList.ForeColor = System.Drawing.Color.Lime;
                                LogList.Items.Add($"Email: {user.Email} получил сообщение");
                            }
                            catch (Exception ex)
                            {
                                //записываем ошибку красным
                                LogList.ForeColor = System.Drawing.Color.Red;
                                LogList.Items.Add($"Email: {user.Email}, ошибка: {ex.Message}");
                                continue; //продолжаем идти по циклу отправки
                            }
                        }
                        //чистим сообщение
                        Message = "";
                        if (LogList.Items.Count == 0) MessageBox.Show("Сообщение успешно отправлено всему классу", "Отправка сообщения всему классу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Такого класса не существует", "Отправка сообщения всему классу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Сначала загрузите сообщение", "Отправка сообщения всему классу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Заполните необходимые поля (имя, класс, заголовок и сообщение)", "Отправка сообщения всему классу", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //отправка сообщения всем учителям
        private async void SendAllTeacher_Click(object sender, EventArgs e)
        {
            //проверка на ввод полей
            if (nameSendEmail.Text.Trim().Length != 0 && titleSendEmail.Text.Trim().Length != 0)
            {
                //проверка на пустое сообщение
                if (Message != null && Message.Trim().Length != 0)
                {
                    //получаем список учителей
                    var teachers = await manager.GetTeacherListAsync();
                    //проверка на сущ-ие списка учителей
                    if (teachers != null && teachers.Count != 0)
                    {
                        //объект класса отправки
                        EmailSender emailSender = new EmailSender();
                        LogList.Items.Clear(); //очищаем прежнией лог

                        foreach (Teacher user in teachers)
                        {
                            try
                            {
                                //запускаем асинх-ое выполнение
                                await Task.Run(() =>
                                {
                                    //отправка сообщения
                                    emailSender.SendEmail(nameSendEmail.Text, user.Email, titleSendEmail.Text, Message);
                                });
                                //записываем успех зелёным
                                LogList.ForeColor = System.Drawing.Color.Lime;
                                LogList.Items.Add($"Email: {user.Email} получил сообщение");
                            }
                            catch (Exception ex)
                            {
                                //записываем ошибку красным
                                LogList.ForeColor = System.Drawing.Color.Red;
                                LogList.Items.Add($"Email: {user.Email}, ошибка: {ex.Message}");
                                continue; //продолжение отправки в цикле
                            }
                        }
                        //чистим сообщение
                        Message = "";
                        if (LogList.Items.Count == 0) MessageBox.Show("Сообщение успешно отправлено всем учителям", "Отправка сообщения всем учителям", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Учителей нету", "Отправка сообщения всем учителям", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Сначала загрузите сообщение", "Отправка сообщения всем учителям", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Заполните необходимые поля (имя, заголовок и сообщение)", "Отправка сообщения всем учителям", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //очистка списка ошибок
        private void ClearError_Click(object sender, EventArgs e)
        {
            //очистка лога
            LogList.Items.Clear();
        }


        //загрузка файла для конвертации
        private void UploadFileConvert_Click(object sender, EventArgs e)
        {
            //если выбран формат
            if (FromFormat.SelectedIndex >= 0)
            {
                //настройки диалогового окна
                FileDialog.FileName = "Выберите файл";
                FileDialog.Filter = $"Select files (*.{FromFormat.SelectedItem})|*.{FromFormat.SelectedItem}";
                FileDialog.Title = "Выберите файл для конвертации";

                //открываем окно выбора файла
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = FileDialog.FileName;
                    MessageBox.Show("Файл успешно загружен", "Загрузка файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Сначала выберите формат из которого нужно конвертировать", "Загрузка файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //выбор формата
        private void FromFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //добавляем возможные форматы для конвертации в ComboBox
            if (FromFormat.SelectedItem.ToString() == "doc" || FromFormat.SelectedItem.ToString() == "wps" || FromFormat.SelectedItem.ToString() == "dot" ||
                FromFormat.SelectedItem.ToString() == "rtf" || FromFormat.SelectedItem.ToString() == "log" || FromFormat.SelectedItem.ToString() == "wri" ||
                FromFormat.SelectedItem.ToString() == "wpd" || FromFormat.SelectedItem.ToString() == "docx" || FromFormat.SelectedItem.ToString() == "dotx")
            {
                AddToFormatConvert(new string[]
                {
                    "doc", "docx", "html", "jpg", "mhtml", "odt", "pdf", "pdfa", "png", "rtf", "tiff", "txt", "webp", "xml", "xps"
                });
            }

            if (FromFormat.SelectedItem.ToString() == "csv" || FromFormat.SelectedItem.ToString() == "xls" || FromFormat.SelectedItem.ToString() == "xlt" ||
                FromFormat.SelectedItem.ToString() == "xlsb" || FromFormat.SelectedItem.ToString() == "xlsx" || FromFormat.SelectedItem.ToString() == "xltx")
            {
                AddToFormatConvert(new string[]
                {
                    "csv", "jpg", "pdf", "pdfa", "png", "tiff", "webp", "xls", "xlsx"
                });
            }

            if (FromFormat.SelectedItem.ToString() == "mpp" || FromFormat.SelectedItem.ToString() == "mpt" || FromFormat.SelectedItem.ToString() == "pub" ||
                FromFormat.SelectedItem.ToString() == "vdx" || FromFormat.SelectedItem.ToString() == "txt" || FromFormat.SelectedItem.ToString() == "vsd" ||
                FromFormat.SelectedItem.ToString() == "vst" || FromFormat.SelectedItem.ToString() == "vsdx" || FromFormat.SelectedItem.ToString() == "vstx")
            {
                AddToFormatConvert(new string[]
                {
                    "jpg", "pdf", "png", "tiff"
                });
            }

            if (FromFormat.SelectedItem.ToString() == "pot" || FromFormat.SelectedItem.ToString() == "pps" || FromFormat.SelectedItem.ToString() == "ppt" ||
                FromFormat.SelectedItem.ToString() == "potx" || FromFormat.SelectedItem.ToString() == "ppsx" || FromFormat.SelectedItem.ToString() == "pptx")
            {
                AddToFormatConvert(new string[]
                {
                    "jpg", "pdf", "png", "ppt", "pptx", "tiff", "webp"
                });
            }

            //добавление форматов в ComboBox с вых.форматом
            void AddToFormatConvert(string[] str)
            {
                foreach (var s in str)
                {
                    ToFormat.Items.Add(s);
                }
            }
        }

        //конвертация файлов с сохранением
        private async void Converting_Click(object sender, EventArgs e)
        {
            //проверка на пустой ввод
            if (FromFormat.SelectedIndex >= 0 && ToFormat.SelectedIndex >= 0 && FilePath.Trim().Length != 0)
            {
                Converting.Text = "Загрузка...";
                try
                {
                    //инициализируем объект конвертера с пом-ю секрета с сайта https://www.convertapi.com/a
                    ConvertApi convertApi = new ConvertApi("D8gBmwuwTor6k2kT");
                    //Установка входных и выходных форматов и передача файла
                    var convertToPdf = await convertApi.ConvertAsync(FromFormat.SelectedItem.ToString(), ToFormat.SelectedItem.ToString(), new ConvertApiFileParam(FilePath));

                    //открываем окно выбора файла
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //сохраняем файл по указанному пути + добавляем формат в конце имени файла
                        string savePath = saveFileDialog1.FileName + $".{ToFormat.SelectedItem}";
                        await convertToPdf.SaveFileAsync(savePath);
                        MessageBox.Show("Файл успешно сохранён", "Конвертация файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Конвертация файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Converting.Text = "Конвертировать";
            }
            else MessageBox.Show("Не все поля были заполнены. Выберите файл и его формат, а также формат конвертации", "Конвертация файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

    }

}
