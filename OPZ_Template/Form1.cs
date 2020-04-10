using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPZ_Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyOPZ opz = new MyOPZ();
        private void btn_Translate_Click(object sender, EventArgs e)
        {
            string str = opz.Translate(textBox1.Text);
            textBox2.Text = str;
        }

        private void btn_Caclculate_Click(object sender, EventArgs e)
        {
            textBox3.Text = opz.Translate(textBox2.Text);
        }
    }
}
