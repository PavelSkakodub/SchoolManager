using EF_School_DB_Managment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_School_DB_Managment.Controllers
{
    public class SchoolDbContext : DbContext
    {
        //основные таблицы в БД
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        //связанные таблицы в БД
        public DbSet<Class> Classes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }

        //настройки приложения (строка подключения в д.случае)
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=SchoolDatabase;Trusted_Connection=true");
        }

        //настройки моделей
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //подключение настроек из других классов
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new BaseStudentConfiguration());
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new BaseTeacherConfiguration());
            builder.ApplyConfiguration(new TimeTableConfiguration());
            builder.ApplyConfiguration(new LessonConfiguration());
            builder.ApplyConfiguration(new RatingConfiguration());
        }

        //настройки модели Student в отдельном классе
        public class StudentConfiguration : IEntityTypeConfiguration<Student>
        {
            //настройки модели с пом-ю FluentApi
            public void Configure(EntityTypeBuilder<Student> builder)
            {              
                //уник.индекс, повторение д-ых запрещено
                builder.HasAlternateKey(x => x.Email);

                builder //связь 1 к 1 (осн.инфа к доп.)
                    .HasOne(x => x.BaseStudent)
                    .WithOne(x => x.Student) 
                    .HasForeignKey<BaseStudent>(x => x.StudentId)
                    .OnDelete(DeleteBehavior.Cascade); 

                builder //связь 1 к многим (уч. к классу)
                    .HasOne(x => x.Class)
                    .WithMany(x => x.Students)
                    .HasForeignKey(x => x.ClassId) 
                    .OnDelete(DeleteBehavior.SetNull);
            }
        }

        //настройки модели BaseStudent в отдельном классе
        public class BaseStudentConfiguration : IEntityTypeConfiguration<BaseStudent>
        {
            //настройки модели с пом-ю FluentApi
            public void Configure(EntityTypeBuilder<BaseStudent> builder)
            {
                //задаём название таблицы (только в БД)
                builder.ToTable("InfoByStudent");

                //значения по умолчанию
                builder.Property(x => x.SchoolName).HasDefaultValue("");
                builder.Property(x => x.Adress).HasDefaultValue("Россия");
                builder.Property(x => x.ParentsPhone).HasDefaultValue("");
                builder.Property(x => x.SocialLink).HasDefaultValue("https://");
            }
        }

        //настройки модели Class в отдельном классе
        public class ClassConfiguration : IEntityTypeConfiguration<Class>
        {
            //настройки модели с пом-ю FluentApi
            public void Configure(EntityTypeBuilder<Class> builder)
            {
                //макс.длина + знач. по умолчанию
                builder.Property(x => x.Name).HasMaxLength(10).HasDefaultValue("");
                builder.Property(x => x.ClassTeacher).HasMaxLength(150).HasDefaultValue("");
                builder.Property(x => x.HeadMan).HasMaxLength(150).HasDefaultValue("");

                builder //связь 1 к многим (у класса список расписание)
                    .HasMany(x => x.TimeTable)
                    .WithOne(x => x.Class)
                    .HasForeignKey(x => x.ClassId)
                    .OnDelete(DeleteBehavior.Cascade);

                builder //связь 1 к многим (оценки к ученику)
                    .HasMany(x => x.Lessons)
                    .WithOne(x => x.Class)
                    .HasForeignKey(x => x.ClassId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }

        //настройки модели Teacher в отдельном классе
        public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
        {
            public void Configure(EntityTypeBuilder<Teacher> builder)
            {
                //уник.индекс, повторение д-ых запрещено
                builder.HasAlternateKey(x => x.Email);

                builder //связь 1 к 1 (уч. к классу)
                    .HasOne(x => x.Class)
                    .WithOne(x => x.Teacher)
                    .HasForeignKey<Teacher>(x => x.ClassId)
                    .OnDelete(DeleteBehavior.Restrict);

                builder //связь 1 к многим (у учителя список расписание)
                    .HasMany(x => x.TimeTable)
                    .WithOne(x => x.Teacher)
                    .HasForeignKey(x => x.TeacherId)
                    .OnDelete(DeleteBehavior.Restrict);
            }
        }

        //настройки модели Lesson в отдельном классе
        public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
        {
            //настройки модели с пом-ю FluentApi
            public void Configure(EntityTypeBuilder<Lesson> builder)
            {
                //составной индекс по дате и айди класса
                builder.HasIndex(x => new { x.ClassId, x.Date });
                //макс.длина + знач. по умолчанию
                builder.Property(x => x.Subject).HasMaxLength(25).HasDefaultValue("");
                builder.Property(x => x.HomeWork).HasMaxLength(200).HasDefaultValue("");
                //тип только дата
                builder.Property(x => x.Date).HasColumnType("date");
            }
        }

        //настройки модели Rating в отдельном классе
        public class RatingConfiguration : IEntityTypeConfiguration<Rating>
        {
            //настройки модели с пом-ю FluentApi
            public void Configure(EntityTypeBuilder<Rating> builder)
            {
                //составной индекс по дате и айди ученика
                builder.HasIndex(x => new { x.StudentId, x.Date });
                //макс.длина + знач. по умолчанию
                builder.Property(x => x.Subject).HasMaxLength(25).HasDefaultValue("");
                builder.Property(x => x.Comment).HasMaxLength(200).HasDefaultValue("");
                builder.Property(x => x.Rate).HasMaxLength(13).HasDefaultValue(0);
                //тип только дата
                builder.Property(x => x.Date).HasColumnType("date");
            }
        }

        //настройки модели BaseStudent в отдельном классе
        public class BaseTeacherConfiguration : IEntityTypeConfiguration<BaseTeacher>
        {
            //настройки модели с пом-ю FluentApi
            public void Configure(EntityTypeBuilder<BaseTeacher> builder)
            {
                //задаём название таблицы (только в БД)
                builder.ToTable("InfoByTeacher");

                //макс.длина + знач. по умолчанию
                builder.Property(x => x.SchoolName).HasDefaultValue("");
                builder.Property(x => x.Adress).HasDefaultValue("Россия");
                builder.Property(x => x.Subject).HasMaxLength(20).HasDefaultValue("");
                builder.Property(x => x.Salary).HasMaxLength(200000).HasDefaultValue(0);
                builder.Property(x => x.Cabinet).HasMaxLength(1000).HasDefaultValue(0);
                builder.Property(x => x.HoursPerWeek).HasMaxLength(50).HasDefaultValue(40);
                builder.Property(x => x.Exp).HasMaxLength(75).HasDefaultValue(0);
            }
        }

        //настройки модели TimeTable в отдельном классе
        public class TimeTableConfiguration : IEntityTypeConfiguration<TimeTable>
        {
            public void Configure(EntityTypeBuilder<TimeTable> builder)
            {
                //индекс по колонке дни недели
                builder.HasIndex(x => x.DayOfWeek);
                //макс.длина + знач. по умолчанию
                builder.Property(x => x.NumberLesson).HasMaxLength(8).HasDefaultValue(0);
                builder.Property(x => x.DayOfWeek).HasMaxLength(7).HasDefaultValue(0);
                builder.Property(x => x.Subject).HasMaxLength(25).HasDefaultValue("");
                builder.Property(x => x.BeginTime).HasDefaultValue(System.DateTime.Now);
                builder.Property(x => x.EndTime).HasDefaultValue(System.DateTime.Now.AddMinutes(45));
            }
        }
    }
}
