using PraticeApplication.CharacterClasses;
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
//using PracticeApplication.CharacterClasses; is unnecissary 

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
            //Make default character
            Student player1 = new Student();
            MessageBox.Show("You are a Student with " + player1.Strength.ToString() + ".", "New Student");

            // Test: Make sure we can get all text
            String[] data = new string[3];

            // Check if Name is valid
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) ||
                Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character and name must not start with a space");
                return;
            } else
            {
                data[0] = Txt_CharacterName.Text; //Get Name
            }

            //Check if sex has been picked
            if(!this.Rdo_SexFemale.Checked && !this.Rdo_SexMale.Checked)
            {
                MessageBox.Show("You must select your sex");
                return;
            } else
            {
                data[1] = (string)(this.Rdo_SexMale.Checked ? "Male" : "Female"); //Get Sex
            }

            //Check if class has been picked
            if (string.IsNullOrEmpty(Cbox_CharacterClass.Text))
            {

            } else
            {
                data[2] = Cbox_CharacterClass.Text;
            }

            //data[0] = Txt_CharacterName.Text; //Get Name
            //data[1] = (string)(this.Rdo_SexMale.Checked ? "Male" : "Female"); //Get Sex
            //data[2] = Cbox_CharacterClass.Text;

            //Create player character with specific class
            switch(data[2])
            {
            case "student":
                Student player2 = new Student();
                MessageBox.Show("You are a Student with " + player2.Strength.ToString() + "strength.", "New Student");
                break;
            case "worker":
                Worker player2 = new Worker();
                MessageBox.Show("You are a Student with " + player2.Strength.ToString() + "strength.", "New Worker");
                break;
            };

            String output = "Name: " + data[0] + "\nGender: " + data[1] + "\nClass: " + data[2];

            // Test output
            MessageBox.Show(output);
        }
    }
}
