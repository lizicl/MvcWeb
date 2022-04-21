using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [StringLength(300)]
        [Display(Name ="姓名")]
        public string Name { get; set; }
 
        [StringLength(1)]
        [Display(Name = "性别")]
        public string? Gender { get; set; }
        
        [Range(1,200)]
        [Display(Name = "年龄")]
        public int age { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "出生日期")]
        public DateTime BirthDate { get; set; }

        
        [Display(Name = "电话")]
        [StringLength(13)]
        public string Phone { get; set; }

        [Range(30, 50)]
        [Display(Name = "体温")]
        public double Temperature { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "填表日期")]
        public DateTime FillingDate { get; set; }
    }
}
