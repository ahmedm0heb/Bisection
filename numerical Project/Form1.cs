using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerical_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void setSize()
        {
            this.Size = new Size(460, 484);
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Location = new Point(x, y);
        }
        private void Form1_Move(object sender, EventArgs e)
        {
            setSize();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            setSize();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bisection bisection = new Bisection();
            bisection.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox1.Items[0])
            {
                Bisection bisection = new Bisection();
                bisection.ShowDialog();
            }
        }

}
}

