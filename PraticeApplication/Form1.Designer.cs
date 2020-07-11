namespace PraticeApplication
{
    partial class Form_Menu
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
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_CreateCharacter = new System.Windows.Forms.Button();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.Font = new System.Drawing.Font("the unseen", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GameTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_GameTitle.Location = new System.Drawing.Point(136, 9);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(271, 38);
            this.Lbl_GameTitle.TabIndex = 0;
            this.Lbl_GameTitle.Text = "RPG Game Title";
            this.Lbl_GameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_CreateCharacter
            // 
            this.Btn_CreateCharacter.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CreateCharacter.Location = new System.Drawing.Point(143, 88);
            this.Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            this.Btn_CreateCharacter.Size = new System.Drawing.Size(264, 45);
            this.Btn_CreateCharacter.TabIndex = 1;
            this.Btn_CreateCharacter.Text = "Create Character";
            this.Btn_CreateCharacter.UseVisualStyleBackColor = false;
            this.Btn_CreateCharacter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_LoadGame.Location = new System.Drawing.Point(143, 172);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(264, 47);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = false;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(551, 411);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Btn_CreateCharacter);
            this.Controls.Add(this.Lbl_GameTitle);
            this.Name = "Form_Menu";
            this.Text = "RPG Game";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_CreateCharacter;
        private System.Windows.Forms.Button Btn_LoadGame;
    }
}

