using EF_School_DB_Managment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_School_DB_Managment.Controllers
{
    //класс управления пользователями
    public class UserManager
    {
        //конструктор
        public UserManager() { }

        #region Authorization

        //добавление юзера в БД
        public async Task CreateUserAsync(object user)
        {
            //исп-уем контекст БД
            using var context = new SchoolDbContext();

            //добавляем в БД исходя из названия типа объекта
            switch (user.GetType().Name)
            {
                case "Student":
                    await context.Students.AddAsync((Student)user);
                    break;
                case "Teacher":
                    await context.Teachers.AddAsync((Teacher)user);
                    break;
                case "Admin":
                    await context.Admins.AddAsync((Admin)user);
                    break;
            }

            //сохраняем изменения в БД
            await context.SaveChangesAsync();
        }

        //получение любого пользователя по емейлу
        public async Task<object> GetUserByEmailAsync(string email)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //ищем объект по емейлу в каждой таблице
            object student = await GetStudentAsync(email);
            object teacher = await GetTeacherAsync(email);
            object admin = await GetAdminAsync(email);

            //если юзер сущ-ет - возвращаем его иначе null
            return student ?? teacher ?? admin;
        }

        //проверка авторизации и возврат роли юзера
        public async Task<string> AuthorizeAsync(string email, string password)
        {
            //получаем юзера
            var user = (User)await GetUserByEmailAsync(email);

            //проверяем хеш юзера и возвращаем роль юзера (название класса) - иначе нулл
            if (user != null && Helper.VerifyHashedPassword(user.HashPassword, password))
                return user.GetType().Name;
            else
                return null;
        }
        #endregion

        #region Student

        //получение ученика по емейлу
        public async Task<Student> GetStudentAsync(string email)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //ищем ученика по емейлу
            var user = await context.Students.Include(x => x.Class).FirstOrDefaultAsync(x => x.Email == email);
            //возвращаем найденного юзера или нулл
            return user; 
        }
        
        //получение всех связ-ых данных ученика
        public async Task<Student> GetStudentAllAsync(string email)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем ученика с связанными данными
            var user = await context.Students
                .Include(x => x.BaseStudent)
                .Include(x => x.Class)
                .Include(x => x.Class.TimeTable)
                .FirstOrDefaultAsync(x => x.Email == email);
            //возвращаем юзера
            return user;
        }

        //получение списка учеников
        public async Task<List<Student>> GetStudentsListAsync()
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем список
            var user = await context.Students
                .Include(x => x.BaseStudent)
                .Include(x => x.Class)
                .ToListAsync();
                
            //возвращаем список
            return user;
        }

        //обновление данных ученика(тех,кот-е можно изменить)
        public async Task<bool> UpdateStudentAsync(Student student)
        {
            try
            {
                //исп-уем контекст БД
                using var context = new SchoolDbContext();
                //получаем юзера с его доп. данными
                var user = await context.Students.Include(x => x.BaseStudent).FirstOrDefaultAsync(x => x.Email == student.Email);

                //изменение данных юзера
                user.Login = student.Login;
                user.PhoneNumber = student.PhoneNumber;
                user.Birthday = student.Birthday;
                user.BaseStudent.SchoolName = student.BaseStudent.SchoolName;
                user.BaseStudent.Adress = student.BaseStudent.Adress;
                user.BaseStudent.ParentsPhone = student.BaseStudent.ParentsPhone;
                user.BaseStudent.SocialLink = student.BaseStudent.SocialLink;
                //сохранение данных в БД
                await context.SaveChangesAsync();
                //возврат успеха
                return true;
            }
            catch
            {
                return false;
            }
        }

        //получаем список уроков за указ-ую дату
        public async Task<List<Lesson>> GetLessonByDateAsync(int id, DateTime date)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем список уроков за указ-ую дату в указ-ом классе
            var lessons = await context.Lessons
                .Where(x => x.Date.Date == date && x.ClassId == id)
                .OrderBy(x => x.Subject)
                .ToListAsync();
            //возвращаем список уроков
            return lessons;
        }

        //получение списка оценок за указ-ую дату
        public async Task<List<Rating>> GetRatingsByDateAsync(int id, DateTime date)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем список уроков за указ-ую дату в указ-ом классе
            var ratings = await context.Ratings.Where(x => x.Date.Date == date && x.StudentId == id).ToListAsync();               
            //возвращаем список оценок
            return ratings;
        }

        //получение средней оценки по предмету
        public async Task<float> GetAverageBySubjectAsync(int id, string subject, DateTime begin, DateTime end)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //делаем выборку по студенту и предмету в указ-ом диапазоне дат и возвращаем ср.значение
            var avg = await context.Ratings
                .Where(x => x.StudentId == id && x.Subject == subject && x.Date.Date >= begin.Date && x.Date.Date <= end.Date)
                .AverageAsync(x => x.Rate);
            return (float)avg;
        }

        //экспорт успеваемости ученика в эксель
        public async void ExportRatingToExcelAsync(int id, DateTime begin, DateTime end)
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем список оценок в диапазоне дат
            var ratings = await context.Ratings
                .Where(x => x.Date.Date >= begin && x.Date.Date <= end && x.StudentId == id)
                .OrderByDescending(x => x.Date)
                .ToListAsync();

            await Task.Run(() =>
            {
                //получаем текущий лист эксель
                var sheet = Admin.ExcelSettings("Успеваемость", ratings.Count);
                sheet.Cells[1, 1] = "Дата урока";
                sheet.Cells[1, 2] = "Предмет";
                sheet.Cells[1, 3] = "Оценка";
                sheet.Cells[1, 4] = "Комментарий";
                //выводим все значения
                for (int i = 0; i < ratings.Count; i++)
                {
                    sheet.Cells[i + 2, 1] = ratings[i].Date.Date.ToString("d");
                    sheet.Cells[i + 2, 2] = ratings[i].Subject;
                    sheet.Cells[i + 2, 3] = ratings[i].Rate.ToString();
                    sheet.Cells[i + 2, 4] = ratings[i].Comment;
                }

                //жирный формат для строки (заголовков)
                sheet.get_Range("A1", $"F1").Font.Bold = true;
                //получаем диапазон сначала до последней записи списка
                Microsoft.Office.Interop.Excel.Range oRng = sheet.get_Range("A1", $"F{ratings.Count + 1}");
                //делаем ячейки по размеру содержимого
                oRng.EntireColumn.AutoFit();
            });
        }
        #endregion

        #region Teacher

        //получение учителя по емейлу
        public async Task<Teacher> GetTeacherAsync(string email)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //ищем учителя по емейлу
            var user = await context.Teachers.FirstOrDefaultAsync(x => x.Email == email);
            //возвращаем найденного юзера или нулл
            return user; 
        }

        //получение всех связ-ых данных учителя
        public async Task<Teacher> GetTeacherAllAsync(string email)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем юзера с связанными данными
            var user = await context.Teachers
                .Include(x => x.BaseTeacher)
                .Include(x => x.Class)
                .Include(x => x.TimeTable)
                .FirstOrDefaultAsync(x => x.Email == email);
            //возвращаем юзера
            return user;
        }

        //обновление данных учителя (тех,кот-е можно изменить)
        public async Task<bool> UpdateTeacherAsync(Teacher teacher)
        {
            try
            {
                //исп-уем контекст БД
                using var context = new SchoolDbContext();
                
                //извлекаем только осн. и доп. данные юзера
                var user = await context.Teachers
                    .Include(x => x.BaseTeacher)                    
                    .FirstOrDefaultAsync(x => x.Email == teacher.Email);

                //изменение данных юзера
                user.Login = teacher.Login;
                user.PhoneNumber = teacher.PhoneNumber;
                user.Birthday = teacher.Birthday;
                user.BaseTeacher.Adress = teacher.BaseTeacher.Adress;
                user.BaseTeacher.SchoolName = teacher.BaseTeacher.SchoolName;
                //сохранение данных в БД
                await context.SaveChangesAsync();
                //возврат успеха
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        //добавление оценки ученику
        public async Task<bool> SetRateStudentAsync(string email, Rating rate)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем ученика с оценками
            var student = await context.Students.Include(x => x.Ratings).FirstOrDefaultAsync(x => x.Email == email);
            //ищем урок с такой же датой и предметом что у оценки
            var lesson = context.Lessons.Where(x => x.ClassId == student.ClassId).FirstOrDefault(x => x.Date.Date == rate.Date && x.Subject == rate.Subject);
            //если урок сущ-ует, можно поставить за него оценку
            if (lesson != null)
            {
                //добавляем оценку
                student.Ratings.Add(rate);
                //сохраняем изменения
                await context.SaveChangesAsync();
                return true;
            }
            else return false;
        }

        //добавление оценки ученику (нельзя передать сразу объект т.к Id будет один-ым)
        public async Task<bool> SetRateClassAsync(int id, string subject, sbyte rate, DateTime date, string comment)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем учеников из класса
            var students = await context.Students.Include(x => x.Ratings).Where(x => x.ClassId == id).ToListAsync(); ;
            //ищем урок с такой же датой и предметом что у оценки
            var lesson = context.Lessons.Where(x => x.ClassId == id).FirstOrDefault(x => x.Date.Date == date.Date && x.Subject == subject);
            //если в этот день есть урок
            if (lesson != null)
            {
                //добавляем всем оценку новую
                foreach (var s in students) s.Ratings.Add(new Rating()
                {
                    Subject = subject,
                    Rate = rate,
                    Comment = comment,
                    Date = date,
                });
                //сохраняем изменения
                await context.SaveChangesAsync();
                return true;
            }
            else return false;
        }

        //создание урока
        public async Task<bool> CreateLessonAsync(string name, Lesson lesson)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем учеников из класса с связ-ми данными
            var @class = await context.Classes.Include(x => x.Lessons).Where(x => x.Name == name).FirstOrDefaultAsync();
            //проверяем что нет одинаковых уроков (раз.предметы можно)
            if (@class.Lessons.Where(x => x.Subject == lesson.Subject).FirstOrDefault(x => x.Date.Date == lesson.Date.Date) != null) return false; 
            else
            {
                //добавляем урок
                @class.Lessons.Add(lesson);
                //сохраняем изменения
                await context.SaveChangesAsync();
                return true;
            }
        }

        //получение списка учителей
        public async Task<List<Teacher>> GetTeacherListAsync()
        {
            //используем контекст БД 
            using var context = new SchoolDbContext();
            //получаем список учителей
            var teachers = await context.Teachers
                .Include(x => x.BaseTeacher)
                .Include(x => x.Class)
                .ToListAsync();

            //возвращаем cgbcjr
            return teachers;
        }
        #endregion

        #region Admin

        //получение админа по емейлу
        public async Task<Admin> GetAdminAsync(string email)
        {
            using var context = new SchoolDbContext(); //исп-уем контекст БД
            var user = await context.Admins.FirstOrDefaultAsync(x => x.Email == email); //ищем юзера по емейлу
            return user; //возвращаем найденного юзера или нулл
        }


        //получение класса по имени
        public async Task<Class> GetClassAsync(string name)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //ищем класс по его названию
            var @class = await context.Classes.Include(x => x.Students).FirstOrDefaultAsync(x => x.Name == name);
            //возвращаем найденный клас или нулл
            return @class;
        }

        //получение класса по имени
        public async Task<Class> GetClassAllAsync(string name)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем класс с связанными данными
            var @class = await context.Classes
                .Include(x => x.Students)
                .Include(x => x.Teacher)
                .Include(x => x.TimeTable)
                .FirstOrDefaultAsync(x => x.Name == name);
            //возвращаем найденный клас или нулл
            return @class;
        }

        //получение класса с расписанием
        public async Task<Class> GetClassTimeTableAsync(string name)
        {
            //используем контекст БД
            var context = new SchoolDbContext();
            //получаем класс с его расписанием
            var @class = await context.Classes.Include(x => x.TimeTable).FirstOrDefaultAsync(x => x.Name == name);
            //возвращаем найденный клас или нулл
            return @class;
        }
        #endregion
    }
}
