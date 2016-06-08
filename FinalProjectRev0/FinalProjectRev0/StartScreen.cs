using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnBasedBattleGame
{
    public partial class StartScreen : Form
    {
        //public Player1 player;

        //declare variables for the inputted attributes they must be public static so they
        // can be accessed on the GamePlayForm
        public static int health;
        public static int attack;
        public static int magic;
        public static int defense;
        public static string name;

        // The following 4 attributes are set here so they can be used in toolTips
        // Set the amount of attribute lost by the player everytime an ability is used
        public static int playerMagicDrain = 5;
        public static int playerDefenseDrain = 5;
        // Set the amount of attribute lost by the ai every time an ability is used
        public static int aiMagicDrain = 5;
        public static int aiDefenseDrain = 5;

        public StartScreen()
        {
            InitializeComponent();
            copyRightLabel.Text = "\u00a9 2016 Bobby Schnipke";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
           {
            //after pressing the start button make sure the users inputs are integers
            if (int.TryParse(healthTextBox.Text, out health))
            {
                if (int.TryParse(attackTextBox.Text, out attack))
                {
                    if (int.TryParse(magicTextBox.Text, out magic))
                    {
                        if (int.TryParse(defenseTextBox.Text, out defense))
                        {
                            //validate that all attributes equal no more than 200 total
                            if (health + attack + magic + defense <= 200)
                            {
                                //move text from NameTextBox to variable name to be put into GamePlayForm
                                name = NameTextBox.Text;
                                //once all validation is complete the GamePlayForm will open 
                                //and all relevant info will be transferred
                                GamePlayForm GamePlayForm = new GamePlayForm();
                                //hide the current StartScreen form, but do not close it
                                this.Hide();

                                //display the GamePlayForm
                                GamePlayForm.ShowDialog();

                                //close the StartScreen form when GamePlayForm is exited so the entire program is terminated
                                this.Close();
                            }
                            else { MessageBox.Show("Total of all attributes can not be more than 200"); }
                        }
                        else { MessageBox.Show("please enter only numbers for defense"); } 
                        }
                    else { MessageBox.Show("please enter only numbers for magic"); }
                }
                else { MessageBox.Show("please enter only numbers for attack"); }
            }
            else { MessageBox.Show("please enter only numbers for health"); }
        }

        // Everything below this line sets hover messages instructing how each attribute will affect gameplay for the player
        private void Health_MouseHover(object sender, EventArgs e)
        {
            {
                healthToolTip.SetToolTip(healthLabel, "Determines the amount of health "+
                    "the player will start with.");
            }
        }

        private void Attack_MouseHover(object sender, EventArgs e)
        {
            {
               attackToolTip.SetToolTip(attackLabel, "Determines power of attacks." +
                    Environment.NewLine +
                    "The player will deal 25-50% of attack attribute to enemy");
            }
        }

        private void Magic_MouseHover(object sender, EventArgs e)
        {
            {
                magicToolTip.SetToolTip(magicLabel, "Determines the amount of magic " +
                    "the player will start with. " + Environment.NewLine +
                    "Every time the player uses magic it will consume " + playerMagicDrain.ToString() +
                    " magic.");
            }
        }

        private void Defense_MouseHover(object sender, EventArgs e)
        {
            {
                defenseToolTip.SetToolTip(defenseLabel, "Determines the amount of defense " +
                    "the player will start with. " + Environment.NewLine +
                    "Everytime the player uses defense it will consume " + playerDefenseDrain.ToString() +
                    " magic.");
            }
        }

        private void healthTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
