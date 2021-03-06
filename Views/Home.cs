using EF_School_DB_Managment.Controllers;
using EF_School_DB_Managment.Models;
using EF_School_DB_Managment.Views;
using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EF_School_DB_Managment
{
    public partial class HomePage : Form
    {
        //менеджер для работы с пользователями
        private readonly UserManager manager = new UserManager();

        //регулярные выражения для валидации
        const string EmailRegex = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)"; //емейл адрес с @ и доменом после него
        const string PhoneRegex = @"^([\+]?(?:00)?[0-9]{1,3}[\s.-]?[0-9]{1,12})([\s.-]?[0-9]{1,4}?)$"; //номер телефона в разных форматах
        const string LoginRegex = @"^[A-Z][a-zA-Z0-9-_\.]{4,20}$"; //мин. 4 символа, первая прописная, можно цифры
        const string PasswordRegex = @"^(?=.{6,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$"; //мин.6 символов,1 прописная и 1 цифра

        //коды регистрации для пользователей
        const int StudentCode = 123;
        const int TeacherCode = 456;
        const int AdminCode =   789;

        public HomePage()
        {
            InitializeComponent();
        }

        //изменение надписи при выборе роли в регистрации
        private void UserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrationCodeLabel.Text = "Код регистрации для " + UserRole.SelectedItem;
        }

        //метод для преобразования пароля в хэш
        private string HashPassword(string password)
        {
            byte[] salt, buffer;

            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer = bytes.GetBytes(0x20);
            }

            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer, 0, dst, 0x11, 0x20);

            return Convert.ToBase64String(dst);
        }

        //проверка ввода TextBox с помощью заданного рег.выражения
        private bool Validation(TextBox box, string regex, string error)
        {
            //если проверка не прошла 
            if (!Regex.IsMatch(box.Text, regex))
            {
                box.Text = ""; //очищаем введенный текст
                box.PlaceholderText = error; //задаём подсказку об ошибке
                return false; //проверка не пройдена
            }
            return true; //проверка пройдена
        }

        // регистрация пользователя
        private async void SignUp_Click(object sender, EventArgs e)
        {
            SignUp.Enabled = false; //откл. кнопки

            try
            {
                if (IsValid()) //если данные валидны
                {
                    //если указ-ый емейл уже зареган - ошибка
                    if (await manager.GetUserByEmailAsync(Email.Text) != null)
                    {
                        MessageBox.Show("Пользователь с таким емейлом уже зарегестрирован", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        SignUp.Enabled = true; //вкл.кнопки
                        return;
                    }
                    else //если юзер новый
                    {
                        //добавляем юзера в БД исходя из его кода(тоже что и роль)
                        switch (int.Parse(CodeRegistration.Text))
                        {
                            case StudentCode:
                                if (UserRole.SelectedItem.ToString() == "Ученик")
                                {
                                    //инициализируем объект ученика и создаём пустые связи
                                    Student student = new Student() { BaseStudent = new BaseStudent() };
                                    SetUserData(student);
                                    //добавляем юзера в БД
                                    await manager.CreateUserAsync(student);
                                    //открываем форму с данными ученика
                                    StudentPage spage = new StudentPage(student);
                                    Hide(); //скрываем эту форму
                                    spage.ShowDialog();
                                }
                                else MessageBox.Show("Код регистрации отличается от выбранной роли", "Регистрация ученика", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                break;

                            case TeacherCode:
                                if (UserRole.SelectedItem.ToString() == "Учитель") 
                                {
                                    //инициализируем объект учителя и создаём пустые связи
                                    Teacher teacher = new Teacher() { BaseTeacher = new BaseTeacher() };
                                    SetUserData(teacher);
                                    //добавляем юзера в БД
                                    await manager.CreateUserAsync(teacher);
                                    //открываем форму с данными учителя
                                    TeacherPage tpage = new TeacherPage(teacher);
                                    Hide(); //скрываем эту форму
                                    tpage.ShowDialog();
                                }
                                else MessageBox.Show("Код регистрации отличается от выбранной роли", "Регистрация учителя", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                break;

                            case AdminCode:
                                if (UserRole.SelectedItem.ToString() == "Админ")
                                {
                                    //инициализируем объект учителя и создаём пустые связи
                                    Admin admin = new Admin();
                                    SetUserData(admin);
                                    //добавляем юзера в БД
                                    await manager.CreateUserAsync(admin);
                                    //открываем форму с данными админа
                                    AdminPage apage = new AdminPage(admin);
                                    Hide(); //скрываем эту форму
                                    apage.ShowDialog();
                                }
                                else MessageBox.Show("Код регистрации отличается от выбранной роли", "Регистрация админа", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                break;
                        }
                    }
                }
                else { MessageBox.Show("Невалидные данные, исправьте значения и повторите.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
            }
            catch
            {
                MessageBox.Show("Некоторые поля заполнены некорректно.\nПосмотрите подсказку (сверху).", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SignUp.Enabled = true; //вкл.кнопки
        }

        //авторизация пользователя
        private async void SignIn_Click(object sender, EventArgs e)
        {
            SignIn.Enabled = false; //откл. кнопки

            //если поля авторизации не пустые
            if (login_log.Text.Trim().Length != 0 && login_pas.Text.Trim().Length != 0)
            {
                //возвращаем роль авторизов-го юзера
                string authUserRole = await manager.AuthorizeAsync(login_log.Text, login_pas.Text);
                //исходя из роли - входим в своё место
                switch (authUserRole)
                {
                    case "Student":
                        //получаем авториз-го ученика и переходим в его форму
                        var student = await manager.GetStudentAsync(login_log.Text);
                        StudentPage spage = new StudentPage(student);
                        Hide(); //скрываем эту форму
                        spage.ShowDialog();                       
                        break;

                    case "Teacher":
                        //получаем авториз-го учителя и переходим в его форму
                        var teacher = await manager.GetTeacherAsync(login_log.Text);
                        TeacherPage tpage = new TeacherPage(teacher);
                        Hide(); //скрываем эту форму
                        tpage.ShowDialog();
                        break;

                    case "Admin":
                        //получаем авториз-го админа и переходим в его форму
                        var admin = await manager.GetAdminAsync(login_log.Text);
                        AdminPage apage = new AdminPage(admin);
                        Hide(); //скрываем эту форму
                        apage.ShowDialog(); 
                        break;

                    default:
                        MessageBox.Show("Неверный емейл или пароль");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль от своего аккаунта", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SignIn.Enabled = true; //вкл. кнопки
        }
                
        //установка данных для юзера (любого)
        private void SetUserData(User user)
        {
            user.FirstName = firstName.Text;
            user.LastName = lastName.Text;
            user.Patronymic = patronymic.Text;
            user.Login = register_log.Text;
            user.HashPassword = HashPassword(register_pas.Text);
            user.PhoneNumber = PhoneNumber.Text;
            user.Email = Email.Text;
            user.Birthday = birthday.Value;
            user.Role = UserRole.SelectedItem.ToString();
        }

        //метод проверки данных всех полей ввода
        private bool IsValid()
        {
            bool fName, lName, patronym, birth, code, role; //флаги проверки полей 
            bool login, password, phone, email; //флаги валидации 
            int buf = int.Parse(CodeRegistration.Text); //введённый код

            //проверка на пустые и некорректные поля
            fName = firstName.Text.Trim().Length != 0; //false - если пустое поле
            lName = lastName.Text.Trim().Length != 0; //false - если пустое поле
            patronym = patronymic.Text.Trim().Length != 0; //false - если пустое поле
            birth = birthday.Value <= DateTime.Today; //false - если ДР в будущем
            code = buf == StudentCode || buf == TeacherCode || buf == AdminCode; //false - если ни один код не подходит
            role = UserRole.SelectedItem != null; //false - если не выбран элемент

            //валидация полей ввода регистрационных д-ых (с подсказкой об ошибке)
            password = Validation(register_pas, PasswordRegex, "Неверный формат");
            login = Validation(register_log, LoginRegex, "Неверный формат");
            phone = Validation(PhoneNumber, PhoneRegex, "Неверный формат");
            email = Validation(Email, EmailRegex, "Неверный формат");

            //если пароли совпадают
            if (register_pas.Text == confirm_pas.Text)
            {
                //если все данные валидны
                if (fName && lName && patronym && birth && code && role && password && login && phone && email)
                {
                    return true; //валидные данные
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            return false; //в остальных случаях невалид
        }

        //кнопка с отображением подсказки
        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Формат вводимых данных: \n\n" +
                "*Логин - первая прописная, мин. 4 сим., можно цифры\n" +
                "*Пароль - первая прописная, мин.6 сим. + цифры\n" +
                "*Емейл - символы до @ и после (домен)\n" +
                "*Телефон - только цифры, начало можно с '+' или 0\n" +
                "*Дата рождения - вчерашняя дата и раньше\n" +
                "*Код регистрации - уникальный код для каждой роли\n\n" +
                "> Фамилия - максимум 50 символов\n" +
                "> Имя - максимум 30 символов\n" +
                "> Отчество - максимум 50 символов\n" +
                "> Логин - максимум 30 символов\n" +
                "> Емейл - максимум 40 символов\n" +
                "> Телефон - максимум 20 символов", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
