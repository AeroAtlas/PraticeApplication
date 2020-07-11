using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticeApplication
{
    public partial class Frm_CreateCharacter : Form
    {
        public Frm_CreateCharacter()
        {
            InitializeComponent();
        }

        private void Frm_CreateCharacter_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_CharacterSave_Click(object sender, EventArgs e)
        {
            // Test: Make sure we can get all text
            String[] data = new string[3];
            data[0] = Txt_CharacterName.Text; //Get Name
            data[1] = (string)(this.Rdo_SexMale.Checked ? "Male" : "Female"); //Get Sex
            data[2] = Cbox_CharacterClass.Text;
            String output = "Name: " + data[0] + "\nGender: " + data[1] + "\nClass: " + data[2];

            // Test output
            MessageBox.Show(output);
        }
    }
}
