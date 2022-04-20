using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EF_School_DB_Managment.Controllers
{
    //класс-помощник
    public static class Helper
    {
        //метод для преобразования пароля в хэш
        public static string HashPassword(string password)
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

        //метод для проверки пароля (сравнение с хэшем)
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer1, buffer2, src, dst;

            if (hashedPassword == null || password == null) 
            {
                return false;
            }
         
            src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }

            dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            buffer2 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer2, 0, 0x20);

            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer1 = bytes.GetBytes(0x20);
            }

            return buffer2.SequenceEqual(buffer1);
        }

        //проверка ввода TextBox с помощью заданного рег.выражения
        public static bool Validation(TextBox box,string regex, string error)
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

    }
}
