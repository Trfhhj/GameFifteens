using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFifteens2
{
    public partial class LoginForm : Form
    {
        private Color _colorHint = Color.FromArgb(107, 122, 126);
        private Color _colorText = Color.FromArgb(73, 89, 91);

        public LoginForm()
        {
            InitializeComponent();

            //автоматическое подстраивание отключили, теперь мы указываем сами какая ширина и высота будет
            this.loginField.AutoSize = false;
            this.loginField.Size = new Size(this.loginField.Size.Width, 64);
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);

            loginField.Text = "Введите логин";
            loginField.ForeColor = _colorHint;
            passField.Text = "Введите пароль";
            passField.ForeColor = _colorHint;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(61, 74, 77);
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = _colorText;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = _colorHint;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (!passField.UseSystemPasswordChar)
            {
                passField.Text = "";
                passField.ForeColor = _colorText;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = _colorHint;
            }
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = passField.Text != "Введите пароль";
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            /*
            // получение данных от пользователя
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            // подключение к БД
            DB db = new DB();
            
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // объект для выборки данных из БД, запрос с заглушками
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            // меняем заглушки на переменные
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            // выбрали нужную команду и выполнили её, поместили внутрь объекта table
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // проверяем соответствие веденных данных с данными БД
            if (table.Rows.Count > 0)
            {
                this.Hide();
                FormGame15 formGame15 = new FormGame15();
                formGame15.ShowDialog();
                this.Close();
            }
               // MessageBox.Show("Пользователь авторизован");
            else 
                MessageBox.Show("Пользователь не авторизован");
            */
            // подключение к БД
            DB db = new DB();

            if (db.Login(loginField.Text, passField.Text))
            {
                this.Hide();
                FormGame15 formGame15 = new FormGame15();
                formGame15.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Пользователь не авторизован");
        }

        private void registerLabel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
