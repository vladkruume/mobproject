using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Vytas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible)
            {
                pictureBox2.Visible = false;
                button1.Text = "On";
            }
            else
            {
                pictureBox2.Visible = true;
                button1.Text = "Off";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 formm = new Form2();
            formm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form3 formmm = new Form3();
            formmm.Show();

        }
    }
}
