using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            //构建学生数据
           
            var students = new List<Student>
            {
            new Student{Name="黄朝锦1",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{Name="黄朝锦2",EnrollmentDate=DateTime.Parse("2018-09-02")},
            new Student{Name="黄朝锦3",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{Name="黄朝锦4",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{Name="黄朝锦5",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{Name="黄朝锦6",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{Name="黄朝锦7",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{Name="黄朝锦8",EnrollmentDate=DateTime.Parse("2018-09-01")}
            };
            //将学生数据加入实体集 
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            //构建课程数据       
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="数学",Credits=3,},
            new Course{CourseID=4022,Title="C#",Credits=3,},
            new Course{CourseID=4041,Title="语文",Credits=3,},
            new Course{CourseID=1045,Title="物理",Credits=4,},
            new Course{CourseID=3141,Title="英语",Credits=4,},
            new Course{CourseID=2021,Title="化学",Credits=3,},
            new Course{CourseID=2042,Title="Web",Credits=4,}
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
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            //将注册数据加入实体集
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}