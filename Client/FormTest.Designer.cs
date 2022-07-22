
namespace Client
{
    partial class FormTest
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
            this.labelSelectedSubjectRating = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.checkBoxAnswerA = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerB = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerC = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerD = new System.Windows.Forms.CheckBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelQuestionsCounter = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelAnswerA = new System.Windows.Forms.Label();
            this.labelAnswerB = new System.Windows.Forms.Label();
            this.labelAnswerC = new System.Windows.Forms.Label();
            this.labelAnswerD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSelectedSubjectRating
            // 
            this.labelSelectedSubjectRating.AutoSize = true;
            this.labelSelectedSubjectRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedSubjectRating.Location = new System.Drawing.Point(12, 47);
            this.labelSelectedSubjectRating.Name = "labelSelectedSubjectRating";
            this.labelSelectedSubjectRating.Size = new System.Drawing.Size(159, 19);
            this.labelSelectedSubjectRating.TabIndex = 5;
            this.labelSelectedSubjectRating.Text = "Ваш рейтинг по теме: ";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstname.Location = new System.Drawing.Point(12, 28);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(48, 19);
            this.labelFirstname.TabIndex = 4;
            this.labelFirstname.Text = "Имя : ";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastname.Location = new System.Drawing.Point(12, 9);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(83, 19);
            this.labelLastname.TabIndex = 3;
            this.labelLastname.Text = "Фамилия : ";
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNextQuestion.Location = new System.Drawing.Point(226, 417);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(192, 62);
            this.buttonNextQuestion.TabIndex = 6;
            this.buttonNextQuestion.Text = "Следующий вопрос";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // checkBoxAnswerA
            // 
            this.checkBoxAnswerA.AutoSize = true;
            this.checkBoxAnswerA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerA.Location = new System.Drawing.Point(15, 226);
            this.checkBoxAnswerA.MaximumSize = new System.Drawing.Size(600, 0);
            this.checkBoxAnswerA.Name = "checkBoxAnswerA";
            this.checkBoxAnswerA.Size = new System.Drawing.Size(39, 23);
            this.checkBoxAnswerA.TabIndex = 7;
            this.checkBoxAnswerA.Text = "A";
            this.checkBoxAnswerA.UseVisualStyleBackColor = true;
            this.checkBoxAnswerA.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // checkBoxAnswerB
            // 
            this.checkBoxAnswerB.AutoSize = true;
            this.checkBoxAnswerB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerB.Location = new System.Drawing.Point(15, 274);
            this.checkBoxAnswerB.MaximumSize = new System.Drawing.Size(612, 50);
            this.checkBoxAnswerB.Name = "checkBoxAnswerB";
            this.checkBoxAnswerB.Size = new System.Drawing.Size(38, 23);
            this.checkBoxAnswerB.TabIndex = 8;
            this.checkBoxAnswerB.Text = "B";
            this.checkBoxAnswerB.UseVisualStyleBackColor = true;
            this.checkBoxAnswerB.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // checkBoxAnswerC
            // 
            this.checkBoxAnswerC.AutoSize = true;
            this.checkBoxAnswerC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerC.Location = new System.Drawing.Point(15, 322);
            this.checkBoxAnswerC.MaximumSize = new System.Drawing.Size(612, 50);
            this.checkBoxAnswerC.Name = "checkBoxAnswerC";
            this.checkBoxAnswerC.Size = new System.Drawing.Size(39, 23);
            this.checkBoxAnswerC.TabIndex = 9;
            this.checkBoxAnswerC.Text = "C";
            this.checkBoxAnswerC.UseVisualStyleBackColor = true;
            this.checkBoxAnswerC.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // checkBoxAnswerD
            // 
            this.checkBoxAnswerD.AutoSize = true;
            this.checkBoxAnswerD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswerD.Location = new System.Drawing.Point(15, 370);
            this.checkBoxAnswerD.MaximumSize = new System.Drawing.Size(612, 50);
            this.checkBoxAnswerD.Name = "checkBoxAnswerD";
            this.checkBoxAnswerD.Size = new System.Drawing.Size(39, 23);
            this.checkBoxAnswerD.TabIndex = 10;
            this.checkBoxAnswerD.Text = "D";
            this.checkBoxAnswerD.UseVisualStyleBackColor = true;
            this.checkBoxAnswerD.CheckedChanged += new System.EventHandler(this.checkBoxAnswer_CheckedChanged);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuestion.Location = new System.Drawing.Point(15, 146);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(605, 73);
            this.textBoxQuestion.TabIndex = 11;
            this.textBoxQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelQuestionsCounter
            // 
            this.labelQuestionsCounter.AutoSize = true;
            this.labelQuestionsCounter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestionsCounter.Location = new System.Drawing.Point(256, 124);
            this.labelQuestionsCounter.Name = "labelQuestionsCounter";
            this.labelQuestionsCounter.Size = new System.Drawing.Size(110, 19);
            this.labelQuestionsCounter.TabIndex = 12;
            this.labelQuestionsCounter.Text = "Вопрос 0 из 10";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubject.Location = new System.Drawing.Point(12, 85);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(48, 19);
            this.labelSubject.TabIndex = 13;
            this.labelSubject.Text = "Тема: ";
            // 
            // labelAnswerA
            // 
            this.labelAnswerA.AutoSize = true;
            this.labelAnswerA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnswerA.Location = new System.Drawing.Point(60, 226);
            this.labelAnswerA.MaximumSize = new System.Drawing.Size(562, 38);
            this.labelAnswerA.Name = "labelAnswerA";
            this.labelAnswerA.Size = new System.Drawing.Size(0, 19);
            this.labelAnswerA.TabIndex = 14;
            // 
            // labelAnswerB
            // 
            this.labelAnswerB.AutoSize = true;
            this.labelAnswerB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnswerB.Location = new System.Drawing.Point(60, 274);
            this.labelAnswerB.MaximumSize = new System.Drawing.Size(562, 38);
            this.labelAnswerB.Name = "labelAnswerB";
            this.labelAnswerB.Size = new System.Drawing.Size(0, 19);
            this.labelAnswerB.TabIndex = 15;
            // 
            // labelAnswerC
            // 
            this.labelAnswerC.AutoSize = true;
            this.labelAnswerC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnswerC.Location = new System.Drawing.Point(60, 322);
            this.labelAnswerC.MaximumSize = new System.Drawing.Size(562, 38);
            this.labelAnswerC.Name = "labelAnswerC";
            this.labelAnswerC.Size = new System.Drawing.Size(0, 19);
            this.labelAnswerC.TabIndex = 16;
            // 
            // labelAnswerD
            // 
            this.labelAnswerD.AutoSize = true;
            this.labelAnswerD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnswerD.Location = new System.Drawing.Point(60, 370);
            this.labelAnswerD.MaximumSize = new System.Drawing.Size(562, 38);
            this.labelAnswerD.Name = "labelAnswerD";
            this.labelAnswerD.Size = new System.Drawing.Size(0, 19);
            this.labelAnswerD.TabIndex = 17;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 491);
            this.Controls.Add(this.labelAnswerD);
            this.Controls.Add(this.labelAnswerC);
            this.Controls.Add(this.labelAnswerB);
            this.Controls.Add(this.labelAnswerA);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelQuestionsCounter);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.checkBoxAnswerD);
            this.Controls.Add(this.checkBoxAnswerC);
            this.Controls.Add(this.checkBoxAnswerB);
            this.Controls.Add(this.checkBoxAnswerA);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.labelSelectedSubjectRating);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelLastname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud testing test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTest_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormTest_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectedSubjectRating;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.CheckBox checkBoxAnswerA;
        private System.Windows.Forms.CheckBox checkBoxAnswerB;
        private System.Windows.Forms.CheckBox checkBoxAnswerC;
        private System.Windows.Forms.CheckBox checkBoxAnswerD;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelQuestionsCounter;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelAnswerA;
        private System.Windows.Forms.Label labelAnswerB;
        private System.Windows.Forms.Label labelAnswerC;
        private System.Windows.Forms.Label labelAnswerD;
    }
}