using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDBPractice.Models.POCO;

namespace WinAppDBPractice.Models.Interfaces
{
    public interface IDepartmentRepo
    {
        List<Department> GetDepartments();
        Department GetDepartmentById(int id);
        Department CreateDepartment(Department department); 
        Department UpdateDepartment(int id, Department department);
        Department DeleteDepartment(int id);

    }
}
