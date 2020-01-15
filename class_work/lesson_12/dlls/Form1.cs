using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCompany;

namespace dlls
{
    public partial class Form1 : Form
    {
        private void InitializeEmployee()
        {
        }
        private void InitializeDepartments()
        {
            List<Department> dep = new List<Department>();
            dep.Add(new Department { Id = 1, Name = "Developers" });
            dep.Add(new Department { Id = 2, Name = "Admins" });
            dep.Add(new Department { Id = 3, Name = "Media" });
            dep.Add(new Department { Id = 4, Name = "Sails" });
            dep.Add(new Department { Id = 5, Name = "Partners" });
            dep.Add(new Department { Id = 6, Name = "Accountant" });
            dep.Add(new Department { Id = 7, Name = "Storage" });
            dep.Add(new Department { Id = 8, Name = "Logistic" });
            dep.Add(new Department { Id = 9, Name = "Managment" });

            dep.ForEach(x => departmentBindingSource.Add(x));

        }

        public Form1()
        {
            InitializeComponent();
            InitializeDepartments();
            InitializeEmployee();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MinimumSize.Height = Form1.
        }
    }
}
