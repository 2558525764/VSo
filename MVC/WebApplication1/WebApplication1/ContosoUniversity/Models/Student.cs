using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "姓名")]
        [StringLength(8)]
        public string Name { get; set; }
        [Display(Name = "注册日期")]
        public DateTime EnrollmentDate { get; set; }//注册日期

        [Display(Name = "头像")]
        public string Images { get; set; }
        [Display(Name = "选课信息")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }//导航属性
    }
}