using System.ComponentModel.DataAnnotations;

namespace FinalDevOps.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
