using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Cms_v6.Models
{
    public class Employees
    {
        [Key]
        public string NIK { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Salary { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        [ForeignKey("Manager")]
        public string? Manager_Id { get; set; }
        public Accounts Accounts { get; set; }
        public Employees? Manager { get; set; }
        public List<Employees>? EmployeesManager { get; set; }
        public int? Departments_Id { get; set; }
        [ForeignKey("Departments_Id")]
        public Departments? Departments { get; set; }
        [InverseProperty("Manager")]
        public Departments Manager_Department { get; set; }

    }
    public enum Gender
    {
        Male, Female
    }
}
