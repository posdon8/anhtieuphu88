using Microsoft.Win32.SafeHandles;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("you wrong", "report", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("OK di di");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
