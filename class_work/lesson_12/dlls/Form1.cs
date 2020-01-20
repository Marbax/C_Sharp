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
        private DataManager _dm = new DataManager();

        public Form1()
        {
            InitializeComponent();
            InitDepartments();
            //Initemployee();
        }

        private void InitDepartments()
        {
            //_dm.Departments.ForEach(x => departmentBindingSource.Add(x));

            _dm.Departments.ForEach(x => comboBoxDep.Items.Add(x));
            comboBoxDep.DisplayMember = "Name";
            comboBoxDep.SelectedIndex = 0;
        }

        private void InitEmployee(int id)
        {
            //_dm.Employments.ForEach(x => employeeBindingSource.Add(x));

            _dm.Employments.Where(y => y.DepId == id).ToList().ForEach(x => listBoxEmployee.Items.Add(x.Name));
            listBoxEmployee.DisplayMember = "Name";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elem = comboBoxDep.SelectedItem as Department;
            var id = elem.Id;

            listBoxEmployee.Items.Clear();
            _dm.Employments.Where(y => y.DepId == id).ToList().ForEach(x => listBoxEmployee.Items.Add(x));
            //_dm.Employments.Where(y => y.DepId == id).ToList();
            listBoxEmployee.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elem = listBoxEmployee.SelectedItem as Employee;
            if (elem != null)
            {
                var emp_id = elem.Id;
                //pictureBoxEmpPhoto.Image = Image.FromFile(elem.Photo);
                pictureBoxEmpPhoto.ImageLocation = elem.Photo;
                textBoxName.Text = elem.Name;
                dateTimePickerBirth.Value = elem.Birth;
                dateTimePickerHire.Value = elem.Entry;
                textBoxFireDate.Text = elem.Fire;
                textBoxPosition.Text = elem.Position;
                textBoxSalary.Text = elem.Salary.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Initialize succesfull");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
