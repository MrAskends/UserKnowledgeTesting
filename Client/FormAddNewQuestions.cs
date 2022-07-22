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
    public partial class FormAddNewQuestions : Form
    {
        public FormAddNewQuestions()
        {
            InitializeComponent();
        }

        List<Question> newQuestionsList = new List<Question>(); // Список новых вопросов

        private void FormAddNewQuestions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.AddQuestionsFormClosing)
            {
                Application.Exit();
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            Main.mainFormShowing = true;
            mainForm.Show(); // Показываем главную форму
            Main.AddQuestionsFormClosing = true;
            this.Close();
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали тему теста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Проверка выбрана ли тема теста
                return;
            }
            if(textBoxQuestion.Text == "") // Проверка заполнено ли поле для вопроса
            {
                MessageBox.Show("Поле с вопросом не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxAnswerA.Text == "" || textBoxAnswerB.Text == "" || textBoxAnswerC.Text == "" || textBoxAnswerD.Text == "") // Проверка заполнены ли поля для вариантов ответа
            {
                MessageBox.Show("Одно из полей вариантов ответов не заполнено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!(checkBoxAnswerA.Checked || checkBoxAnswerB.Checked || checkBoxAnswerC.Checked || checkBoxAnswerD.Checked)) // Проверка выбран ли хоть 1 вариант ответа
            {
                MessageBox.Show("Вы не выбрали правильный ответ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string correctAnswer = ""; // Поле для хранения правильного ответа
            if (checkBoxAnswerA.Checked)
                correctAnswer = "a";
            if (checkBoxAnswerB.Checked)
                correctAnswer = "b";
            if (checkBoxAnswerC.Checked)
                correctAnswer = "c";
            if (checkBoxAnswerD.Checked)
                correctAnswer = "d";
            Question newQuestion = new Question(0, textBoxQuestion.Text, textBoxAnswerA.Text, textBoxAnswerB.Text, textBoxAnswerC.Text, textBoxAnswerD.Text, correctAnswer); // Объект класса Question для хранения нового вопроса
            newQuestionsList.Add(newQuestion); // Добавляем новый вопрос в список новых вопросов
            textBoxQuestion.Text = "";
            textBoxAnswerA.Text = "";
            textBoxAnswerB.Text = "";
            textBoxAnswerC.Text = "";
            textBoxAnswerD.Text = "";
            checkBoxAnswerA.Checked = false;
            checkBoxAnswerB.Checked = false;
            checkBoxAnswerC.Checked = false;
            checkBoxAnswerD.Checked = false;
            MessageBox.Show("Вопрос успешно добавлен.", "Добавление вопросов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxAnswer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox changedCheckBox = sender as CheckBox; // Определяем чекбокс и идентифицируем какой чекбокс является sender`ом
            if (changedCheckBox.Checked) // Проверяем поставлена была галочка или снята
            {
                switch (changedCheckBox.Name) // Очищаем все чекбоксы кроме выбранного
                {
                    case "checkBoxAnswerA":
                        checkBoxAnswerB.Checked = false; // Очищаем текстбокс B
                        checkBoxAnswerC.Checked = false; // Очищаем текстбокс C
                        checkBoxAnswerD.Checked = false; // Очищаем текстбокс D
                        break;
                    case "checkBoxAnswerB":
                        checkBoxAnswerA.Checked = false; // Очищаем текстбокс А
                        checkBoxAnswerC.Checked = false; // Очищаем текстбокс C
                        checkBoxAnswerD.Checked = false; // Очищаем текстбокс D
                        break;
                    case "checkBoxAnswerC":
                        checkBoxAnswerA.Checked = false; // Очищаем текстбокс А
                        checkBoxAnswerB.Checked = false; // Очищаем текстбокс B
                        checkBoxAnswerD.Checked = false; // Очищаем текстбокс D
                        break;
                    case "checkBoxAnswerD":
                        checkBoxAnswerA.Checked = false; // Очищаем текстбокс А
                        checkBoxAnswerB.Checked = false; // Очищаем текстбокс B
                        checkBoxAnswerC.Checked = false; // Очищаем текстбокс C
                        break;
                }
            }
        }

        private void comboBoxSubjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            labelSelectSubject.Visible = false;
            comboBoxSubjects.Visible = false;
            labelSubjectName.Text = "Тема : " + comboBoxSubjects.Text;
            labelSubjectName.Visible = true;
            buttonFinishAdding.Visible = true;
        }

        private void buttonFinishAdding_Click(object sender, EventArgs e)
        {
            labelSelectSubject.Visible = true;
            comboBoxSubjects.Visible = true;
            labelSubjectName.Visible = false;
            buttonFinishAdding.Visible = false;
            Subject updatedSubject = new Subject(0, comboBoxSubjects.Text, newQuestionsList);
            comboBoxSubjects.SelectedItem = null;
            Main.server.SendPacketRequest(updatedSubject); // Отправляем пакет с новым списком вопросов
        }

        private void FormAddNewQuestions_Shown(object sender, EventArgs e)
        {
            foreach (string subjectName in Main.allSubjectsNames) // Проходим по всему списку и добавляем все доступные тесты в комбобокс
            {
                comboBoxSubjects.Items.Add(subjectName); // Записываем в комбобокс subjectName
            }
        }
    }
}
