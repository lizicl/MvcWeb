using System.ComponentModel.DataAnnotations;

namespace MvcWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [StringLength(300)]
        public string Name { get; set; }
 
        [StringLength(1)]
        public string? Gender { get; set; }
        
        [Range(1,200)]
        public int age { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [MaxLength(13)]
        public byte Phone { get; set; }

        [Range(30, 50)]
        public double Temperature { get; set; }

        public DateTime FillingDate { get; set; }
    }
}
