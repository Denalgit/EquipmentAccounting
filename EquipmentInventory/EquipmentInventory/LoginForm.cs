using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentInventory
{
    public partial class LoginForm : Form
    {
        private DataBase database = new DataBase();

        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClearFields()
        {
            LoginField.Text = "";
            PassField.Text = "";
            PassField.UseSystemPasswordChar = false;
            LoginField.Text = ("Введите логин");
            LoginField.ForeColor = Color.Gray;
            PassField.Text = ("Введите пароль");
            PassField.ForeColor = Color.Gray;
        }

        // Кнопка входа
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var loginUser = LoginField.Text;
            var passwordUser = md5.hashPassword(PassField.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT IdUser, LoginUser, PasswordUser, IsAdmin FROM UserAccount WHERE LoginUser = '{loginUser}' AND PasswordUser = '{passwordUser}'";
            
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                var user = new CheckUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm Main = new MainForm(user);
                ClearFields();
                Hide();
                Main.ShowDialog();
                Show();
            }
            else if (LoginField.Text == "" || PassField.Text == "" || LoginField.Text == "Введите логин" || PassField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите логин и пароль!", "Не все данные заполнены!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
  
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Кнопка отображения пароля
        private void pictureBoxView_Click(object sender, EventArgs e)
        {
            PassField.UseSystemPasswordChar = false;
            pictureBoxView.Visible = false;
            pictureBoxNoView.Visible = true;
        }

        // Кнопка сокрытия пароля
        private void pictureBoxNoView_Click(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.UseSystemPasswordChar = false;
            }
            else
            {
                PassField.UseSystemPasswordChar = true;
            }
            pictureBoxView.Visible = true;
            pictureBoxNoView.Visible = false;
        }

        // Загрузка формы авторизации
        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBoxNoView.Visible = false;
            PassField.AutoSize = false;
            LoginField.AutoSize = false;
            PassField.UseSystemPasswordChar = false;
            PassField.Size = new Size(PassField.Size.Width, 39);
            LoginField.Size = new Size(LoginField.Size.Width, 39);
            LoginField.Text = ("Введите логин");
            LoginField.ForeColor = Color.Gray;
            PassField.Text = ("Введите пароль");
            PassField.ForeColor = Color.Gray;
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Введите логин")
            {
                LoginField.Clear();
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginField.Text))
            {
                LoginField.Text = "Введите логин";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.UseSystemPasswordChar = true;
                PassField.Clear();
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassField.Text))
            {
                PassField.UseSystemPasswordChar = false;
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;
            }
        }
    }
}
