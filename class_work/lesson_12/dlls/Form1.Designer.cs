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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdactionTab = new System.Windows.Forms.TabPage();
            this.ManagmentTab = new System.Windows.Forms.TabPage();
            this.CRMTab = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.HomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HR_DepartmentTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(831, 581);
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
            this.HomeTab.Size = new System.Drawing.Size(823, 548);
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
            this.pictureBox1.Size = new System.Drawing.Size(817, 542);
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
            this.HR_DepartmentTab.Size = new System.Drawing.Size(823, 548);
            this.HR_DepartmentTab.TabIndex = 1;
            this.HR_DepartmentTab.Text = "HR Department";
            this.HR_DepartmentTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(203, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 542);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Photo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 517);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(620, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 542);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxEmployee);
            this.groupBox1.Controls.Add(this.comboBoxDep);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 542);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxEmployee.ItemHeight = 25;
            this.listBoxEmployee.Location = new System.Drawing.Point(6, 87);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.ScrollAlwaysVisible = true;
            this.listBoxEmployee.Size = new System.Drawing.Size(188, 454);
            this.listBoxEmployee.TabIndex = 1;
            this.listBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "Id", true));
            this.comboBoxDep.DataSource = this.departmentBindingSource;
            this.comboBoxDep.DisplayMember = "Name";
            this.comboBoxDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDep.DropDownHeight = 200;
            this.comboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDep.Font = new System.Drawing.Font("Cambria Math", 12F);
            this.comboBoxDep.IntegralHeight = false;
            this.comboBoxDep.ItemHeight = 25;
            this.comboBoxDep.Location = new System.Drawing.Point(6, 56);
            this.comboBoxDep.MaxDropDownItems = 10;
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxDep.Size = new System.Drawing.Size(188, 31);
            this.comboBoxDep.TabIndex = 0;
            this.comboBoxDep.ValueMember = "Id";
            this.comboBoxDep.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(MyCompany.Department);
            // 
            // ProdactionTab
            // 
            this.ProdactionTab.Location = new System.Drawing.Point(4, 29);
            this.ProdactionTab.Name = "ProdactionTab";
            this.ProdactionTab.Size = new System.Drawing.Size(839, 723);
            this.ProdactionTab.TabIndex = 2;
            this.ProdactionTab.Text = "Prodaction";
            this.ProdactionTab.UseVisualStyleBackColor = true;
            // 
            // ManagmentTab
            // 
            this.ManagmentTab.Location = new System.Drawing.Point(4, 29);
            this.ManagmentTab.Name = "ManagmentTab";
            this.ManagmentTab.Size = new System.Drawing.Size(839, 723);
            this.ManagmentTab.TabIndex = 3;
            this.ManagmentTab.Text = "Managment";
            this.ManagmentTab.UseVisualStyleBackColor = true;
            // 
            // CRMTab
            // 
            this.CRMTab.Location = new System.Drawing.Point(4, 29);
            this.CRMTab.Name = "CRMTab";
            this.CRMTab.Size = new System.Drawing.Size(839, 723);
            this.CRMTab.TabIndex = 4;
            this.CRMTab.Text = "CRM";
            this.CRMTab.UseVisualStyleBackColor = true;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(MyCompany.Department);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 89F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 581);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 21, 4, 21);
            this.Name = "Form1";
            this.Text = "Control System";
            this.tabControl1.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HR_DepartmentTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
    }
}

