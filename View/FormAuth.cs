using Cosiness.Classes;
using Cosiness.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosiness
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        int sec;
        bool vis = true;
        int attempt = 3;

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string _login = textBoxLogin.Text;
            string _password = textBoxPassword.Text;

            using (Models.HotelEntities db = new Models.HotelEntities())
            {
                List<Models.User> users = db.User.Where(x => x.Login == _login && x.Password == _password).ToList();
                Models.User user = users.FirstOrDefault();
                if (user != null)
                {
                    Helper.idRole = user.RoleID;
                    if (Helper.idRole == 1)
                    {
                        FormAdmin formAdmin = new FormAdmin();
                        Hide();
                        formAdmin.ShowDialog();
                        Show();
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                    }
                    else if (Helper.idRole == 2)
                    {
                        FormManager formManager = new FormManager();
                        Hide();
                        formManager.ShowDialog();
                        Show();
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                    }
                }
                else
                {
                    attempt--;
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    MessageBox.Show("Неверно введен логин или пароль", "Ошибка авторизации");
                    if (attempt == 0)
                    {
                        sec = 10;
                        timerBlock.Enabled = true;
                        timerBlock.Start();
                        buttonAuth.Visible = false;
                        buttonGuest.Visible = false;
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                        MessageBox.Show("Система заблокирована на 10 секунд", "Ошибка авторизации");
                    }
                }
            }
        }

        private void timerBlock_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                timerBlock.Enabled = false;
                timerBlock.Stop();
                buttonAuth.Visible = true;
                buttonGuest.Visible = true;
            }
            if (sec > 0)
            {
                sec--;
            }
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            Helper.idRole = 0;
            FormAdmin formAdmin = new FormAdmin();
            Hide();
            formAdmin.ShowDialog();
            Show();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (vis)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                vis = true;
            }
        }
    }
}
