
namespace Client
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddSubjectsAndQuestions = new System.Windows.Forms.Button();
            this.buttonShowUsersScores = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonAddSubjects = new System.Windows.Forms.Button();
            this.buttonAddQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Что вы хотите сделать?";
            // 
            // buttonAddSubjectsAndQuestions
            // 
            this.buttonAddSubjectsAndQuestions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSubjectsAndQuestions.Location = new System.Drawing.Point(12, 41);
            this.buttonAddSubjectsAndQuestions.Name = "buttonAddSubjectsAndQuestions";
            this.buttonAddSubjectsAndQuestions.Size = new System.Drawing.Size(150, 70);
            this.buttonAddSubjectsAndQuestions.TabIndex = 1;
            this.buttonAddSubjectsAndQuestions.Text = "Добавить новую тему или вопросы";
            this.buttonAddSubjectsAndQuestions.UseVisualStyleBackColor = true;
            this.buttonAddSubjectsAndQuestions.Click += new System.EventHandler(this.buttonAddSubjectsAndQuestions_Click);
            // 
            // buttonShowUsersScores
            // 
            this.buttonShowUsersScores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowUsersScores.Location = new System.Drawing.Point(170, 41);
            this.buttonShowUsersScores.Name = "buttonShowUsersScores";
            this.buttonShowUsersScores.Size = new System.Drawing.Size(150, 70);
            this.buttonShowUsersScores.TabIndex = 2;
            this.buttonShowUsersScores.Text = "Посмотреть рейтинги пользователей";
            this.buttonShowUsersScores.UseVisualStyleBackColor = true;
            this.buttonShowUsersScores.Click += new System.EventHandler(this.buttonbuttonShowUsersScores_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 117);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(308, 40);
            this.buttonBackToMainMenu.TabIndex = 8;
            this.buttonBackToMainMenu.Text = "Вернуться в главное меню";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonAddSubjects
            // 
            this.buttonAddSubjects.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSubjects.Location = new System.Drawing.Point(12, 41);
            this.buttonAddSubjects.Name = "buttonAddSubjects";
            this.buttonAddSubjects.Size = new System.Drawing.Size(150, 70);
            this.buttonAddSubjects.TabIndex = 9;
            this.buttonAddSubjects.Text = "Добавить новые предметы";
            this.buttonAddSubjects.UseVisualStyleBackColor = true;
            this.buttonAddSubjects.Visible = false;
            this.buttonAddSubjects.Click += new System.EventHandler(this.buttonAddSubjects_Click);
            // 
            // buttonAddQuestions
            // 
            this.buttonAddQuestions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddQuestions.Location = new System.Drawing.Point(170, 41);
            this.buttonAddQuestions.Name = "buttonAddQuestions";
            this.buttonAddQuestions.Size = new System.Drawing.Size(150, 70);
            this.buttonAddQuestions.TabIndex = 10;
            this.buttonAddQuestions.Text = "Добавить новые вопросы к предметам";
            this.buttonAddQuestions.UseVisualStyleBackColor = true;
            this.buttonAddQuestions.Visible = false;
            this.buttonAddQuestions.Click += new System.EventHandler(this.buttonAddQuestions_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 167);
            this.Controls.Add(this.buttonAddQuestions);
            this.Controls.Add(this.buttonAddSubjects);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonShowUsersScores);
            this.Controls.Add(this.buttonAddSubjectsAndQuestions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Testing Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddSubjectsAndQuestions;
        private System.Windows.Forms.Button buttonShowUsersScores;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonAddSubjects;
        private System.Windows.Forms.Button buttonAddQuestions;
    }
}