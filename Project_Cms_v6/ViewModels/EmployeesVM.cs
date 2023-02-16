using Project_Cms_v6.Models;
using System.Security.Cryptography.X509Certificates;

namespace Project_Cms_v6.ViewModels
{
    public class EmployeesVM
    {
        public string NIK { get; set; }
        public string Employees_Name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }
        public string RoleName { get; set; }
        public string Department_Name { get; set; }
        public string Manager_Id { get; set; }
        public string Manager_Name { get; set;}
    }
}
