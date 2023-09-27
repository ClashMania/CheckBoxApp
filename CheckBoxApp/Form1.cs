using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBox1.Visible == false)

                txtBox1.Visible = true;

            else

                txtBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox1.AppendText("Odabrali ste :" + Environment.NewLine);

            if (checkBox1.Checked)

                txtBox1.AppendText("Doručak" + Environment.NewLine);

            if (checkBox2.Checked)

                txtBox1.AppendText("Ručak" + Environment.NewLine);

            if (checkBox3.Checked)

                txtBox1.AppendText("Večera" + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }    }
}
