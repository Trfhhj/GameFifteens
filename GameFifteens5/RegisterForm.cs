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
    public partial class RegisterForm : Form
    {
        private Color _colorHint = Color.FromArgb(107, 122, 126);
        private Color _colorText = Color.FromArgb(73, 89, 91);

        public RegisterForm()
        {
            InitializeComponent();

            //автоматическое подстраивание отключили, теперь мы указываем сами какая ширина и высота будет
            this.userNameField.AutoSize = false;
            this.userNameField.Size = new Size(this.userNameField.Size.Width, 64);
            this.userSurnameField.AutoSize = false;
            this.userSurnameField.Size = new Size(this.userSurnameField.Size.Width, 64);
            this.loginField.AutoSize = false;
            this.loginField.Size = new Size(this.loginField.Size.Width, 64);
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = _colorHint;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = _colorHint;
            loginField.Text = "Введите логин";
            loginField.ForeColor = _colorHint;
            passField.Text = "Введите пароль";
            passField.ForeColor = _colorHint;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = _colorText;
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

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = _colorText;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = _colorHint;
            }

        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userNameField.ForeColor = _colorText;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = _colorHint;
            }
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (passField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();

            this.Close();
        }

        // проверяем существует ли пользователь
        public Boolean isUserExists()
        {
            // подключение к БД
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // объект для выборки данных из БД, запрос с заглушками
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            // меняем заглушки на переменные
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            // выбрали нужную команду и выполнили её, поместили внутрь объекта table
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // проверяем соответствие веденных данных с данными БД
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }

            else
                return false;
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
