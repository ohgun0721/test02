using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form1 : Form
    {
        static int zzz = 0;
        static int zzz1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = zzz.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            zzz += 1; 
        }
    }
}
