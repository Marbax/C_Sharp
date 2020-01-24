using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmentLib;
using ClientLib;

namespace ApartmentCRM
{

    public partial class Form1 : Form
    {
        DataManager _dm = new DataManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dm.ClientsData.ForEach(x => comboBox1Clients.Items.Add(x));
            comboBox1Clients.DisplayMember = "Name";
            comboBox1Clients.SelectedIndex = 0;
        }

        private void comboBox1Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elem = comboBox1Clients.SelectedItem as Client;

            textBox1PhoneNum.Text = elem.PhoneNumber;
            textBox2ClientName.Text = elem.Name;

            listBox1History.Items.Clear();
            elem.History.ForEach(x => listBox1History.Items.Add(x));
            listBox1History.DisplayMember = "Name";

        }

        private void listBox1History_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elem = listBox1History.SelectedItem as Apartment;

            vScrollBar1PicSCroll.Maximum = elem.Photos.Count - 1;
            vScrollBar1PicSCroll.Value = 0;
            pictureBox1Photos.ImageLocation = elem.Photos[vScrollBar1PicSCroll.Value];

            dateTimePicker1ArrivalDate.Value = elem.ArrivalDate;
            dateTimePicker2DepartureDate.Value = elem.DepartureDate;
            textBox3DayValue.Text = elem.DayValue.ToString();
            richTextBox1Description.Text = elem.Description;
        }

        private void vScrollBar1PicSCroll_Scroll(object sender, ScrollEventArgs e)
        {
            var elem = listBox1History.SelectedItem as Apartment;

            pictureBox1Photos.ImageLocation = elem.Photos[vScrollBar1PicSCroll.Value];
        }
    }
}
