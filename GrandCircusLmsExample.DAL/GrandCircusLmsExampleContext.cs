using GrandCircusLmsExample.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircusLmsExample.DAL
{
    public class GrandCircusLmsExampleContext : DbContext
    {
        public GrandCircusLmsExampleContext()
        {

        }

        public GrandCircusLmsExampleContext(DbContextOptions<GrandCircusLmsExampleContext> options) : base(options)
        {

        }

        public virtual DbSet<Course> Courses {get; set;}
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LAPTOP-0FFESSLQ\\SQLEXPRESS;Initial Catalog=GrandCircusLmsDatabase;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasOne<Student>(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);
            modelBuilder.Entity<Enrollment>()
                .HasOne<Course>(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);
            modelBuilder.Entity<Course>()
                .HasOne<Location>(c => c.Location)
                .WithMany(l => l.Courses)
                .HasForeignKey(c => c.LocationId);
            modelBuilder.Entity<InstructorCourse>()
                .HasOne<Instructor>(ic => ic.Instructor)
                .WithMany(i => i.InstructorCourses)
                .HasForeignKey(ic => ic.InstructorId);
            modelBuilder.Entity<InstructorCourse>()
                .HasOne<Course>(c => c.Course)
                .WithMany(i => i.InstructorCourses)
                .HasForeignKey(i => i.CourseId);

            Seed(modelBuilder);
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasData(( new Student[] {
                new Student()
                {
                    Id = 1,
                    FirstName = "Jake",
                    LastName = "Collins",
                    DateOfBirth = new DateTime(1995, 10, 14),
                    GCIdentificationNumbe = "12001",
                    CreatedDate = DateTime.Today,
                    LastUpdatedDate = DateTime.Today,
                    DeclaredMajor = "Computer Science"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Austin",
                    LastName = "Powel",
                    DateOfBirth = new DateTime(1994, 6, 30),
                    GCIdentificationNumbe = "12002",
                    CreatedDate = DateTime.Today,
                    LastUpdatedDate = DateTime.Today,
                    DeclaredMajor = "Computer Science"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Dylan",
                    LastName = "Rule",
                    DateOfBirth = new DateTime(1998, 8, 2),
                    GCIdentificationNumbe = "12003",
                    CreatedDate = DateTime.Today,
                    LastUpdatedDate = DateTime.Today,
                    DeclaredMajor = "Computer Science"
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Andrew",
                    LastName = "Waltman",
                    DateOfBirth = new DateTime(1997, 4, 6),
                    GCIdentificationNumbe = "12004",
                    CreatedDate = DateTime.Today,
                    LastUpdatedDate = DateTime.Today,
                    DeclaredMajor = "Computer Science"
                }
                }
                ));
            modelBuilder.Entity<Instructor>()
                .HasData((new Instructor[]
                {
                    new Instructor()
                    {
                        FirstName = "Sean",
                        LastName = "Armstrong",
                        DateOfBirth = new DateTime(1984, 11, 24),
                        GCIdentificationNumbe = "101",
                        OfficeNumber = "A1",
                        Id = 1,
                        CreatedDate = DateTime.Today,
                        LastUpdatedDate = DateTime.Today
                    },
                    new Instructor()
                    {
                        FirstName = "Albert",
                        LastName = "Ngoudjou",
                        DateOfBirth = new DateTime(1986, 7, 4),
                        GCIdentificationNumbe = "102",
                        OfficeNumber = "C3",
                        Id = 2,
                        CreatedDate = DateTime.Today,
                        LastUpdatedDate = DateTime.Today
                    },
                    new Instructor()
                    {
                        FirstName = "Tommy",
                        LastName = "Waalkes",
                        DateOfBirth = new DateTime(1991, 4, 16),
                        GCIdentificationNumbe = "102",
                        OfficeNumber = "AA5",
                        Id = 3,
                        CreatedDate = DateTime.Today,
                        LastUpdatedDate = DateTime.Today
                    }
                }));
            modelBuilder.Entity<Location>()
                .HasData(new Location
                {
                    Name = "Start Garden",
                    Address = "40 Pearl St NW",
                    City = "Grand Rapids",
                    State = "Michigan",
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now
                });
            modelBuilder.Entity<Course>()
                .HasData((new Course[]
                {
                    new Course
                    {
                        Name = "C# Back-end",
                        Credits = 4,
                        LocationId = 1,
                        Id = 1,
                        CreatedDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    },
                    new Course
                    {
                        Name = "Coolest Front End Ever",
                        Credits = 3,
                        LocationId = 1,
                        Id = 2,
                        CreatedDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    }
                }));
            modelBuilder.Entity<Enrollment>()
                .HasData((new Enrollment[]
                {
                    new Enrollment
                    {
                        StudentId = 1,
                        CourseId = 1,
                        Id = 1,
                        CreatedDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    },
                    new Enrollment
                    {
                        StudentId = 2,
                        CourseId = 1,
                        Id = 2,
                        CreatedDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    },
                    new Enrollment
                    {
                        StudentId = 3,
                        CourseId = 1,
                        Id = 3,
                        CreatedDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    },
                    new Enrollment
                    {
                        StudentId = 4,
                        CourseId = 1,
                        Id = 4,
                        CreatedDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    }
                }));
        }
    }
}
