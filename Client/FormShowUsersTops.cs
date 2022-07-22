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
    public partial class FormShowUsersTops : Form
    {
        public FormShowUsersTops()
        {
            InitializeComponent();
            Main.ShowUsersTopsFormClosing = false;
        }

        private void FormShowUsersTops_VisibleChanged(object sender, EventArgs e)
        {
            foreach (string subjectName in Main.allSubjectsNames) // Проходим по всему списку и добавляем все доступные тесты в комбобокс
            {
                comboBoxSubjects.Items.Add(subjectName); // Записываем в комбобокс subjectName
            }
        }

        private void buttonShowTop_Click(object sender, EventArgs e)
        {
            Main.server.SendPacketRequest(comboBoxSubjects.Text, true); // Отправляем запрос на сервер
            foreach(KeyValuePair<string, int> kvp in Main.usersTop) // Проходим по всему словарю
            {
                listBoxTop.Items.Add(kvp.Key + " : " + kvp.Value + " очка(ов)"); // И добавляем значения в листбокс
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            Main.mainFormShowing = true;
            mainForm.Show(); // Показываем главную форму
            Main.ShowUsersTopsFormClosing = true;
            this.Close();
        }

        private void FormShowUsersTops_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.ShowUsersTopsFormClosing)
            {
                Application.Exit();
            }
        }
    }
}
