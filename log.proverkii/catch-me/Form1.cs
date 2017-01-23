using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catch_me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("You Win!", "Congratulations", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - this.button1.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - this.button1.ClientSize.Height;
            this.button1.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));

        }
    }
}
