using EF_School_DB_Managment.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EF_School_DB_Managment.Models
{
    public class Admin : User
    {
        //здесь все св-ва базового класса которые мигрируются в БД


        //создание нового класса
        public async Task CreateClassAsync(Class @class)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //добавляем класс
            await context.Classes.AddAsync(@class);
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //удаление указанного класса
        public async Task DeleteClassAsync(string name)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем класс с его данными
            var @class = await context.Classes.Include(x => x.Students).FirstOrDefaultAsync(x => x.Name == name);
            //удаляем класс
            context.Classes.Remove(@class);
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //удаление учителя
        public async Task DeleteTeacherAsync(string email)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем учителя
            var teacher = await context.Teachers.FirstOrDefaultAsync(x => x.Email == email);
            //удаляем учителя
            context.Teachers.Remove(teacher);
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //назначение предмета 
        public async Task AddTeacherSubjectAsync(string email, string subject)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем учителя
            var teacher = await context.Teachers.Include(x => x.BaseTeacher).FirstOrDefaultAsync(x => x.Email == email);
            //назначаем предмет
            teacher.BaseTeacher.Subject = subject;
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //назначение часов
        public async Task AddHoursWorkTeacherAsync(string email, sbyte hours)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем учителя
            var teacher = await context.Teachers.Include(x => x.BaseTeacher).FirstOrDefaultAsync(x => x.Email == email);
            //назначаем нгрузку
            teacher.BaseTeacher.HoursPerWeek = hours;
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //назначение опыта
        public async Task AddExpTeacherAsync(string email, sbyte exp)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем учителя
            var teacher = await context.Teachers.Include(x => x.BaseTeacher).FirstOrDefaultAsync(x => x.Email == email);
            //назначаем опыт
            teacher.BaseTeacher.Exp = exp;
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //назначение зарплаты
        public async Task AddSalaryTeacherAsync(string email,ushort salary)
        {
            using var context = new SchoolDbContext();
            //получаем учителя
            var teacher = await context.Teachers.Include(x => x.BaseTeacher).FirstOrDefaultAsync(x => x.Email == email);
            //назначаем зарплату
            teacher.BaseTeacher.Salary = salary;
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //назначение кабинета 
        public async Task AddTeacherCabinetAsync(string email, sbyte cabinet)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем учителя
            var teacher = await context.Teachers.Include(x => x.BaseTeacher).FirstOrDefaultAsync(x => x.Email == email);
            //назначаем кабинет
            teacher.BaseTeacher.Cabinet = cabinet;
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //добавление ученика в класс
        public async Task AddStudentToClassAsync(string email, string name)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //извлекаем данные класса и ученика
            var student = await context.Students.Include(x => x.Class).FirstOrDefaultAsync(x => x.Email == email);
            var @class = await context.Classes.Include(x => x.Students).FirstOrDefaultAsync(x => x.Name == name);
            //добавление ученика в класс (связь)
            @class.Students.Add(student);
            //сохранение изменений в БД
            await context.SaveChangesAsync();
        }

        //удаление ученика из класса
        public async Task DeleteStudentFromClassAsync(int Id,string email)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //извлекаем класс в котором находится наш ученик
            var @class = await context.Classes.Include(x => x.Students).FirstOrDefaultAsync(x => x.Id == Id);
            //удаляем ученика из класса по его емейлу
            @class.Students.RemoveAll(x => x.Email == email);
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //назначение классного руководителя для класса
        public async Task AddClassTeacherAsync(string email, string name)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //находим учителя по емейлу и класс по названию
            var teacher = await context.Teachers.Include(x => x.Class).FirstOrDefaultAsync(x => x.Email == email);
            var @class = await context.Classes.Include(x => x.Teacher).Include(x => x.TimeTable).FirstOrDefaultAsync(x => x.Name == name);
            //удаляем стурую связь (если ранее был класруком)
            if (teacher.Class != null)
            {
                teacher.Class.ClassTeacher = "";
                teacher.Class = null;
            }
            //запис-ем ФИО класрука и задаём новую связь
            @class.ClassTeacher = teacher.LastName + " " + teacher.FirstName + " " + teacher.Patronymic;
            @class.Teacher = teacher;
            //передаём учителю расписание класса
            teacher.TimeTable = @class.TimeTable;
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //назначение старосты (только в своём классе)
        public async Task AddClassHeadmanAsync(string email)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //находим ученика по емейлу
            var student = await context.Students.Include(x => x.Class).FirstOrDefaultAsync(x => x.Email == email);
            //добавляем фио ученика в поле староста его класса
            student.Class.HeadMan = student.LastName + " " + student.FirstName + " " + student.Patronymic;
            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //экспортирование списка учеников в Эксель
        public async void ExportStudentsExcel(List<Student> students)
        {
            //асинхр-ый запуск метода
            await Task.Run(() =>
            {
                //получаем текущий лист эксель
                var sheet = ExcelSettings("Студенты", students.Count);
                //задаём заголовки
                sheet.Cells[1, 1] = "Email";
                sheet.Cells[1, 2] = "Login";
                sheet.Cells[1, 3] = "Фамилия";
                sheet.Cells[1, 4] = "Имя";
                sheet.Cells[1, 5] = "Отчество";
                sheet.Cells[1, 6] = "Телефон";
                sheet.Cells[1, 7] = "Дата рождения";
                sheet.Cells[1, 8] = "Школа";
                sheet.Cells[1, 9] = "Адрес";
                sheet.Cells[1, 10] = "Соц. сеть";
                sheet.Cells[1, 11] = "Телефон родителей";
                sheet.Cells[1, 12] = "Класс";
                sheet.Cells[1, 13] = "Кл. руководитель";
                //задаём значения ячейкам
                for (int i = 0; i < students.Count; i++)
                {
                    sheet.Cells[i + 2, 1] = students[i].Email;
                    sheet.Cells[i + 2, 2] = students[i].Login;
                    sheet.Cells[i + 2, 3] = students[i].LastName;
                    sheet.Cells[i + 2, 4] = students[i].FirstName;
                    sheet.Cells[i + 2, 5] = students[i].Patronymic;
                    sheet.Cells[i + 2, 6] = students[i].PhoneNumber;
                    sheet.Cells[i + 2, 7] = students[i].Birthday.ToString("d");
                    sheet.Cells[i + 2, 8] = students[i].BaseStudent.SchoolName;
                    sheet.Cells[i + 2, 9] = students[i].BaseStudent.Adress;
                    sheet.Cells[i + 2, 10] = students[i].BaseStudent.SocialLink;
                    sheet.Cells[i + 2, 11] = students[i].BaseStudent.ParentsPhone;
                    sheet.Cells[i + 2, 12] = students[i].Class.Name;
                    sheet.Cells[i + 2, 13] = students[i].Class.ClassTeacher;
                }

                //получаем диапазон сначала до последней записи списка
                Excel.Range oRng = sheet.get_Range("A1", $"AA{students.Count + 1}");
                //делаем ячейки по размеру содержимого
                oRng.EntireColumn.AutoFit();
            });    
        }

        //экспортирование списка учителей в Эксель
        public async void ExportTeachersExcel(List<Teacher> teachers)
        {
            //асинхр-ый запуск метода
            await Task.Run(() =>
            {
                //получаем текущий лист эксель
                var sheet = ExcelSettings("Студенты", teachers.Count);
                //задаём заголовки
                sheet.Cells[1, 1] = "Email";
                sheet.Cells[1, 2] = "Login";
                sheet.Cells[1, 3] = "Фамилия";
                sheet.Cells[1, 4] = "Имя";
                sheet.Cells[1, 5] = "Отчество";
                sheet.Cells[1, 6] = "Телефон";
                sheet.Cells[1, 7] = "Дата рождения";
                sheet.Cells[1, 8] = "Школа";
                sheet.Cells[1, 9] = "Адрес";
                sheet.Cells[1, 10] = "Предмет";
                sheet.Cells[1, 11] = "Зарлата";
                sheet.Cells[1, 12] = "Кабинет";
                sheet.Cells[1, 13] = "Кл. руководство";
                sheet.Cells[1, 14] = "Опыт";
                sheet.Cells[1, 15] = "Нагрузка";
                //задаём значения ячейкам
                for (int i = 0; i < teachers.Count; i++)
                {
                    sheet.Cells[i + 2, 1] = teachers[i].Email;
                    sheet.Cells[i + 2, 2] = teachers[i].Login;
                    sheet.Cells[i + 2, 3] = teachers[i].LastName;
                    sheet.Cells[i + 2, 4] = teachers[i].FirstName;
                    sheet.Cells[i + 2, 5] = teachers[i].Patronymic;
                    sheet.Cells[i + 2, 6] = teachers[i].PhoneNumber;
                    sheet.Cells[i + 2, 7] = teachers[i].Birthday.ToString("d");
                    sheet.Cells[i + 2, 8] = teachers[i].BaseTeacher.SchoolName;
                    sheet.Cells[i + 2, 9] = teachers[i].BaseTeacher.Adress;
                    sheet.Cells[i + 2, 10] = teachers[i].BaseTeacher.Subject;
                    sheet.Cells[i + 2, 11] = teachers[i].BaseTeacher.Salary;
                    sheet.Cells[i + 2, 12] = teachers[i].BaseTeacher.Cabinet;
                    sheet.Cells[i + 2, 13] = teachers[i].Class.Name;
                    sheet.Cells[i + 2, 14] = teachers[i].BaseTeacher.Exp;
                    sheet.Cells[i + 2, 15] = teachers[i].BaseTeacher.HoursPerWeek;
                }

                //получаем диапазон сначала до последней записи списка
                Excel.Range oRng = sheet.get_Range("A1", $"AA{teachers.Count + 1}");
                //делаем ячейки по размеру содержимого
                oRng.EntireColumn.AutoFit();
            });
        }

        //инициализация расписания (нач.данные)
        public Class InitializeTimeTable(Class @class)
        {
            //создаём список всех занятий расписания (6 дней по 7 уроков)
            @class.TimeTable = new List<TimeTable>(42);
            //заполняем номера уроков и дни недели по порядку
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    //добавляем день недели и номер урока
                    @class.TimeTable.Add(new TimeTable() { DayOfWeek = (sbyte)i, NumberLesson = (sbyte)j });
                }
            }
            return @class;
        }

        //экспортирование списка классов в Эксель
        public async void ExportClassExcel(Class @class)
        {
            //асинхр-ый запуск метода
            await Task.Run(() =>
            {
                //получаем текущий лист эксель
                var sheet = ExcelSettings($"Класс {@class.Name}", @class.Students.Count + 3);
                //задаём заголовки
                sheet.Cells[1, 1] = "Название класса";
                sheet.Cells[1, 2] = "Классный руководитель";
                sheet.Cells[1, 3] = "Староста";
                sheet.Cells[1, 4] = "Кол-во учеников";
                sheet.Cells[4, 1] = "Email ученика";
                sheet.Cells[4, 2] = "Логин ученика";
                sheet.Cells[4, 3] = "ФИО ученика";
                sheet.Cells[4, 4] = "Телефон ученика";
                //задаём значения верхним ячейкам
                sheet.Cells[2, 1] = @class.Name;
                sheet.Cells[2, 2] = @class.ClassTeacher;
                sheet.Cells[2, 3] = @class.HeadMan;
                sheet.Cells[2, 4] = @class.Students.Count;
                //задаём значения нижним ячейкам
                for (int i = 0; i < @class.Students.Count; i++)
                {
                    sheet.Cells[i + 5, 1] = @class.Students[i].Email;
                    sheet.Cells[i + 5, 2] = @class.Students[i].Login;
                    sheet.Cells[i + 5, 3] = @class.Students[i].LastName + @class.Students[i].FirstName + @class.Students[i].Patronymic;
                    sheet.Cells[i + 5, 4] = @class.Students[i].PhoneNumber;
                }
                //жирный формат для строки (заголовков)
                sheet.get_Range("A4", $"M1").Font.Bold = true;
                //получаем диапазон сначала до последней записи списка
                Excel.Range oRng = sheet.get_Range("A1", $"M{@class.Students.Count + 1}");
                //делаем ячейки по размеру содержимого
                oRng.EntireColumn.AutoFit();
            });
        }

        //настройка эксель для вставки значений
        private Excel._Worksheet ExcelSettings(string name, int count)
        {
            Excel.Application app; //приложение
            Excel._Workbook book; //книга
            Excel._Worksheet sheet; //лист

            //запускаем приложение и устан-ем его видимсть
            app = new Excel.Application { Visible = true, UserControl = true };
            //создаём новую раб.книгу
            book = app.Workbooks.Add(Missing.Value);
            //устанавливаем активный лист новой книги с названием
            sheet = (Excel._Worksheet)book.ActiveSheet;
            sheet.Name = name;
            //жирный формат для первой строки (заголовков)
            sheet.get_Range("A1", $"AA1").Font.Bold = true;
            //вертикальная и горизонтальная ориентация по центру
            sheet.get_Range("A1", $"AA{count + 1}").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            sheet.get_Range("A1", $"AA{count + 1}").HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            //возвращаем лист эксель
            return sheet;
        }
    }
}
