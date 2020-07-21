namespace PraticeApplication
{
    partial class CharacterID
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
            this.Lbl_ShowName = new System.Windows.Forms.Label();
            this.Lbl_ShowSex = new System.Windows.Forms.Label();
            this.Lbl_ShowClass = new System.Windows.Forms.Label();
            this.Btn_DoneStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_ShowName
            // 
            this.Lbl_ShowName.AutoSize = true;
            this.Lbl_ShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lbl_ShowName.Location = new System.Drawing.Point(46, 42);
            this.Lbl_ShowName.Name = "Lbl_ShowName";
            this.Lbl_ShowName.Size = new System.Drawing.Size(182, 26);
            this.Lbl_ShowName.TabIndex = 0;
            this.Lbl_ShowName.Text = "Name Goes Here";
            // 
            // Lbl_ShowSex
            // 
            this.Lbl_ShowSex.AutoSize = true;
            this.Lbl_ShowSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lbl_ShowSex.Location = new System.Drawing.Point(49, 94);
            this.Lbl_ShowSex.Name = "Lbl_ShowSex";
            this.Lbl_ShowSex.Size = new System.Drawing.Size(161, 26);
            this.Lbl_ShowSex.TabIndex = 1;
            this.Lbl_ShowSex.Text = "Sex Goes Here";
            this.Lbl_ShowSex.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_ShowClass
            // 
            this.Lbl_ShowClass.AutoSize = true;
            this.Lbl_ShowClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Lbl_ShowClass.Location = new System.Drawing.Point(46, 148);
            this.Lbl_ShowClass.Name = "Lbl_ShowClass";
            this.Lbl_ShowClass.Size = new System.Drawing.Size(178, 26);
            this.Lbl_ShowClass.TabIndex = 2;
            this.Lbl_ShowClass.Text = "Class Goes Here";
            // 
            // Btn_DoneStats
            // 
            this.Btn_DoneStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Btn_DoneStats.Location = new System.Drawing.Point(51, 340);
            this.Btn_DoneStats.Name = "Btn_DoneStats";
            this.Btn_DoneStats.Size = new System.Drawing.Size(75, 38);
            this.Btn_DoneStats.TabIndex = 3;
            this.Btn_DoneStats.Text = "Done";
            this.Btn_DoneStats.UseVisualStyleBackColor = true;
            this.Btn_DoneStats.Click += new System.EventHandler(this.Btn_DoneStats_Click);
            // 
            // CharacterID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_DoneStats);
            this.Controls.Add(this.Lbl_ShowClass);
            this.Controls.Add(this.Lbl_ShowSex);
            this.Controls.Add(this.Lbl_ShowName);
            this.Name = "CharacterID";
            this.Text = "Character Stats";
            this.Load += new System.EventHandler(this.Frm_CharacterID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ShowName;
        private System.Windows.Forms.Label Lbl_ShowSex;
        private System.Windows.Forms.Label Lbl_ShowClass;
        private System.Windows.Forms.Button Btn_DoneStats;
    }
}