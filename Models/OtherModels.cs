using System;
using System.Collections.Generic;
using System.Text;

namespace EF_School_DB_Managment.Models
{
    //класс Класс учеников
    public class Class
    {
        public int Id { get; set; } //id
        public string Name { get; set; } //название класса
        public string HeadMan { get; set; } //староста
        public string ClassTeacher { get; set; } //класс.руководитель

        //свзь 1 к 1 (учитель)
        public Teacher Teacher { get; set; }

        //связь 1 ко многим (ученикам)
        public List<Student> Students { get; set; }

        //связь 1 к многим (расписанию)
        public List<TimeTable> TimeTable { get; set; }
    }

    //класс урока
    public class Lesson
    {
        public int Id { get; set; } //айди
        public string Subject { get; set; } //предмет
        public DateTime Date{ get; set; } //дата урока
        public sbyte Rate { get; set; } //оценка
        public string Comment { get; set; } //комментарий
        public string HomeWork { get; set; } //ДЗ

        //связь 1 к многим (студенту)
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }

    //класс расписание
    public class TimeTable
    {
        public int Id { get; set; } //айди
        public sbyte NumberLesson { get; set; } //номер урока
        public DateTime BeginTime { get; set; } //начало урока
        public DateTime EndTime { get; set; } //конец урока
        public string Subject { get; set; } //предмет
        public sbyte DayOfWeek { get; set; } //день недели

        //связь многие к одному (учителю)
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        //связь многие к одному (классу)
        public int? ClassId { get; set; }
        public Class Class { get; set; }
    }
}
