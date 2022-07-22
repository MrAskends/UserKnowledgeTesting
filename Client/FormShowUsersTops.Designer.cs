
namespace Client
{
    partial class FormShowUsersTops
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
            this.components = new System.ComponentModel.Container();
            this.listBoxTop = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.buttonShowTop = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTop
            // 
            this.listBoxTop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTop.FormattingEnabled = true;
            this.listBoxTop.ItemHeight = 19;
            this.listBoxTop.Location = new System.Drawing.Point(12, 91);
            this.listBoxTop.Name = "listBoxTop";
            this.listBoxTop.Size = new System.Drawing.Size(419, 327);
            this.listBoxTop.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(419, 27);
            this.comboBoxSubjects.TabIndex = 5;
            // 
            // buttonShowTop
            // 
            this.buttonShowTop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonShowTop.Location = new System.Drawing.Point(12, 45);
            this.buttonShowTop.Name = "buttonShowTop";
            this.buttonShowTop.Size = new System.Drawing.Size(419, 40);
            this.buttonShowTop.TabIndex = 6;
            this.buttonShowTop.Text = "Показать топ";
            this.buttonShowTop.UseVisualStyleBackColor = true;
            this.buttonShowTop.Click += new System.EventHandler(this.buttonShowTop_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(9, 424);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(419, 40);
            this.buttonBackToMainMenu.TabIndex = 7;
            this.buttonBackToMainMenu.Text = "Вернуться в главное меню";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // FormShowUsersTops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 474);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonShowTop);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.listBoxTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormShowUsersTops";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cloud Testing Users Tops";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShowUsersTops_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormShowUsersTops_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Button buttonShowTop;
        private System.Windows.Forms.Button buttonBackToMainMenu;
    }
}