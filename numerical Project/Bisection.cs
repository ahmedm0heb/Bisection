using EO.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerical_Project
{

    public partial class Bisection : Form
    {

        public Bisection()
        {
            InitializeComponent();
        }
        private void Bisection_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Bisection_Resize(object sender, EventArgs e)
        {
            setSize();
        }
        private void Bisection_Move(object sender, EventArgs e)
        {
            setSize();
        }

        //Go TO ->
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = new Size(460, 484);
            Label lab = new Label();
            frm.Controls.Add(lab);
            lab.Size = new Size(100, 100);
            lab.Text = "Welcome To this new form ";
            lab.Location = new Point(100, 100);
            frm.ShowDialog();

        }

        //Back
        private void Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Hide();
        }
        

        //Ok After Enter name
        private void btnName_Click(object sender, EventArgs e)
        {
            lblname.Location = new Point(20, 50);
            txtname.Visible = false;
            btnName.Visible = false;
            lblname.Text = "Hello Dr " + txtname.Text + "\nplease insert the requirements \nof the equation";
            button1.Visible = true;
        }
        //تثبيت الطول والعرض لحجم شاشة التنفيذ
        private void setSize()
        {
            this.Size = new Size(460, 484);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }
      
        // the code of equations




        
        private void valuey_TextChanged(object sender, EventArgs e)
        {
        }
        private void showlbl_Click(object sender, EventArgs e)
        {
        }

    }

}
