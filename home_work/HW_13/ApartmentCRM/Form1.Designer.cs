namespace ApartmentCRM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1Cients = new System.Windows.Forms.TabPage();
            this.panel1Editing = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1PhoneNum = new System.Windows.Forms.Label();
            this.label2ClientName = new System.Windows.Forms.Label();
            this.textBox1PhoneNum = new System.Windows.Forms.TextBox();
            this.textBox2ClientName = new System.Windows.Forms.TextBox();
            this.label1History = new System.Windows.Forms.Label();
            this.comboBox1Clients = new System.Windows.Forms.ComboBox();
            this.listBox1History = new System.Windows.Forms.ListBox();
            this.panel2Photos = new System.Windows.Forms.Panel();
            this.pictureBox1Photos = new System.Windows.Forms.PictureBox();
            this.vScrollBar1PicSCroll = new System.Windows.Forms.VScrollBar();
            this.dateTimePicker1ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label1ArrivalDate = new System.Windows.Forms.Label();
            this.label2DepartureDate = new System.Windows.Forms.Label();
            this.dateTimePicker2DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1Description = new System.Windows.Forms.RichTextBox();
            this.textBox3DayValue = new System.Windows.Forms.TextBox();
            this.label3DayValue = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1Cients.SuspendLayout();
            this.panel1Editing.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2Photos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Photos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1Cients);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1Cients
            // 
            this.tabPage1Cients.Controls.Add(this.label3DayValue);
            this.tabPage1Cients.Controls.Add(this.textBox3DayValue);
            this.tabPage1Cients.Controls.Add(this.richTextBox1Description);
            this.tabPage1Cients.Controls.Add(this.label2DepartureDate);
            this.tabPage1Cients.Controls.Add(this.dateTimePicker2DepartureDate);
            this.tabPage1Cients.Controls.Add(this.label1ArrivalDate);
            this.tabPage1Cients.Controls.Add(this.dateTimePicker1ArrivalDate);
            this.tabPage1Cients.Controls.Add(this.vScrollBar1PicSCroll);
            this.tabPage1Cients.Controls.Add(this.panel2Photos);
            this.tabPage1Cients.Controls.Add(this.panel1);
            this.tabPage1Cients.Controls.Add(this.panel1Editing);
            this.tabPage1Cients.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Cients.Name = "tabPage1Cients";
            this.tabPage1Cients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Cients.Size = new System.Drawing.Size(792, 424);
            this.tabPage1Cients.TabIndex = 0;
            this.tabPage1Cients.Text = "Клиенты";
            this.tabPage1Cients.UseVisualStyleBackColor = true;
            // 
            // panel1Editing
            // 
            this.panel1Editing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1Editing.Controls.Add(this.comboBox1Clients);
            this.panel1Editing.Controls.Add(this.label1History);
            this.panel1Editing.Controls.Add(this.textBox2ClientName);
            this.panel1Editing.Controls.Add(this.textBox1PhoneNum);
            this.panel1Editing.Controls.Add(this.label2ClientName);
            this.panel1Editing.Controls.Add(this.label1PhoneNum);
            this.panel1Editing.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1Editing.Location = new System.Drawing.Point(3, 3);
            this.panel1Editing.Name = "panel1Editing";
            this.panel1Editing.Size = new System.Drawing.Size(786, 192);
            this.panel1Editing.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox1History);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 226);
            this.panel1.TabIndex = 1;
            // 
            // label1PhoneNum
            // 
            this.label1PhoneNum.AutoSize = true;
            this.label1PhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1PhoneNum.Location = new System.Drawing.Point(5, 16);
            this.label1PhoneNum.Name = "label1PhoneNum";
            this.label1PhoneNum.Size = new System.Drawing.Size(122, 16);
            this.label1PhoneNum.TabIndex = 0;
            this.label1PhoneNum.Text = "Номер Телефона";
            // 
            // label2ClientName
            // 
            this.label2ClientName.AutoSize = true;
            this.label2ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2ClientName.Location = new System.Drawing.Point(8, 54);
            this.label2ClientName.Name = "label2ClientName";
            this.label2ClientName.Size = new System.Drawing.Size(39, 16);
            this.label2ClientName.TabIndex = 1;
            this.label2ClientName.Text = "ФИО";
            // 
            // textBox1PhoneNum
            // 
            this.textBox1PhoneNum.Location = new System.Drawing.Point(142, 12);
            this.textBox1PhoneNum.Name = "textBox1PhoneNum";
            this.textBox1PhoneNum.Size = new System.Drawing.Size(180, 20);
            this.textBox1PhoneNum.TabIndex = 2;
            // 
            // textBox2ClientName
            // 
            this.textBox2ClientName.Location = new System.Drawing.Point(142, 54);
            this.textBox2ClientName.Name = "textBox2ClientName";
            this.textBox2ClientName.Size = new System.Drawing.Size(180, 20);
            this.textBox2ClientName.TabIndex = 3;
            // 
            // label1History
            // 
            this.label1History.AutoSize = true;
            this.label1History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1History.Location = new System.Drawing.Point(329, 169);
            this.label1History.Name = "label1History";
            this.label1History.Size = new System.Drawing.Size(73, 20);
            this.label1History.TabIndex = 4;
            this.label1History.Text = "История";
            // 
            // comboBox1Clients
            // 
            this.comboBox1Clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Clients.FormattingEnabled = true;
            this.comboBox1Clients.Location = new System.Drawing.Point(378, 11);
            this.comboBox1Clients.Name = "comboBox1Clients";
            this.comboBox1Clients.Size = new System.Drawing.Size(179, 21);
            this.comboBox1Clients.TabIndex = 5;
            this.comboBox1Clients.SelectedIndexChanged += new System.EventHandler(this.comboBox1Clients_SelectedIndexChanged);
            // 
            // listBox1History
            // 
            this.listBox1History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1History.FormattingEnabled = true;
            this.listBox1History.Location = new System.Drawing.Point(0, 0);
            this.listBox1History.Name = "listBox1History";
            this.listBox1History.Size = new System.Drawing.Size(139, 224);
            this.listBox1History.TabIndex = 0;
            this.listBox1History.SelectedIndexChanged += new System.EventHandler(this.listBox1History_SelectedIndexChanged);
            // 
            // panel2Photos
            // 
            this.panel2Photos.Controls.Add(this.pictureBox1Photos);
            this.panel2Photos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2Photos.Location = new System.Drawing.Point(144, 195);
            this.panel2Photos.Name = "panel2Photos";
            this.panel2Photos.Size = new System.Drawing.Size(286, 226);
            this.panel2Photos.TabIndex = 2;
            // 
            // pictureBox1Photos
            // 
            this.pictureBox1Photos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1Photos.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1Photos.Name = "pictureBox1Photos";
            this.pictureBox1Photos.Size = new System.Drawing.Size(286, 226);
            this.pictureBox1Photos.TabIndex = 0;
            this.pictureBox1Photos.TabStop = false;
            // 
            // vScrollBar1PicSCroll
            // 
            this.vScrollBar1PicSCroll.Dock = System.Windows.Forms.DockStyle.Left;
            this.vScrollBar1PicSCroll.LargeChange = 1;
            this.vScrollBar1PicSCroll.Location = new System.Drawing.Point(430, 195);
            this.vScrollBar1PicSCroll.Name = "vScrollBar1PicSCroll";
            this.vScrollBar1PicSCroll.Size = new System.Drawing.Size(17, 226);
            this.vScrollBar1PicSCroll.TabIndex = 3;
            this.vScrollBar1PicSCroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1PicSCroll_Scroll);
            // 
            // dateTimePicker1ArrivalDate
            // 
            this.dateTimePicker1ArrivalDate.Location = new System.Drawing.Point(584, 201);
            this.dateTimePicker1ArrivalDate.Name = "dateTimePicker1ArrivalDate";
            this.dateTimePicker1ArrivalDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1ArrivalDate.TabIndex = 4;
            // 
            // label1ArrivalDate
            // 
            this.label1ArrivalDate.AutoSize = true;
            this.label1ArrivalDate.Location = new System.Drawing.Point(450, 207);
            this.label1ArrivalDate.Name = "label1ArrivalDate";
            this.label1ArrivalDate.Size = new System.Drawing.Size(73, 13);
            this.label1ArrivalDate.TabIndex = 5;
            this.label1ArrivalDate.Text = "Дата Вьезда";
            // 
            // label2DepartureDate
            // 
            this.label2DepartureDate.AutoSize = true;
            this.label2DepartureDate.Location = new System.Drawing.Point(450, 243);
            this.label2DepartureDate.Name = "label2DepartureDate";
            this.label2DepartureDate.Size = new System.Drawing.Size(75, 13);
            this.label2DepartureDate.TabIndex = 7;
            this.label2DepartureDate.Text = "Дата Выезда";
            // 
            // dateTimePicker2DepartureDate
            // 
            this.dateTimePicker2DepartureDate.Location = new System.Drawing.Point(584, 237);
            this.dateTimePicker2DepartureDate.Name = "dateTimePicker2DepartureDate";
            this.dateTimePicker2DepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2DepartureDate.TabIndex = 6;
            // 
            // richTextBox1Description
            // 
            this.richTextBox1Description.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1Description.Location = new System.Drawing.Point(447, 292);
            this.richTextBox1Description.Name = "richTextBox1Description";
            this.richTextBox1Description.Size = new System.Drawing.Size(342, 129);
            this.richTextBox1Description.TabIndex = 8;
            this.richTextBox1Description.Text = "";
            // 
            // textBox3DayValue
            // 
            this.textBox3DayValue.Location = new System.Drawing.Point(584, 266);
            this.textBox3DayValue.Name = "textBox3DayValue";
            this.textBox3DayValue.Size = new System.Drawing.Size(200, 20);
            this.textBox3DayValue.TabIndex = 9;
            // 
            // label3DayValue
            // 
            this.label3DayValue.AutoSize = true;
            this.label3DayValue.Location = new System.Drawing.Point(450, 273);
            this.label3DayValue.Name = "label3DayValue";
            this.label3DayValue.Size = new System.Drawing.Size(69, 13);
            this.label3DayValue.TabIndex = 10;
            this.label3DayValue.Text = "Цена в день";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1Cients.ResumeLayout(false);
            this.tabPage1Cients.PerformLayout();
            this.panel1Editing.ResumeLayout(false);
            this.panel1Editing.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2Photos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Photos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1Cients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel1Editing;
        private System.Windows.Forms.TextBox textBox2ClientName;
        private System.Windows.Forms.TextBox textBox1PhoneNum;
        private System.Windows.Forms.Label label2ClientName;
        private System.Windows.Forms.Label label1PhoneNum;
        private System.Windows.Forms.Label label1History;
        private System.Windows.Forms.ComboBox comboBox1Clients;
        private System.Windows.Forms.ListBox listBox1History;
        private System.Windows.Forms.VScrollBar vScrollBar1PicSCroll;
        private System.Windows.Forms.Panel panel2Photos;
        private System.Windows.Forms.PictureBox pictureBox1Photos;
        private System.Windows.Forms.Label label2DepartureDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2DepartureDate;
        private System.Windows.Forms.Label label1ArrivalDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1ArrivalDate;
        private System.Windows.Forms.RichTextBox richTextBox1Description;
        private System.Windows.Forms.Label label3DayValue;
        private System.Windows.Forms.TextBox textBox3DayValue;
    }
}

