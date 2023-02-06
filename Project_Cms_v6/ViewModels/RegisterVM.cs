using Project_Cms_v6.Models;
using System.ComponentModel.DataAnnotations;

namespace Project_Cms_v6.ViewModels
{
    public class RegisterVM
    {
        public string? NIK { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; } 
        public Gender? Gender { get; set; }
        public int? Departments_Id { get; set; }
        public int? RoleId { get; set; }
    }
}
