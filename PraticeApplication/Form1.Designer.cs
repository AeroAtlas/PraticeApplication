namespace PraticeApplication
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_CreateCharacter = new System.Windows.Forms.Button();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.Btn_Options = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_GameTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_GameTitle.Font = new System.Drawing.Font("the unseen", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GameTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_GameTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_GameTitle.Location = new System.Drawing.Point(110, 58);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(458, 65);
            this.Lbl_GameTitle.TabIndex = 0;
            this.Lbl_GameTitle.Text = "RPG Game Title";
            this.Lbl_GameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_CreateCharacter
            // 
            this.Btn_CreateCharacter.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CreateCharacter.Location = new System.Drawing.Point(202, 218);
            this.Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            this.Btn_CreateCharacter.Size = new System.Drawing.Size(264, 45);
            this.Btn_CreateCharacter.TabIndex = 1;
            this.Btn_CreateCharacter.Text = "New Game";
            this.Btn_CreateCharacter.UseVisualStyleBackColor = false;
            this.Btn_CreateCharacter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_LoadGame.Location = new System.Drawing.Point(202, 269);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(264, 47);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = false;
            // 
            // Btn_Options
            // 
            this.Btn_Options.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Options.Location = new System.Drawing.Point(202, 322);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(264, 47);
            this.Btn_Options.TabIndex = 3;
            this.Btn_Options.Text = "Options";
            this.Btn_Options.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PraticeApplication.Properties.Resources.black;
            this.pictureBox1.Location = new System.Drawing.Point(286, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PraticeApplication.Properties.Resources.a3;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Btn_CreateCharacter);
            this.Controls.Add(this.Lbl_GameTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.Text = "RPG Game";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_CreateCharacter;
        private System.Windows.Forms.Button Btn_LoadGame;
        private System.Windows.Forms.Button Btn_Options;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

