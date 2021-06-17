using System;
using System.Windows.Forms;

namespace Language_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Languages L1 = new Languages();
            Form1 F1 = new Form1();
            L1.Show();
            F1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About A1 = new About();
            Form1 F1 = new Form1();
            A1.Show();
            F1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
