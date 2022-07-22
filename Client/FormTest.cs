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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            Main.testFormClosing = false;
        }

        int questionNumber = 0; // Создаем счетчик вопросов
        List<Question> test = new List<Question>(10); // Создаем список вопросов из 10 элементов
        bool[] questionsCorrectness = new bool[10]; // Создаем массив с правильными и неправильными ответами

        private void FormTest_VisibleChanged(object sender, EventArgs e)
        {
            CreateTest(); // Заполняем тест вопросами
            labelFirstname.Text += Main.user.firstname; // В лейбл записываем имя залогиненного юзера
            labelLastname.Text += Main.user.lastname; // В лейбл записываем фамилию залогиненного юзера
            if (Main.user.subjectScores.ContainsKey(Main.subject.subjectName))
                labelSelectedSubjectRating.Text += Main.user.subjectScores[Main.subject.subjectName]; // В лейбл записываем рейтинг залогиненного юзера по выбранному предмету
            else
                labelSelectedSubjectRating.Text += "0"; // В лейбл записываем 0, если пользователь не проходил тест по этой теме
            labelSubject.Text += Main.subject.subjectName; // В лейбл записываем тему выбранного теста
            labelQuestionsCounter.Text = "Вопрос " + (questionNumber + 1) + " из 10"; // В лейбл счетчика вопросов записываем номер вопроса
            textBoxQuestion.Text = test[questionNumber].question; // В вопрос записываем первый вопрос
            labelAnswerA.Text = test[questionNumber].a; // В вариант ответов А записываем вариант ответа
            labelAnswerB.Text = test[questionNumber].b; // В вариант ответов B записываем вариант ответа
            labelAnswerC.Text = test[questionNumber].c; // В вариант ответов C записываем вариант ответа
            labelAnswerD.Text = test[questionNumber].d; // В вариант ответов D записываем вариант ответа
        }

        private void CreateTest() // Метод для генерации теста
        {
            Random rnd = new Random(); // Создаем объект класса Random
            for (int i = 0; i <= 10; i++) // Заполняем список случайными вопросами
            {
                do
                {
                    int questionid = rnd.Next(0, 25); // Выбираем случайный вопрос
                    if (!test.Contains(Main.subject.questionsList[questionid])) // Проверяем есть ли он уже в списке
                    {
                        test.Add(Main.subject.questionsList[questionid]); // Добавляем в список этот вопрос
                    }
                }
                while (test.Count < i); // Пока ячейки не существует повторяем действие по добавлению вопроса
            }
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (!(checkBoxAnswerA.Checked || checkBoxAnswerB.Checked || checkBoxAnswerC.Checked || checkBoxAnswerD.Checked)) // Проверяем точно ли был выбран хоть 1 вариант ответа
            {
                MessageBox.Show("Вы не выбрали ни один вариант ответа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (test[questionNumber].correctAnswer) // Проверка выбранного ответа на правильность
                {
                    case "a":
                        if (checkBoxAnswerA.Checked)
                            questionsCorrectness[questionNumber] = true;
                        else
                            questionsCorrectness[questionNumber] = false;
                        break;
                    case "b":
                        if (checkBoxAnswerB.Checked)
                            questionsCorrectness[questionNumber] = true;
                        else
                            questionsCorrectness[questionNumber] = false;
                        break;
                    case "c":
                        if (checkBoxAnswerC.Checked)
                            questionsCorrectness[questionNumber] = true;
                        else
                            questionsCorrectness[questionNumber] = false;
                        break;
                    case "d":
                        if (checkBoxAnswerD.Checked)
                            questionsCorrectness[questionNumber] = true;
                        else
                            questionsCorrectness[questionNumber] = false;
                        break;
                }
                if(questionNumber == 8) // Если это последний вопрос
                {
                    buttonNextQuestion.Text = "Завершить тест"; // переименовываем кнопку
                }
                if (questionNumber < 9) // Проверяем не закончился ли тест
                {
                    questionNumber++; // Переходим к следующему вопросу
                    labelQuestionsCounter.Text = "Вопрос " + (questionNumber + 1) + " из 10"; // В лейбл счетчика вопросов записываем номер вопроса
                    textBoxQuestion.Text = test[questionNumber].question; // В вопрос записываем следующий вопрос
                    labelAnswerA.Text = test[questionNumber].a; // В вариант ответов А записываем вариант ответа
                    labelAnswerB.Text = test[questionNumber].b; // В вариант ответов B записываем вариант ответа
                    labelAnswerC.Text = test[questionNumber].c; // В вариант ответов C записываем вариант ответа
                    labelAnswerD.Text = test[questionNumber].d; // В вариант ответов D записываем вариант ответа
                    checkBoxAnswerA.Checked = false; // Очищаем чекбокс А
                    checkBoxAnswerB.Checked = false; // Очищаем чекбокс B
                    checkBoxAnswerC.Checked = false; // Очищаем чекбокс C
                    checkBoxAnswerD.Checked = false; // Очищаем чекбокс D
                }
                else
                {
                    int correctAnswers = 0; // Поле для подсчета верных ответов
                    int wrongAnswers = 0; // Поле для подсчета неверных ответов
                    for (int i = 0; i < 10; i++) // Проходим по всему массиву с верными и неверными ответами
                    {
                        if (questionsCorrectness[i]) // Если ответ верен,
                            correctAnswers++; // добавляем единицу в счетчик правильных ответов
                        else // Если нет 
                            wrongAnswers++; // Добавляем единицу в счетчик неправильных ответов
                    }
                    if (Main.user.subjectScores.ContainsKey(Main.subject.subjectName)) // Если в словаре уже есть данные по выбранной теме
                    {
                        if (Main.user.subjectScores[Main.subject.subjectName] > correctAnswers) // Если пользователь набрал меньше очков чем его рекорд
                        {
                            MessageBox.Show("Правильных ответов : " + correctAnswers + "\nНеправильных ответов : " + wrongAnswers +
                            "\nВаш рекорд по теме " + Main.subject.subjectName + " : " + Main.user.subjectScores[Main.subject.subjectName] +
                            "\nРезультат не будет перезаписан, так как у Вас были попытки и получше...", "Тест завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (Main.user.subjectScores[Main.subject.subjectName] < correctAnswers) // Если пользователь набрал больше очков чем его рекорд
                            {
                                MessageBox.Show("Правильных ответов : " + correctAnswers + "\nНеправильных ответов : " + wrongAnswers +
                                "\nВы побили свой рекорд! Ваш предыдущий рекорд по теме " + Main.subject.subjectName + " : " + Main.user.subjectScores[Main.subject.subjectName],
                                "Тест завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Main.user.subjectScores[Main.subject.subjectName] = correctAnswers; // Записываем в словарь новое значение рекорда
                                Main.server.SendPacketRequest();
                            }
                            else // Если пользователь набрал столько же очков сколько составляет его рекорд
                            {
                                MessageBox.Show("Правильных ответов : " + correctAnswers + "\nНеправильных ответов : " + wrongAnswers +
                                "\nВы набрали столько же очков, сколько составляет Ваш предыдущий рекорд по теме " + Main.subject.subjectName + " : " +
                                Main.user.subjectScores[Main.subject.subjectName], "Тест завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else // Если пользователь ни разу не проходил тест по выбранной теме
                    {
                        Main.user.subjectScores.Add(Main.subject.subjectName, correctAnswers); // Добавляем пользователю очки за тест
                        MessageBox.Show("Правильных ответов : " + correctAnswers + " Неправильных ответов : " + wrongAnswers + "\n Ваш новый рекорд по теме " + Main.subject.subjectName +
                        " : " + correctAnswers, "Тест завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main.server.SendPacketRequest();
                    }
                    Form mainForm = Application.OpenForms[0];
                    Main.mainFormShowing = true;
                    mainForm.Show(); // Показываем главную форму
                    Main.testFormClosing = true;
                    this.Close();
                }
            }
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

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.testFormClosing)
            {
                Application.Exit();
            }
        }
    }
}
