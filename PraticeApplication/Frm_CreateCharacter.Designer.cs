namespace PraticeApplication
{
    partial class Frm_CreateCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CreateCharacter));
            this.Lbl_CharacterName = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.Rdo_SexMale = new System.Windows.Forms.RadioButton();
            this.Gbox_CharacterSex = new System.Windows.Forms.GroupBox();
            this.Rdo_SexFemale = new System.Windows.Forms.RadioButton();
            this.Cbox_CharacterClass = new System.Windows.Forms.ComboBox();
            this.Lbl_CharacterClass = new System.Windows.Forms.Label();
            this.Btn_CharacterSave = new System.Windows.Forms.Button();
            this.Gbox_CharacterSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CharacterName
            // 
            this.Lbl_CharacterName.AutoSize = true;
            this.Lbl_CharacterName.Location = new System.Drawing.Point(28, 22);
            this.Lbl_CharacterName.Name = "Lbl_CharacterName";
            this.Lbl_CharacterName.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CharacterName.TabIndex = 0;
            this.Lbl_CharacterName.Text = "Name";
            this.Lbl_CharacterName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Lbl_CharacterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(69, 22);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(188, 20);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // Rdo_SexMale
            // 
            this.Rdo_SexMale.AutoSize = true;
            this.Rdo_SexMale.Location = new System.Drawing.Point(38, 19);
            this.Rdo_SexMale.Name = "Rdo_SexMale";
            this.Rdo_SexMale.Size = new System.Drawing.Size(48, 17);
            this.Rdo_SexMale.TabIndex = 2;
            this.Rdo_SexMale.TabStop = true;
            this.Rdo_SexMale.Text = "Male";
            this.Rdo_SexMale.UseVisualStyleBackColor = true;
            // 
            // Gbox_CharacterSex
            // 
            this.Gbox_CharacterSex.Controls.Add(this.Rdo_SexFemale);
            this.Gbox_CharacterSex.Controls.Add(this.Rdo_SexMale);
            this.Gbox_CharacterSex.Location = new System.Drawing.Point(31, 89);
            this.Gbox_CharacterSex.Name = "Gbox_CharacterSex";
            this.Gbox_CharacterSex.Size = new System.Drawing.Size(188, 49);
            this.Gbox_CharacterSex.TabIndex = 3;
            this.Gbox_CharacterSex.TabStop = false;
            this.Gbox_CharacterSex.Text = "Sex";
            // 
            // Rdo_SexFemale
            // 
            this.Rdo_SexFemale.AutoSize = true;
            this.Rdo_SexFemale.Location = new System.Drawing.Point(92, 19);
            this.Rdo_SexFemale.Name = "Rdo_SexFemale";
            this.Rdo_SexFemale.Size = new System.Drawing.Size(59, 17);
            this.Rdo_SexFemale.TabIndex = 3;
            this.Rdo_SexFemale.TabStop = true;
            this.Rdo_SexFemale.Text = "Female";
            this.Rdo_SexFemale.UseVisualStyleBackColor = true;
            this.Rdo_SexFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Cbox_CharacterClass
            // 
            this.Cbox_CharacterClass.FormattingEnabled = true;
            this.Cbox_CharacterClass.Items.AddRange(new object[] {
            "Student",
            "Worker",
            "Cop",
            "Criminal"});
            this.Cbox_CharacterClass.Location = new System.Drawing.Point(69, 193);
            this.Cbox_CharacterClass.Name = "Cbox_CharacterClass";
            this.Cbox_CharacterClass.Size = new System.Drawing.Size(188, 21);
            this.Cbox_CharacterClass.TabIndex = 4;
            // 
            // Lbl_CharacterClass
            // 
            this.Lbl_CharacterClass.AutoSize = true;
            this.Lbl_CharacterClass.Location = new System.Drawing.Point(28, 193);
            this.Lbl_CharacterClass.Name = "Lbl_CharacterClass";
            this.Lbl_CharacterClass.Size = new System.Drawing.Size(32, 13);
            this.Lbl_CharacterClass.TabIndex = 5;
            this.Lbl_CharacterClass.Text = "Class";
            this.Lbl_CharacterClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Lbl_CharacterClass.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Btn_CharacterSave
            // 
            this.Btn_CharacterSave.Location = new System.Drawing.Point(31, 252);
            this.Btn_CharacterSave.Name = "Btn_CharacterSave";
            this.Btn_CharacterSave.Size = new System.Drawing.Size(131, 64);
            this.Btn_CharacterSave.TabIndex = 6;
            this.Btn_CharacterSave.Text = "Save Character";
            this.Btn_CharacterSave.UseVisualStyleBackColor = true;
            this.Btn_CharacterSave.Click += new System.EventHandler(this.Btn_CharacterSave_Click);
            // 
            // Frm_CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Btn_CharacterSave);
            this.Controls.Add(this.Lbl_CharacterClass);
            this.Controls.Add(this.Cbox_CharacterClass);
            this.Controls.Add(this.Gbox_CharacterSex);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Lbl_CharacterName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CreateCharacter";
            this.Text = "Create Character";
            this.Load += new System.EventHandler(this.Frm_CreateCharacter_Load);
            this.Gbox_CharacterSex.ResumeLayout(false);
            this.Gbox_CharacterSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharacterName;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.RadioButton Rdo_SexMale;
        private System.Windows.Forms.GroupBox Gbox_CharacterSex;
        private System.Windows.Forms.RadioButton Rdo_SexFemale;
        private System.Windows.Forms.ComboBox Cbox_CharacterClass;
        private System.Windows.Forms.Label Lbl_CharacterClass;
        private System.Windows.Forms.Button Btn_CharacterSave;
    }
}