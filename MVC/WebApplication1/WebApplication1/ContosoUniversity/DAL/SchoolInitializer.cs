using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        /// <summary>
        /// Seed数据库初始化
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                //构建学生数据
                new Student {Name="张三",EnrollmentDate=DateTime.Parse("2019-1-3")},
                new Student {Name="张死",EnrollmentDate=DateTime.Parse("2018-12-3")},
                new Student {Name="李四",EnrollmentDate=DateTime.Parse("2019-11-2")},
                new Student {Name="黄蓝",EnrollmentDate=DateTime.Parse("2018-11-3")},
                new Student {Name="蓝色",EnrollmentDate=DateTime.Parse("2018-11-3")},
                new Student {Name="美景",EnrollmentDate=DateTime.Parse("2018-12-23")},
                new Student {Name="两三",EnrollmentDate=DateTime.Parse("2018-12-13")},
                new Student {Name="行列",EnrollmentDate=DateTime.Parse("2018-12-3")}
            };
            //将学生数据加入实体集(context上下文，名字由自己定义)
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            //构建课程数据
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            //将课程数据加入实体集
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();


            //构建注册数据
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A}
            };
            //将注册数据加入实体集
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }


    }
}