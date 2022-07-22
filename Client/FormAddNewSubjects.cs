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
    public partial class FormAddNewSubjects : Form
    {
        public FormAddNewSubjects()
        {
            InitializeComponent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            Main.mainFormShowing = true;
            mainForm.Show(); // Показываем главную форму
            Main.AddSubjectsFormClosing = true;
            this.Close();
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            if(textBoxNewSubject.Text == "")
            {
                MessageBox.Show("Название предмета не может быть короче 1 символа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main.server.SendPacketRequest(textBoxNewSubject.Text); // Отправляем на сервер название нового предмета
                MessageBox.Show("Предмет " + textBoxNewSubject.Text + " успешно добавлен.", "Добавление темы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNewSubject.Text = ""; // Очищаем текстбокс
            }
        }
        private void FormAddNewSubjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !Main.AddSubjectsFormClosing)
            {
                Application.Exit();
            }
        }
    }
}
