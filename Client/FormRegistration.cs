using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            Main.registrationFormClosing = false;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (CheckDataCorrectness())
            {
                Main.user.userid = -1; // Пользователю задаем значение ID -1
                Main.user.login = textBoxLogin.Text; // Пользователю задаем значение логина который он ввел
                Main.user.password = textBoxPassword.Text; // Пользователю задаем значение пароля который он ввел
                Main.user.firstname = textBoxFirstname.Text; // Пользователю задаем значение имени которую он ввел
                Main.user.lastname = textBoxLastname.Text; // Пользователю задаем значение фамилии которую он ввел
                Main.user.age = Convert.ToInt32(numericUpDownAge.Value); // Пользователю задаем значение возраста который он ввел
                Main.server.SendPacketRequest(); // Отправляем запрос на сервер с введенными данными
                if (Main.user.userid == -1)
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Main.user = new User(); // Очищаем пользователя
                }
                else
                {
                    MessageBox.Show("Вы успешно зарегистрированы!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main.server.SendPacketRequest(); // Отправляем запрос на сервер с введенными данными
                    Form mainForm = Application.OpenForms[0];
                    Main.mainFormShowing = true;
                    mainForm.Show(); // Показываем главную форму
                    Main.registrationFormClosing = true;
                    this.Close();
                }
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms[1];
            loginForm.Show(); // Показываем главную форму
            Main.registrationFormClosing = true;
            this.Close();
        }

        private bool CheckDataCorrectness() // Метод проверки корректности введенных данных
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "" || textBoxPasswordRepeat.Text == "" ||
                textBoxFirstname.Text == "" || textBoxLastname.Text == "" || numericUpDownAge.Value == 0) // Проверка на пустые поля ввода данных
            {
                MessageBox.Show("Одно из полей не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxLogin.Text.Length < 6) // Проверка на длину логина
            {
                MessageBox.Show("логин не может быть короче 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxPassword.Text.Length < 6) // Проверка на длину пароля
            {
                MessageBox.Show("Пароль не может быть короче 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxPassword.Text != textBoxPasswordRepeat.Text) // Проверка на совпадение паролей
            {
                MessageBox.Show("Пароли отличаются.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxFirstname.Text.Length < 2) // Проверка на длину имени
            {
                MessageBox.Show("Имя не может быть короче 2 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxLastname.Text.Length < 2) // Проверка на длину фамилии
            {
                MessageBox.Show("Фамилия не может быть короче 2 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in textBoxFirstname.Text) // Проверка введенных символов в поле для ввода имени
            {
                if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Имя может состоять только из букв.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            foreach (char c in textBoxLastname.Text) // Проверка введенных символов в поле для ввода фамилии
            {
                if (!Char.IsLetter(c))
                {
                    MessageBox.Show("Фамилия может состоять только из букв.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (numericUpDownAge.Value == 0)
            {
                MessageBox.Show("Ясно, пользователю 0 лет..", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToInt32(numericUpDownAge.Value) < 1) // Проверка введенного возраста
            {
                MessageBox.Show("Возраст не может быть меньше 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.registrationFormClosing)
            {
                Application.Exit();
            }
        }
    }
}
