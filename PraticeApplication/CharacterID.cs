﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PraticeApplication.CharacterClasses;

namespace PraticeApplication
{
    public partial class CharacterID : Form
    {
        public CharacterID()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_CharacterID_Load(object sender, EventArgs e)
        {
            Player p1 = new Player();
            p1 = FileManager.LoadPlayer();
            Lbl_ShowName.Text = p1.Name;
            Lbl_ShowSex.Text = p1.Sex.ToString();
            Lbl_ShowClass.Text = p1.CharacterClass.ToString();

        }

        private void Btn_DoneStats_Click(object sender, EventArgs e)
        {
            Frm_Menu home = new Frm_Menu();
            home.Show();
            this.Hide();
        }
    }
}
