using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunawayButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random r = new Random();

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int x = r.Next(700);
            int y = (r.Next(400) + 80);
            button1.Location = new Point(x, y);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You will get a lot of money");
        }
    }
}
