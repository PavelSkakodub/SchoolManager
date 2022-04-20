using System;
using System.Collections.Generic;
using System.Text;

namespace EF_School_DB_Managment.Models
{
    //основная инфа по учителю
    public class Teacher:User
    {
        //здесь все св-ва базового класса которые мигрируются в БД

        //связь 1 к 1 (доп. инфа)
        public BaseTeacher BaseTeacher { get; set; }

        //связь 1 к 1 (классу)
        public int? ClassId { get; set; }
        public Class Class { get; set; }

        //связь 1 к многим (расписанию)
        public List<TimeTable> TimeTable { get; set; } 
    }

    //дополнительная инфа по учителю
    public class BaseTeacher
    {
        public int Id { get; set; } //id
        public string Adress { get; set; } //адрес
        public string SchoolName { get; set; } //название школы
        public string Subject { get; set; } //предмет
        public ushort Salary { get; set; } //зарплата
        public sbyte HoursPerWeek { get; set; } //кол-во часов в неделю
        public sbyte Cabinet { get; set; } //кабинет
        public sbyte Exp { get; set; } //стаж

        //связь 1 к 1 (учителю)
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
