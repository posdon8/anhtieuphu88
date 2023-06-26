using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if  (panel1.Visible == true)
            {
                panel1.Hide();
                this.pictureBox2.Image = Properties.Resources.picâ;

            }
            else
            {
                panel1.Show();
                this.pictureBox2.Image = Properties.Resources.ă1;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Hide();
                this.pictureBox3.Image = Properties.Resources.picâ;
            }
            else
            {
                panel2.Show();
                this.pictureBox3.Image = Properties.Resources.ă1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker1.Enabled == true)
            {
                this.dateTimePicker1.Enabled = false;
            }
            else
            {
                this.dateTimePicker1.Enabled = true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker2.Enabled == true)
            {
                this.dateTimePicker2.Enabled = false;
            }
            else
            {
                this.dateTimePicker2.Enabled = true;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.textBox3.Enabled == false)
            { this.textBox3.Enabled = true;

            }else
            {
                this.textBox3.Enabled = false;
            }
            if (this.comboBox1.Enabled == false)
            {
                this.comboBox1.Enabled = true;

            }
            else
            {
                this.comboBox1.Enabled = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
