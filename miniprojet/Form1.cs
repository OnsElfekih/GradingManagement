using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniprojet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            espEtud etud = new espEtud();
            etud.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            espEnseig enseig = new espEnseig();
            enseig.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            espAdmin admin = new espAdmin();
            admin.ShowDialog();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
