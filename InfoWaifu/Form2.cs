using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoWaifu
{
    public partial class Form2 : Form
    {
        public Form2(string label, string name)
        {
            InitializeComponent();
            pictureBox1.Load(label);
            label2.Text = name;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Console.WriteLine(label);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
