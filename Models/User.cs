using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_School_DB_Managment.Models
{
    //класс с общим набором свойств (при рег-ии у всех одинаковые поля)
    public abstract class User
    {
        //обязательные к заполнению поля + макс.длина

        [Key]
        public int Id { get; set; } //id-идентификатор

        [MaxLength(30),Required]
        public string Login { get; set; } //логин

        [MaxLength(128), Required]
        public string HashPassword { get; set; } //хеш-пароля

        [MaxLength(30), Required]
        public string FirstName { get; set; } //имя

        [MaxLength(50), Required]
        public string LastName { get; set; } //фамилия

        [MaxLength(50), Required]
        public string Patronymic { get; set; } //отчество

        [MaxLength(40), Required]
        public string Email { get; set; } //емейл

        [MaxLength(20), Required]
        public string PhoneNumber { get; set; } //телефон

        [MaxLength(15), Required]
        public string Role { get; set; } //роль юзера

        [MaxLength(20), Required]
        public DateTime Birthday { get; set; } //дата рождения
    }
}
