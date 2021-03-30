using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp0301.ChildForms;

namespace WinFormsApp0301
{
    public partial class Form1 : Form
    {
        //private Button testButton = new Button();
        public Form1()
        {
            InitializeComponent();
            //this.Controls.Add(testButton);
            //testButton.Text = "帅B";
            //testButton.Location = new Point(12, 12);
            this.textBox1.AutoSize = false;
        }

        private void OnClickB(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
        }

        private void testButtonC_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
