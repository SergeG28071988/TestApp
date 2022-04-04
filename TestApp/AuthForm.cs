using System;
using System.Windows.Forms;

namespace TestApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            mainForm = new MainForm();
        }
        MainForm mainForm;
        string Login = "admin";
        string Password = "Qwery123";

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            string Log = textBox1.Text;
            string Pass = textBox2.Text;    
            if (Log == Login && Pass == Password )
            {
                mainForm.Show();    
              
            }
            else
            {
                MessageBox.Show("Ошибка в логине или пароле. Попробуйте снова!!", "Ошибка авторизации");
            }
        }
    }
}
