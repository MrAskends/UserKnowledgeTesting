
namespace Client
{
    partial class FormMain
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
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelOverallRating = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastname.Location = new System.Drawing.Point(12, 9);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(83, 19);
            this.labelLastname.TabIndex = 0;
            this.labelLastname.Text = "Фамилия : ";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstname.Location = new System.Drawing.Point(12, 28);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(48, 19);
            this.labelFirstname.TabIndex = 1;
            this.labelFirstname.Text = "Имя : ";
            // 
            // labelOverallRating
            // 
            this.labelOverallRating.AutoSize = true;
            this.labelOverallRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOverallRating.Location = new System.Drawing.Point(12, 47);
            this.labelOverallRating.Name = "labelOverallRating";
            this.labelOverallRating.Size = new System.Drawing.Size(107, 19);
            this.labelOverallRating.TabIndex = 2;
            this.labelOverallRating.Text = "Ваш рейтинг : ";
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Image = global::Client.Properties.Resources.Settings;
            this.buttonSettings.Location = new System.Drawing.Point(294, 6);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(64, 64);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(188, 93);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(170, 27);
            this.comboBoxSubjects.TabIndex = 4;
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTest.Location = new System.Drawing.Point(188, 126);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(170, 40);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "Перейти к тесту";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonRating
            // 
            this.buttonRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRating.Location = new System.Drawing.Point(12, 93);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(170, 73);
            this.buttonRating.TabIndex = 6;
            this.buttonRating.Text = "Показать мой рейтинг по предметам";
            this.buttonRating.UseVisualStyleBackColor = true;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 175);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelOverallRating);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelLastname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud testing";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelOverallRating;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonRating;
    }
}