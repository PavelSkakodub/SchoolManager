using System;
using System.Collections.Generic;
using System.Text;

namespace EF_School_DB_Managment.Models
{
    //основная инфа по ученику
    public class Student:User
    {
        //здесь все св-ва базового класса которые мигрируются в БД

        //связь 1 к 1 (доп. инфа)
        public BaseStudent BaseStudent { get; set; } 

        //связь многие к одному (классу)
        public int? ClassId { get; set; }
        public Class Class { get; set; }

        //связь 1 ко многим (урокам)
        public List<Lesson> Lessons { get; set; }
    }

    //дополнительная инфа по студенту
    public class BaseStudent
    {
        public int Id { get; set; } //id
        public string Adress { get; set; } //адрес
        public string SocialLink { get; set; } //ссылка на соц.сеть
        public string SchoolName { get; set; } //название школы
        public string ParentsPhone { get; set; } //номер родителей

        //связь 1 к 1 (ученику)
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
