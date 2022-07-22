using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{

    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            Main.loginFormClosing = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "") // Проверка на пустые поля ввода
            {
                MessageBox.Show("Одно из полей не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main.user.login = textBoxLogin.Text; // Пользователю задаем значение логина которые он ввел
                Main.user.password = textBoxPassword.Text; // Пользователю задаем значение пароля которые он ввел
                Main.server.SendPacketRequest(); // Отправляем запрос на сервер с введенными данными
                textBoxLogin.Clear(); // Очищаем текстбокс
                if (Main.user.userid == 0) // Если с сервера пришел ответ с ID пользователя 0, значит сервер не смог найти такого пользователя в БД
                {
                    MessageBox.Show("Логин или пароль неверен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Main.server.SendPacketRequest(); // Отправляем запрос на сервер с введенными данными
                    Form mainForm = Application.OpenForms[0];
                    Main.mainFormShowing = true;
                    mainForm.Show(); // Показываем главную форму
                    Main.loginFormClosing = true;
                    this.Close();
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration registrationForm = new FormRegistration(); // Создание второй формы для регистрации и передача данных с этой формы на вторую
            registrationForm.Show(); // Открытие второй формы
            this.Hide();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.loginFormClosing)
            {
                Application.Exit();
            }
        }
    }
}
