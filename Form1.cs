using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDBPractice.Models.Interfaces;
using WinAppDBPractice.Models.Repos;

namespace WinAppDBPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //MVC
        //Repos - Business Logic 

        IDepartmentRepo departmentRepo = new DepartmentRepo();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = departmentRepo.GetDepartments();
        }
    }
}
