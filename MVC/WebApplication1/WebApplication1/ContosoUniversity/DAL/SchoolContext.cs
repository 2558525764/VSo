using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    /// <summary>
    /// 上下文类
    /// </summary>
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
            //连接字符串 （它稍后将添加到 Web.config 文件） 的名称被传递给构造函数。
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //不使用复数形式到表格命名
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}