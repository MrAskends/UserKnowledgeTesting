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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            Main.SettingsFormClosing = false;
        }

        private void buttonAddSubjectsAndQuestions_Click(object sender, EventArgs e)
        {
            buttonAddSubjects.Visible = true; // Показываем кнопку для добавления нового предмета
            buttonAddQuestions.Visible = true; // Показываем кнопку для добавления новых вопросов к предметам
            buttonAddSubjectsAndQuestions.Visible = false; // Скрываем кнопку добавления вопросов и предетов
            buttonShowUsersScores.Visible = false; // Скрываем кнопку показа топов игроков
            /*FormAddSubjectsAndQuestions AddSubjectsAndQuestionsForm = new FormAddSubjectsAndQuestions(); // Создание формы для добавления вопросов и тем
            AddSubjectsAndQuestionsForm.Show(); // Открытие формы для добавления вопросов и тем
            Main.SettingsFormClosing = true;
            this.Close();*/
        }

        private void buttonbuttonShowUsersScores_Click(object sender, EventArgs e)
        {
            FormShowUsersTops ShowUsersTopsForm = new FormShowUsersTops(); // Создание формы для показа топов пользователей по темам
            ShowUsersTopsForm.Show(); // Открытие формы для показа топов пользователей по темам
            Main.SettingsFormClosing = true;
            this.Close();
        }

        private void buttonAddSubjects_Click(object sender, EventArgs e)
        {
            FormAddNewSubjects AddNewSubjectsForm = new FormAddNewSubjects(); // Создание формы для добавления тем
            AddNewSubjectsForm.Show(); // Открытие формы для добавления тем
            Main.SettingsFormClosing = true;
            this.Close();
        }

        private void buttonAddQuestions_Click(object sender, EventArgs e)
        {
            FormAddNewQuestions AddNewQuestionsForm = new FormAddNewQuestions(); // Создание формы для добавления вопросов
            AddNewQuestionsForm.Show(); // Открытие формы для добавления вопросов
            Main.SettingsFormClosing = true;
            this.Close();
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.SettingsFormClosing)
            {
                Application.Exit();
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            Main.mainFormShowing = true;
            mainForm.Show(); // Показываем главную форму
            Main.SettingsFormClosing = true;
            this.Close();
        }
    }
}
