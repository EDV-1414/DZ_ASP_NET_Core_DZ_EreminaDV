using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy2.Models;

namespace Academy2.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext(DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Academy2.Models.Direction> Directions { get; set; } = default!;
        public DbSet<Academy2.Models.Group> Groups { get; set; } = default!;
        public DbSet<Academy2.Models.Student> Students { get; set; } = default!;
        public DbSet<Academy2.Models.Teacher> Teachers { get; set; } = default!;
        public DbSet<Academy2.Models.Discipline> Disciplines { get; set; } = default!;

        // Настройка связей многие-ко-многим
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Связь Дисциплины - Направления (DisciplinesDirectionsRelation)
            modelBuilder.Entity<Discipline>()
                .HasMany(d => d.Directions)
                .WithMany(d => d.Disciplines)
                .UsingEntity<Dictionary<string, object>>(
                    "DisciplinesDirectionsRelation", // Имя вашей промежуточной таблицы в БД
                    j => j.HasOne<Direction>().WithMany().HasForeignKey("direction"), // Имя колонки в БД
                    j => j.HasOne<Discipline>().WithMany().HasForeignKey("discipline"), // Имя колонки в БД
                    j =>
                    {
                        j.ToTable("DisciplinesDirectionsRelation"); // Указываем имя таблицы
                        j.HasKey("discipline", "direction"); // Составной первичный ключ
                    });

            // 2. Связь Преподаватели - Дисциплины (TeachersDisciplinesRelation)
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Disciplines)
                .WithMany(d => d.Teachers)
                .UsingEntity<Dictionary<string, object>>(
                    "TeachersDisciplinesRelation", // Имя промежуточной таблицы в БД
                    j => j.HasOne<Discipline>().WithMany().HasForeignKey("discipline"), // Имя колонки
                    j => j.HasOne<Teacher>().WithMany().HasForeignKey("teacher"), // Имя колонки
                    j =>
                    {
                        j.ToTable("TeachersDisciplinesRelation");
                        j.HasKey("teacher", "discipline"); // Составной первичный ключ
                    });
        }
    }
}