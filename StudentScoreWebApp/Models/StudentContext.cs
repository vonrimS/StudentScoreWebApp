using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentScoreWebApp.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
    public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {          
            context.Students.Add(new Student { LastName = "Азарин", FirstName = "Кирилл", SecondName = "Георгиевич" });
            context.Students.Add(new Student { LastName = "Айвазян", FirstName = "Карен", SecondName = "Гарикович" });
            context.Students.Add(new Student { LastName = "Бефус", FirstName = "Полина", SecondName = "Олеговна" });
            context.Students.Add(new Student { LastName = "Говоров", FirstName = "Никита", SecondName = "Георгиевич" });
            context.Students.Add(new Student { LastName = "Яценко", FirstName = "Кирилл", SecondName = "Александрович" });
            context.Students.Add(new Student { LastName = "Горбунков", FirstName = "Семен", SecondName = "Сергеевич" });
            context.Students.Add(new Student { LastName = "Куйбышев", FirstName = "Кирилл", SecondName = "Борисович" });
            context.Students.Add(new Student { LastName = "Мурашко", FirstName = "Анна", SecondName = "Дмитриевна" });
            context.Students.Add(new Student { LastName = "Куценко", FirstName = "Дарья", SecondName = "Романовна" });
            context.Students.Add(new Student { LastName = "Лысин", FirstName = "Данил", SecondName = "Максимович" });
            context.Students.Add(new Student { LastName = "Яровой", FirstName = "Николай", SecondName = "Валентинович" });
            
            context.SaveChanges();            
        }
    }
}