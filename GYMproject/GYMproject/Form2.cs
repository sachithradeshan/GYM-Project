using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new memberPerformance().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new payment().Show();
            this.Hide();
        }
    }
}
