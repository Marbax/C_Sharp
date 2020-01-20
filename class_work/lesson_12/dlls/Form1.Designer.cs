namespace dlls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HR_DepartmentTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxEmpPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerHire = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.ProdactionTab = new System.Windows.Forms.TabPage();
            this.ManagmentTab = new System.Windows.Forms.TabPage();
            this.CRMTab = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxFireDate = new System.Windows.Forms.TextBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HR_DepartmentTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabControl1.Controls.Add(this.HomeTab);
            this.tabControl1.Controls.Add(this.HR_DepartmentTab);
            this.tabControl1.Controls.Add(this.ProdactionTab);
            this.tabControl1.Controls.Add(this.ManagmentTab);
            this.tabControl1.Controls.Add(this.CRMTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(15, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 655);
            this.tabControl1.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HomeTab.Controls.Add(this.pictureBox1);
            this.HomeTab.Location = new System.Drawing.Point(4, 29);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(1);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(1);
            this.HomeTab.Size = new System.Drawing.Size(853, 622);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 616);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HR_DepartmentTab
            // 
            this.HR_DepartmentTab.Controls.Add(this.groupBox3);
            this.HR_DepartmentTab.Controls.Add(this.groupBox2);
            this.HR_DepartmentTab.Controls.Add(this.groupBox1);
            this.HR_DepartmentTab.Location = new System.Drawing.Point(4, 29);
            this.HR_DepartmentTab.Name = "HR_DepartmentTab";
            this.HR_DepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.HR_DepartmentTab.Size = new System.Drawing.Size(853, 622);
            this.HR_DepartmentTab.TabIndex = 1;
            this.HR_DepartmentTab.Text = "HR Department";
            this.HR_DepartmentTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxEmpPhoto);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(203, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 616);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo";
            // 
            // pictureBoxEmpPhoto
            // 
            this.pictureBoxEmpPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEmpPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmpPhoto.Image")));
            this.pictureBoxEmpPhoto.Location = new System.Drawing.Point(3, 22);
            this.pictureBoxEmpPhoto.Name = "pictureBoxEmpPhoto";
            this.pictureBoxEmpPhoto.Size = new System.Drawing.Size(441, 591);
            this.pictureBoxEmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmpPhoto.TabIndex = 0;
            this.pictureBoxEmpPhoto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFireDate);
            this.groupBox2.Controls.Add(this.textBoxSalary);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxPosition);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerHire);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerBirth);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(650, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 616);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Info";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSalary.Location = new System.Drawing.Point(0, 545);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(181, 26);
            this.textBoxSalary.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 54);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salary:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPosition.Location = new System.Drawing.Point(0, 459);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(181, 26);
            this.textBoxPosition.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 54);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fire date:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hire Date:";
            // 
            // dateTimePickerHire
            // 
            this.dateTimePickerHire.Location = new System.Drawing.Point(3, 288);
            this.dateTimePickerHire.Name = "dateTimePickerHire";
            this.dateTimePickerHire.Size = new System.Drawing.Size(181, 26);
            this.dateTimePickerHire.TabIndex = 4;
            this.dateTimePickerHire.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthday Date:";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(3, 203);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(181, 26);
            this.dateTimePickerBirth.TabIndex = 2;
            this.dateTimePickerBirth.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxName.Location = new System.Drawing.Point(3, 113);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(181, 26);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname , Name:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxEmployee);
            this.groupBox1.Controls.Add(this.comboBoxDep);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxEmployee.ItemHeight = 89;
            this.listBoxEmployee.Location = new System.Drawing.Point(6, 162);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.ScrollAlwaysVisible = true;
            this.listBoxEmployee.Size = new System.Drawing.Size(188, 360);
            this.listBoxEmployee.TabIndex = 1;
            this.listBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.DropDownHeight = 200;
            this.comboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDep.Font = new System.Drawing.Font("Cambria Math", 12F);
            this.comboBoxDep.IntegralHeight = false;
            this.comboBoxDep.ItemHeight = 89;
            this.comboBoxDep.Location = new System.Drawing.Point(6, 56);
            this.comboBoxDep.MaxDropDownItems = 10;
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDep.Size = new System.Drawing.Size(188, 97);
            this.comboBoxDep.TabIndex = 0;
            this.comboBoxDep.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ProdactionTab
            // 
            this.ProdactionTab.Location = new System.Drawing.Point(4, 29);
            this.ProdactionTab.Name = "ProdactionTab";
            this.ProdactionTab.Size = new System.Drawing.Size(853, 622);
            this.ProdactionTab.TabIndex = 2;
            this.ProdactionTab.Text = "Prodaction";
            this.ProdactionTab.UseVisualStyleBackColor = true;
            // 
            // ManagmentTab
            // 
            this.ManagmentTab.Location = new System.Drawing.Point(4, 29);
            this.ManagmentTab.Name = "ManagmentTab";
            this.ManagmentTab.Size = new System.Drawing.Size(853, 622);
            this.ManagmentTab.TabIndex = 3;
            this.ManagmentTab.Text = "Managment";
            this.ManagmentTab.UseVisualStyleBackColor = true;
            // 
            // CRMTab
            // 
            this.CRMTab.Location = new System.Drawing.Point(4, 29);
            this.CRMTab.Name = "CRMTab";
            this.CRMTab.Size = new System.Drawing.Size(853, 622);
            this.CRMTab.TabIndex = 4;
            this.CRMTab.Text = "CRM";
            this.CRMTab.UseVisualStyleBackColor = true;
            // 
            // textBoxFireDate
            // 
            this.textBoxFireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFireDate.Location = new System.Drawing.Point(0, 373);
            this.textBoxFireDate.Name = "textBoxFireDate";
            this.textBoxFireDate.Size = new System.Drawing.Size(181, 26);
            this.textBoxFireDate.TabIndex = 12;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(MyCompany.Department);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(MyCompany.Employee);
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(MyCompany.Department);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(861, 655);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 21, 4, 21);
            this.Name = "Form1";
            this.Text = "Control System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HR_DepartmentTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage HR_DepartmentTab;
        private System.Windows.Forms.TabPage ProdactionTab;
        private System.Windows.Forms.TabPage ManagmentTab;
        private System.Windows.Forms.TabPage CRMTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxEmpPhoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerHire;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFireDate;
    }
}

