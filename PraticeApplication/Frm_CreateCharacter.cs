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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
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
            //Student player1 = new Student();
            //MessageBox.Show("You are a Student with " + player1.Strength.ToString() + ".", "New Student");

            // Test: Make sure we can get all text
            String[] data = new string[3];

            // Check if Name is valid
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) ||
                Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character and name must not start with a space");
                return;
            }
            //Check if sex has been picked
            if (!this.Rdo_SexFemale.Checked && !this.Rdo_SexMale.Checked)
            {
                MessageBox.Show("You must select your sex");
                return;
            }
            //Check if class has been picked
            if (string.IsNullOrEmpty(Cbox_CharacterClass.Text))
            {
                MessageBox.Show("You must select your class");
                return;
            }

            //Add the values to the data array
            data[0] = Txt_CharacterName.Text; //Get Name
            data[1] = (string)(this.Rdo_SexMale.Checked ? "Male" : "Female"); //Get Sex
            data[2] = Cbox_CharacterClass.Text;

            //Create EntitySex variable
            EntitySex eSex;
            switch (data[1].ToLower())
            {
                case "male":
                    eSex = EntitySex.Male;
                    break;
                case "female":
                    eSex = EntitySex.Female;
                    break;
                default:
                    eSex = EntitySex.Unknown;
                    break;
            }

            //Create EntityClass variable
            EntityClass eClass;
            switch (data[2].ToLower())
            {
                case "student":
                    eClass = EntityClass.Student;
                    break;
                case "worker":
                    eClass = EntityClass.Worker;
                    break;
                case "cop":
                    eClass = EntityClass.Cop;
                    break;
                case "criminal":
                    eClass = EntityClass.Criminal;
                    break;
                default:
                    eClass = EntityClass.Unknown;
                    break;
            };


            //Create example player
            Player player1 = new Player(data[0], eSex, eClass);

            String output1 = String.Format("{0} has been created. " +
                "\nThey are a {1} {2}", player1.Name.ToString(), player1.Sex.ToString(), player1.CharacterClass.ToString());

            //Creates output string using the data[0..3]
            String output2 = String.Format("{0} has been created.\nThey are a {1} {2}", data[0], data[1], data[2]);

            //Create output string using whole player to string
            String output3 = player1.ToString();

            // Show output
            MessageBox.Show(output1, "Success");

            //Store Character
            FileManager.StoreCharacter(player1);

            //
            CharacterID stats = new CharacterID();
            stats.Show();

            // Close the window
            this.Close();
        }

        
    }
}
