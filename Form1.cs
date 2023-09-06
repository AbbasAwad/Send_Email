using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace Send_to_email
{
    public partial class Form1 : Form
    {
        public Form1()=> InitializeComponent();

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "Email")
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text =="")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void txtSub_Enter(object sender, EventArgs e)
        {
            if (txtSub.Text == "Subjact")
            {
                txtSub.Clear();
                txtSub.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtSub_Leave(object sender, EventArgs e)
        {
            if(txtSub.Text =="")
            {
                txtSub.Text = "Subjact";
                txtSub.ForeColor = Color.FromArgb(200,200,200);
            }
        }

        private void txtMassege_Enter(object sender, EventArgs e)
        {
            if(txtMass.Text == "Massege")
            {
                txtMass.Text = "";
                txtMass.ForeColor = Color.FromArgb(83,179,233);
            }
        }

        private void txtMassege_Leave(object sender, EventArgs e)
        {
            if(txtMass.Text == "")
            {
                txtMass.Text = "Massege";
                txtMass.ForeColor = Color.FromArgb(200,200,200);
            }
        }

        private void txtfrom_Enter(object sender, EventArgs e)
        {
            if (txtfrom.Text == "My Email")
            {
                txtfrom.Text = "";
                txtfrom.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtfrom_Leave(object sender, EventArgs e)
        {
            if (txtfrom.Text == "")
            {
                txtfrom.Text = "My Email";
                txtfrom.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void button1_Click(object sender, EventArgs e) => Environment.Exit(0);
       
        private void Form1_Load(object sender, EventArgs e) => txtfrom.Focus();

    }
}
