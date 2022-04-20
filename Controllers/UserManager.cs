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

            //проверяем хеш юзера и возвращаем роль юзера - иначе нулл
            if (user != null && Helper.VerifyHashedPassword(user.HashPassword, password))
                return user.Role;
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
                .Include(x => x.Lessons)
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
        public async Task SetRateStudentAsync(string email, Lesson lesson)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем ученика с оценками
            var student = await context.Students.Include(x => x.Lessons).FirstOrDefaultAsync(x => x.Email == email);
            //добавляем оценку
            student.Lessons.Add(lesson);
            //сохраняем изменения
            await context.SaveChangesAsync();
        }

        //добавление оценки ученику (нельзя передать сразу объект т.к Id будет один-ым)
        public async Task SetRateClassAsync(int id, string subject, sbyte rate, DateTime date, string comment)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем учеников из класса
            var students = await context.Students.Include(x => x.Lessons).Where(x => x.ClassId == id).ToListAsync(); ;
            //добавляем всем оценку новую
            foreach (var s in students) s.Lessons.Add(new Lesson()
            {
                Subject = subject,
                Rate =rate,
                Comment = comment,
                Date = date,
                
            });            
            //сохраняем изменения
            await context.SaveChangesAsync();
        }

        //создание урока
        public async Task CreateLessonAsync(int id, Lesson lesson)
        {
            //используем контекст БД
            using var context = new SchoolDbContext();
            //получаем учеников из класса с связ-ми данными
            var students = await context.Students.Include(x => x.Lessons).Where(x => x.ClassId == id).ToListAsync();
            //добавляем урок
            foreach(var s in students) s.Lessons.Add(lesson);
            //сохраняем изменения
            await context.SaveChangesAsync();
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
