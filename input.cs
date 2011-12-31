using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XCL_
{
    public partial class input : Form
    {
        public string inputs;
        public input()
        {
            InitializeComponent();
        }

        private void input_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputs = textBox1.Text;
            Close();
        }
    }
}
