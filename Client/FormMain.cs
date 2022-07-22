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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings SettingsForm = new FormSettings(); // Создание формы для добавления вопросов и тем
            SettingsForm.Show(); // Открытие формы для добавления вопросов и тем
            this.Hide();
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && Main.mainFormShowing)
            {
                if(Main.mainFormFirstShowing) // Если окно показывается первый раз 
                {
                    Main.mainFormFirstShowing = false;
                    if(!Main.user.admin) // Если пользователь не администратор
                    {
                        buttonSettings.Visible = false; // Скрываем кнопку настроек
                    }
                    int overallScores = 0; // Поле для подсчета общего рейтинга пользователя
                    foreach (KeyValuePair<string, int> kvp in Main.user.subjectScores) // Проходим по всему словарю
                    {
                        overallScores += kvp.Value; // И прибавляем рейтинг за каждый пройденный тест
                    }
                    labelFirstname.Text += Main.user.firstname; // В лейбл записываем имя залогиненного юзера
                    labelLastname.Text += Main.user.lastname; // В лейбл записываем фамилию залогиненного юзера
                    labelOverallRating.Text = "Ваш рейтинг : " + overallScores.ToString(); // В лейбл записываем общий рейтинг залогиненного юзера
                    foreach (string subjectName in Main.allSubjectsNames) // Проходим по всему списку и добавляем все доступные тесты в комбобокс
                    {
                        comboBoxSubjects.Items.Add(subjectName); // Записываем в комбобокс subjectName
                    }
                }
                else
                {
                    int overallScores = 0; // Поле для подсчета общего рейтинга пользователя
                    foreach (KeyValuePair<string, int> kvp in Main.user.subjectScores) // Проходим по всему словарю
                    {
                        overallScores += kvp.Value; // И прибавляем рейтинг за каждый пройденный тест
                    }
                    labelOverallRating.Text = "Ваш рейтинг : " + overallScores.ToString();
                    comboBoxSubjects.Items.Clear(); // Очищаем полностью комбобокс
                    foreach (string subjectName in Main.allSubjectsNames) // Проходим по всему списку и добавляем все доступные тесты в комбобокс
                    {
                        comboBoxSubjects.Items.Add(subjectName); // Записываем в комбобокс subjectName
                    }
                }
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                Main.server.PacketConnectToServer(); // Вызывает метод подключения к серверу
                Main.mainFormShowing = false;
                FormLogin loginForm = new FormLogin(); // Создание второй формы для логина и передача данных с этой формы на вторую
                loginForm.Show(); // Открытие второй формы
                this.Hide(); // Эту форму скрываем
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Выводим сообщение об ошбике
                Application.Exit();
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали тему теста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main.server.SendPacketRequest(comboBoxSubjects.Text, false);
                FormTest testForm = new FormTest(); // Создание второй формы для регистрации и передача данных с этой формы на вторую
                testForm.Show(); // Открытие второй формы
                this.Hide();
            }
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            string scoresString = ""; // Строка для хранения рейтинга пользователя
            foreach(KeyValuePair<string, int> kvp in Main.user.subjectScores) // Проходим по всему словарю с очками пользователя
            {
                scoresString += (kvp.Key + " : " + kvp.Value + "\n"); // Прибавляем в строку каждый элемент словаря
            }
            if (scoresString == "") // Если пользователь не прошел ни один тест
            {
                MessageBox.Show("Вы еще не прошли ни одного теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(scoresString, "Ваш рейтинг по предметам", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
