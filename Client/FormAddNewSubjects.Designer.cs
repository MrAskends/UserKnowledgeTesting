
namespace Client
{
    partial class FormAddNewSubjects
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
            this.textBoxNewSubject = new System.Windows.Forms.TextBox();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.labelAddNewSubject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNewSubject
            // 
            this.textBoxNewSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewSubject.Location = new System.Drawing.Point(12, 25);
            this.textBoxNewSubject.Name = "textBoxNewSubject";
            this.textBoxNewSubject.Size = new System.Drawing.Size(335, 26);
            this.textBoxNewSubject.TabIndex = 0;
            this.textBoxNewSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSubject.Location = new System.Drawing.Point(12, 57);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(335, 36);
            this.buttonAddSubject.TabIndex = 1;
            this.buttonAddSubject.Text = "Добавить новый предмет";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 99);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(335, 36);
            this.buttonBackToMainMenu.TabIndex = 2;
            this.buttonBackToMainMenu.Text = "Вернуться в главное меню";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // labelAddNewSubject
            // 
            this.labelAddNewSubject.AutoSize = true;
            this.labelAddNewSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddNewSubject.Location = new System.Drawing.Point(56, 4);
            this.labelAddNewSubject.Name = "labelAddNewSubject";
            this.labelAddNewSubject.Size = new System.Drawing.Size(249, 19);
            this.labelAddNewSubject.TabIndex = 3;
            this.labelAddNewSubject.Text = "Введите название нового предмета";
            // 
            // FormAddNewSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 147);
            this.Controls.Add(this.labelAddNewSubject);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.textBoxNewSubject);
            this.Name = "FormAddNewSubjects";
            this.Text = "Cloud Testing Add A New Subject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddNewSubjects_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewSubject;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Label labelAddNewSubject;
    }
}