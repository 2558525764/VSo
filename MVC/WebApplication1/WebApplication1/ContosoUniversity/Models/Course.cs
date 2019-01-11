using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    /// <summary>
    /// 课程类
    /// </summary>
    public class Course
    {
        //取消数据库自增长的属性
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }//学分

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}