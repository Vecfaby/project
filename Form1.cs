using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubProg
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "55555")

            {
                menu m = new menu();
                m.Show();

                this.Hide();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}

