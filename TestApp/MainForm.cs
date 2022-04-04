using System;
using System.Windows.Forms;

namespace TestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                points = points + 10;
            }
            if (radioButton2.Checked == true)
            {
                points = points + 10;
            }
            label3.Text = "Количество набранных баллов:  " + Convert.ToString(points);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
