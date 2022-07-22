
namespace Client
{
    partial class FormAddNewQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.checkBoxAnswerD = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerC = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerB = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerA = new System.Windows.Forms.CheckBox();
            this.textBoxAnswerA = new System.Windows.Forms.TextBox();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.labelSelectSubject = new System.Windows.Forms.Label();
            this.textBoxAnswerB = new System.Windows.Forms.TextBox();
            this.textBoxAnswerC = new System.Windows.Forms.TextBox();
            this.textBoxAnswerD = new System.Windows.Forms.TextBox();
            this.labelWriteNewQuestion = new System.Windows.Forms.Label();
            this.labelAnswerOptions = new System.Windows.Forms.Label();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonFinishAdding = new System.Windows.Forms.Button();
            this.labelSubjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuestion.Location = new System.Drawing.Point(12, 83);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(605, 73);
            this.textBoxQuestion.TabIndex = 22;
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxAnswerD
            // 
            this.checkBoxAnswerD.AutoSize = true;
            this.checkBoxAnswerD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerD.Location = new System.Drawing.Point(12, 364);
            this.checkBoxAnswerD.MaximumSize = new System.Drawing.Size(612, 50);
            this.checkBoxAnswerD.Name = "checkBoxAnswerD";
            this.checkBoxAnswerD.Size = new System.Drawing.Size(39, 23);
            this.checkBoxAnswerD.TabIndex = 21;
            this.checkBoxAnswerD.Text = "D";
            this.checkBoxAnswerD.UseVisualStyleBackColor = true;
            this.checkBoxAnswerD.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // checkBoxAnswerC
            // 
            this.checkBoxAnswerC.AutoSize = true;
            this.checkBoxAnswerC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerC.Location = new System.Drawing.Point(12, 308);
            this.checkBoxAnswerC.MaximumSize = new System.Drawing.Size(612, 50);
            this.checkBoxAnswerC.Name = "checkBoxAnswerC";
            this.checkBoxAnswerC.Size = new System.Drawing.Size(39, 23);
            this.checkBoxAnswerC.TabIndex = 20;
            this.checkBoxAnswerC.Text = "C";
            this.checkBoxAnswerC.UseVisualStyleBackColor = true;
            this.checkBoxAnswerC.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // checkBoxAnswerB
            // 
            this.checkBoxAnswerB.AutoSize = true;
            this.checkBoxAnswerB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerB.Location = new System.Drawing.Point(12, 252);
            this.checkBoxAnswerB.MaximumSize = new System.Drawing.Size(612, 50);
            this.checkBoxAnswerB.Name = "checkBoxAnswerB";
            this.checkBoxAnswerB.Size = new System.Drawing.Size(38, 23);
            this.checkBoxAnswerB.TabIndex = 19;
            this.checkBoxAnswerB.Text = "B";
            this.checkBoxAnswerB.UseVisualStyleBackColor = true;
            this.checkBoxAnswerB.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // checkBoxAnswerA
            // 
            this.checkBoxAnswerA.AutoSize = true;
            this.checkBoxAnswerA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerA.Location = new System.Drawing.Point(12, 195);
            this.checkBoxAnswerA.MaximumSize = new System.Drawing.Size(600, 0);
            this.checkBoxAnswerA.Name = "checkBoxAnswerA";
            this.checkBoxAnswerA.Size = new System.Drawing.Size(39, 23);
            this.checkBoxAnswerA.TabIndex = 18;
            this.checkBoxAnswerA.Text = "A";
            this.checkBoxAnswerA.UseVisualStyleBackColor = true;
            this.checkBoxAnswerA.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // textBoxAnswerA
            // 
            this.textBoxAnswerA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswerA.Location = new System.Drawing.Point(57, 181);
            this.textBoxAnswerA.Multiline = true;
            this.textBoxAnswerA.Name = "textBoxAnswerA";
            this.textBoxAnswerA.Size = new System.Drawing.Size(560, 50);
            this.textBoxAnswerA.TabIndex = 23;
            this.textBoxAnswerA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(220, 31);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(170, 27);
            this.comboBoxSubjects.TabIndex = 24;
            this.comboBoxSubjects.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSubjects_SelectionChangeCommitted);
            // 
            // labelSelectSubject
            // 
            this.labelSelectSubject.AutoSize = true;
            this.labelSelectSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectSubject.Location = new System.Drawing.Point(111, 9);
            this.labelSelectSubject.Name = "labelSelectSubject";
            this.labelSelectSubject.Size = new System.Drawing.Size(390, 19);
            this.labelSelectSubject.TabIndex = 25;
            this.labelSelectSubject.Text = "Выберите тему в которую будет добавлен новый вопрос";
            // 
            // textBoxAnswerB
            // 
            this.textBoxAnswerB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswerB.Location = new System.Drawing.Point(57, 237);
            this.textBoxAnswerB.Multiline = true;
            this.textBoxAnswerB.Name = "textBoxAnswerB";
            this.textBoxAnswerB.Size = new System.Drawing.Size(560, 50);
            this.textBoxAnswerB.TabIndex = 26;
            this.textBoxAnswerB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAnswerC
            // 
            this.textBoxAnswerC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswerC.Location = new System.Drawing.Point(57, 293);
            this.textBoxAnswerC.Multiline = true;
            this.textBoxAnswerC.Name = "textBoxAnswerC";
            this.textBoxAnswerC.Size = new System.Drawing.Size(560, 50);
            this.textBoxAnswerC.TabIndex = 27;
            this.textBoxAnswerC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAnswerD
            // 
            this.textBoxAnswerD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswerD.Location = new System.Drawing.Point(57, 349);
            this.textBoxAnswerD.Multiline = true;
            this.textBoxAnswerD.Name = "textBoxAnswerD";
            this.textBoxAnswerD.Size = new System.Drawing.Size(560, 50);
            this.textBoxAnswerD.TabIndex = 28;
            this.textBoxAnswerD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWriteNewQuestion
            // 
            this.labelWriteNewQuestion.AutoSize = true;
            this.labelWriteNewQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWriteNewQuestion.Location = new System.Drawing.Point(12, 61);
            this.labelWriteNewQuestion.Name = "labelWriteNewQuestion";
            this.labelWriteNewQuestion.Size = new System.Drawing.Size(180, 19);
            this.labelWriteNewQuestion.TabIndex = 29;
            this.labelWriteNewQuestion.Text = "Напишите новый вопрос";
            // 
            // labelAnswerOptions
            // 
            this.labelAnswerOptions.AutoSize = true;
            this.labelAnswerOptions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnswerOptions.Location = new System.Drawing.Point(57, 159);
            this.labelAnswerOptions.Name = "labelAnswerOptions";
            this.labelAnswerOptions.Size = new System.Drawing.Size(498, 19);
            this.labelAnswerOptions.TabIndex = 30;
            this.labelAnswerOptions.Text = "Напишите варианты ответов к этому вопросу и выберите верный ответ";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddQuestion.Location = new System.Drawing.Point(134, 405);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(335, 36);
            this.buttonAddQuestion.TabIndex = 31;
            this.buttonAddQuestion.Text = "Добавить вопрос";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(134, 447);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(335, 36);
            this.buttonBackToMainMenu.TabIndex = 32;
            this.buttonBackToMainMenu.Text = "Вернуться в главное меню";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonFinishAdding
            // 
            this.buttonFinishAdding.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFinishAdding.Location = new System.Drawing.Point(282, 9);
            this.buttonFinishAdding.Name = "buttonFinishAdding";
            this.buttonFinishAdding.Size = new System.Drawing.Size(335, 46);
            this.buttonFinishAdding.TabIndex = 33;
            this.buttonFinishAdding.Text = "Закончить добавление вопросов к этому предмету";
            this.buttonFinishAdding.UseVisualStyleBackColor = true;
            this.buttonFinishAdding.Visible = false;
            this.buttonFinishAdding.Click += new System.EventHandler(this.buttonFinishAdding_Click);
            // 
            // labelSubjectName
            // 
            this.labelSubjectName.AutoSize = true;
            this.labelSubjectName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubjectName.Location = new System.Drawing.Point(12, 42);
            this.labelSubjectName.Name = "labelSubjectName";
            this.labelSubjectName.Size = new System.Drawing.Size(0, 19);
            this.labelSubjectName.TabIndex = 34;
            this.labelSubjectName.Visible = false;
            // 
            // FormAddNewQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 490);
            this.Controls.Add(this.labelSubjectName);
            this.Controls.Add(this.buttonFinishAdding);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.labelAnswerOptions);
            this.Controls.Add(this.labelWriteNewQuestion);
            this.Controls.Add(this.textBoxAnswerD);
            this.Controls.Add(this.textBoxAnswerC);
            this.Controls.Add(this.textBoxAnswerB);
            this.Controls.Add(this.labelSelectSubject);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.textBoxAnswerA);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.checkBoxAnswerD);
            this.Controls.Add(this.checkBoxAnswerC);
            this.Controls.Add(this.checkBoxAnswerB);
            this.Controls.Add(this.checkBoxAnswerA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddNewQuestions";
            this.Text = "Cloud Testing Add New Questions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddNewQuestions_FormClosing);
            this.Shown += new System.EventHandler(this.FormAddNewQuestions_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.CheckBox checkBoxAnswerD;
        private System.Windows.Forms.CheckBox checkBoxAnswerC;
        private System.Windows.Forms.CheckBox checkBoxAnswerB;
        private System.Windows.Forms.CheckBox checkBoxAnswerA;
        private System.Windows.Forms.TextBox textBoxAnswerA;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label labelSelectSubject;
        private System.Windows.Forms.TextBox textBoxAnswerB;
        private System.Windows.Forms.TextBox textBoxAnswerC;
        private System.Windows.Forms.TextBox textBoxAnswerD;
        private System.Windows.Forms.Label labelWriteNewQuestion;
        private System.Windows.Forms.Label labelAnswerOptions;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonFinishAdding;
        private System.Windows.Forms.Label labelSubjectName;
    }
}