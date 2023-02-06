using Dapper;
using Microsoft.Data.SqlClient;
using Project_Cms_v6.Context;
using Project_Cms_v6.Models;
using Project_Cms_v6.Repositories.Interface;
using Project_Cms_v6.ViewModels;
using System.Data;
using System.Reflection.Metadata;

namespace Project_Cms_v6.Repositories.Data
{
    public class EmployeesRepository : GeneralRepository<AppDbContext,Employees, string>
    {
        public IConfiguration _configuration;
        private readonly AppDbContext appDbContext;
        DynamicParameters parameters = new DynamicParameters();
        public EmployeesRepository(IConfiguration configuration, AppDbContext appDbContext) : base(appDbContext)
        {
            _configuration = configuration;
            this.appDbContext = appDbContext;
        }

        public string GenerateNIK()
        {
            var lastNIK = "";
            var newNIK = appDbContext.Employees.ToList().Count() + 1;

            if (newNIK >= 1 && newNIK <= 9)
            {
                lastNIK = "000" + Convert.ToString(newNIK);
            }
            else if (newNIK >= 10 && newNIK <= 99)
            {
                lastNIK = "00" + Convert.ToString(newNIK);
            }
            else if (newNIK >= 100 && newNIK <= 999)
            {
                lastNIK = "0" + Convert.ToString(newNIK);
            }

            DateTime dateTime = DateTime.UtcNow.Date;
            lastNIK = dateTime.ToString("yyyyddMM") + lastNIK;
            return lastNIK;
        }

        public virtual int RegisterInsert(RegisterVM registerVM)
            {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:APICms"]))
            {
                string generateNIK = GenerateNIK();
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(registerVM.Password);

                var spName = "SP_RegisterInsert";
                parameters.Add("@NIK", generateNIK);
                parameters.Add("@FirstName", registerVM.FirstName);
                parameters.Add("@LastName", registerVM.LastName);
                parameters.Add("@Password", passwordHash);
                parameters.Add("@Email", registerVM.Email);
                parameters.Add("@BirthDate", registerVM.BirthDate);
                parameters.Add("@Gender", registerVM.Gender);
                parameters.Add("@Phone", registerVM.Phone);
                parameters.Add("@Departments_Id", registerVM.Departments_Id);
                parameters.Add("@RoleId", registerVM.RoleId);
                var insert = connection.Execute(spName, parameters, commandType: CommandType.StoredProcedure);
                return insert;
            }
        }
        public IEnumerable<Employees> Read()
            {
                throw new NotImplementedException();
            }

            public Employees Read(string key)
            {
                throw new NotImplementedException();
            }

            public int Create(Employees entity)
            {
                throw new NotImplementedException();
            }

            public int Update(Employees entity)
            {
                throw new NotImplementedException();
            }

            public int Delete(string key)
            {
                throw new NotImplementedException();
            }
        }
    }
