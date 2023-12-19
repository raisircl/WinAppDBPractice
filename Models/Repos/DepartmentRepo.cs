using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDBPractice.Models.Interfaces;
using WinAppDBPractice.Models.POCO;
using System.Configuration;
using System.Data.SqlClient;

namespace WinAppDBPractice.Models.Repos
{
    public class DepartmentRepo : IDepartmentRepo
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();   
        public DepartmentRepo()
        {
            //string x=ConfigurationSettings.AppSettings["msg"].ToString().Trim(); 
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        }
        public Department CreateDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public Department DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            List<Department> list = new List<Department>();

            comm.CommandText = "select * from tblDept";
            comm.Connection = conn;
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Department department = new Department() {
                    Id = Convert.ToInt32(reader["DNo"]),
                    DName = Convert.ToString(reader["DName"]),
                    Loc = Convert.ToString(reader["Loc"])
                };
                list.Add(department);
            }
            return list;
        }

        public Department UpdateDepartment(int id, Department department)
        {
            throw new NotImplementedException();
        }
    }
}
