using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnBasedBattleGame;

namespace TurnBasedBattleGame
{
    public partial class GamePlayForm : Form
    {
        //public Player1 player;
        //pull the values from the StartScreen that were input by the user
        //these values will be the players current attributes
        int health = StartScreen.health;
        int attack = StartScreen.attack;
        int magic = StartScreen.magic;
        int defense = StartScreen.defense;
        string name = StartScreen.name;

        //set the attributes for the computer player
        int enemyHealth = 100;
        int enemyAttack = 50;
        int enemyMagic = 25;
        int enemyDefense = 25;

        //set the variables for any effects that are used.
        //the number a potion or effect equals is how many turns it will last.
        int defensePotion = 0;
        int strengthPotion = 0;

        int enemyDefensePotion = 0;
        int enemyStrengthPotion = 0;

        int defend = 0;
        int aiDefense = 0;

        // Set the amount of attribute lost by the player everytime an ability is used
        int playerMagicDrain = StartScreen.playerMagicDrain;
        int playerDefenseDrain = StartScreen.playerMagicDrain;

        // Set the amount of attribute lost by the ai every time an ability is used
        int aiMagicDrain = StartScreen.aiMagicDrain;
        int aiDefenseDrain = StartScreen.aiDefenseDrain;

        // Set the amounts that a player reaches low health and critical health
        int lowHealth = 20;
        int criticalHealth = 10;

        public GamePlayForm()
        {
            InitializeComponent();


            //display the current amount of each attribute for the player in their respective labels
            HealthAvailableLabel.Text = health.ToString();
            AttackAvailableLabel.Text = attack.ToString();
            MagicAvailableLabel.Text = magic.ToString();
            DefenseAvailableLabel.Text = defense.ToString();

            //display the current amount of each attribute for the enemy in their respective labels
            EnemyHealthAvailableLabel.Text = enemyHealth.ToString();
            EnemyAttackAvailableLabel.Text = enemyAttack.ToString();
            EnemyMagicAvailableLabel.Text = enemyMagic.ToString();
            EnemyDefenseAvailableLabel.Text = enemyDefense.ToString();

            //display the player's name as the groupbox text
            PlayerGroupBox.Text = name;

            //Set values of the health progress bar

            //Check is enemyHealth is set to over 100
            // if it is set progress bar to 100
            if (enemyHealth <= 100)
            {
                enemyHealthProgressBar.Value = enemyHealth;
            }
            else
            {
                enemyHealthProgressBar.Value = 100;
            }

            // Check if player has set health to over 100
            // if they have, make sure the bar only goes to 100 to avoid an error
            if (health >= 100)
            {
                playerHealthBar.Value = 100;
            }
            else
            {
                playerHealthBar.Value = health;
            }
        }


        private void GamePlayForm_Load(object sender, EventArgs e)
        {
        }

        private void GamePlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void GamePlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void PlayerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        /*********************************************************************
        *
        * Everything below this comment to the aiDefend method is ai actions
        *
        *********************************************************************/

        private void aiTurn()
        {
            int aiMove;

            // if ai is at or below 3 health he will always heal on his turn
            if (enemyHealth <= 3)
            {
                aiMove = 1;
            }
            // first check to make sure the AI has enough magic and defense
            // to use those turns
            else if (enemyMagic >= aiMagicDrain && enemyDefense >= aiDefenseDrain)
            {
                // get a random number between 1 and 4. The number will
                // determine what move the ai will make during their turn.
                Random rnd = new Random();
                aiMove = rnd.Next(1, 5);
            }
            else if (enemyMagic < aiMagicDrain && enemyDefense < aiDefenseDrain)
            {
                // if there is not enough magic and defense a random between 1 and 2
                // will only be generated
                Random rnd = new Random();
                aiMove = rnd.Next(1, 3);

            }
            else
            {
                // Else if either magic OR defense is depleted, 
                // only a random number from 1-3 will be generated
                Random rnd = new Random();
                aiMove = rnd.Next(1, 4);
            }


            switch (aiMove)
            {
                case 1:
                    aiHeal();
                    // call PlayerEffects method to reduce the effects the player is using
                    PlayerEffects();
                    break;

                case 2:
                    aiAttack();
                    // call PlayerEffects method to reduce the effects the player is using
                    PlayerEffects();
                    break;

                case 3:
                    // if statement to see if aiMagic is depleted. If it is
                    // depleted aiDefend will be used instead
                    if (enemyMagic >= aiMagicDrain)
                    {
                        aiMagic();
                    }
                    else
                    {
                        aiDefend();
                    }
                    // call PlayerEffects method to reduce the effects the player is using
                    PlayerEffects();
                    break;

                case 4:
                    aiDefend();
                    // call PlayerEffects method to reduce the effects the player is using
                    PlayerEffects();
                    break;
            }
        }

        private void aiHeal()
        {
            // Get a random number from 5 - 20 whatever random number
            // is selected is the amount of health that will be added to
            // the AI
            Random rnd = new Random();
            int healthRestored = rnd.Next(5, 21);
            enemyHealth += healthRestored;

            //Display how much health was restored in the actions listbox
            string template = "Your enemy has restored {0} health";
            string data = healthRestored.ToString();
            string message = string.Format(template, data);
            actionsListBox.Items.Add(message);
            actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;

            // change the display to reflect the new amount of health
            EnemyHealthAvailableLabel.Text = enemyHealth.ToString();

            // if player heals to above low or critical hp change color accordingly
            if (enemyHealth > criticalHealth)
            {
                EnemyHealthAvailableLabel.ForeColor = Color.Gold;
            }
            if (enemyHealth > lowHealth)
            {
               EnemyHealthAvailableLabel.ForeColor = Color.Lime;

            }

            // check to make sure enemy health is not over 100
            if (enemyHealth <= 100)
            {
                enemyHealthProgressBar.Value = enemyHealth;
            }
            else
            {
                enemyHealthProgressBar.Value = 100;
            }
        }

        private void aiAttack()
        {
            // Get a random number from 25% - 50% of attack attribute
            // the number that is selected is the amount of damage done
            // to the player before effects are taken into account
            int minDamage = enemyAttack / 4;
            int maxDamage = enemyAttack / 2;

            Random rnd = new Random();
            int damageDealt = rnd.Next(minDamage, maxDamage + 1);

            // before calculating actual damage done to player all strength and 
            // defense effects must be taken into account. 
            // Strength potion will be the first thing taken into account
            // so attacks will be strengthened before they are weakened by defense effects

            if (enemyStrengthPotion > 0)
            {
                damageDealt += damageDealt / 3;
            }

            if (defend > 0)
            {
                damageDealt = damageDealt / 2;
            }
            if (defensePotion > 0)
            {
                damageDealt -= damageDealt / 3;
            }

            health -= damageDealt;

            //Display how much damage was done in the actions box
            string template = "Your enemy attacked you! You lost {0} health";
            string data = damageDealt.ToString();
            string message = string.Format(template, data);
            actionsListBox.Items.Add(message);
            actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;

            // change the display to reflect the new amount of health
            // if health is below 0 just show 0
            if (health >= 0)
            {
                HealthAvailableLabel.Text = health.ToString();
            }
            else
            {
                EnemyHealthAvailableLabel.Text = "0";
            }

            // Check if player has over 100 health or under 0
            // if they have either, make sure the bar gets set to 0 or 100 to avoid an error
            if (health >= 100)
            {
                playerHealthBar.Value = 100;
            }
            else if (health <= 0)
            {
                playerHealthBar.Value = 0;
            }
            else
            {
                playerHealthBar.Value = health;
            }

            // check if player health is gone take the player to the loser form
            if (health <= 0)
            {
                //MessageBox.Show("Oh no, you lost! Better luck next time!");
                LoserForm LoserForm = new LoserForm();
                this.Hide();
                LoserForm.ShowDialog();
                this.Close();
            }

            // check if player health is at or below low and critical levels
            // then change color of label accordingly
            if (health <= lowHealth)
            {
                HealthAvailableLabel.ForeColor = Color.Gold;
            }
            if (health <= criticalHealth)
            {
                HealthAvailableLabel.ForeColor = Color.Red;
            }

        }

        private void aiMagic()
        {

                // subtract 5 from enemyMagic
                enemyMagic -= 5;
                EnemyMagicAvailableLabel.Text = enemyMagic.ToString();

                // Get a random number of 1 or 2, this number will decide if the enemy
                // uses a strength or healing potion
                Random rnd = new Random();
                int magicChoice = rnd.Next(1, 3);

                // if magicChoice == 1 execute strength potion
                if (magicChoice == 1)
                {
                enemyStrengthPotion += 3;

                    //Display how many turns the strength potion will last in the actions box
                    string template = "Your opponent has increased strength by 33% for {0} turns";
                    string data = enemyStrengthPotion.ToString();
                    string message = string.Format(template, data);
                    actionsListBox.Items.Add(message);
                    actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;
            }
                else
                {   
                    enemyDefensePotion += 3;
                    //Display how many turns the defense potion will last in the actions box
                    string template = "Your enemy has increased defense by 33% for {0} turns";
                    string data = enemyDefensePotion.ToString();
                    string message = string.Format(template, data);
                    actionsListBox.Items.Add(message);
                    actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;
            }

        }

        private void aiDefend()
        {
                // subtract 5 from enemyDefense
                enemyDefense -= 5;
                EnemyDefenseAvailableLabel.Text = enemyDefense.ToString();
                //increase defend for 2 turns.
                aiDefense += 2;;
                //Display how many turns the defense potion will last in the actions box
                string template = "Your enemy has increased defense by 50% for {0} turns";
                string data = aiDefense.ToString();
                string message = string.Format(template, data);
                actionsListBox.Items.Add(message);
                actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;
            }

        //*************************************************************************************
        //
        // The 2 methods below will be called at the end of turns to reduce 
        // the effects the player and AI have equipped
        //
        //**************************************************************************************
        private void PlayerEffects()
        {
            // this method will decrease any effects the player has by 1 turn
            if (enemyDefensePotion > 0)
            {
                enemyDefensePotion -= 1;
            }
            if (defend > 0)
            {
                defend -= 1;
            }
            if (enemyStrengthPotion > 0)
            {
                enemyStrengthPotion -= 1;
            }
        }

        private void aiEffects()
        {
            // this method will decrease any effects the ai has by 1 turn
            if (defensePotion > 0)
            {
                defensePotion -= 1;
            }
            if (aiDefense > 0)
            {
                aiDefense -= 1;
            }
            if (strengthPotion > 0)
            {
                strengthPotion -= 1;
            }
        }

        /*********************************************************************
        *
        * Everything below this comment is input from the user
        *
        *********************************************************************/

        private void AttackButton_Click(object sender, EventArgs e)
        {
            // Get a random number from 25% - 50% of attack attribute
            // the number that is selected is the amount of damage done
            // to the enemy before effects are taken into account
            int minDamage = attack / 4;
            int maxDamage = attack / 2;

            Random rnd = new Random();
            int damageDealt = rnd.Next(minDamage, maxDamage + 1);
            
            // before calculating actual damage done to enemy all strength and 
            // defense effects must be taken into account. 
            // Strength potion will be the first thing taken into account
            // so attacks will be strengthened before they are weakened by defense effects

            if (strengthPotion > 0)
            {
                damageDealt += damageDealt / 3;
            }

            if (aiDefense > 0)
            {
                damageDealt = damageDealt / 2;
            }
            if (enemyDefensePotion > 0)
            {
                damageDealt -= damageDealt / 3; 
            }

            enemyHealth -= damageDealt;

            //Display a dialog box to show how much damages was done to the enemy
            string template = "You have done {0} damage to your enemy";
            string data = damageDealt.ToString();
            string message = string.Format(template, data);
            
            actionsListBox.Items.Add(message);
            actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;

            // change the display to reflect the new amount of health the enemy has
            // if enemy is below 0 health just display 0 for health
            if (enemyHealth >= 0)
            {
                EnemyHealthAvailableLabel.Text = enemyHealth.ToString();
            }
            else
            {
                EnemyHealthAvailableLabel.Text = "0";
            }
            // check if enemy health is at or below low and critical levels
            // then change color of label accordingly
            if (enemyHealth <= lowHealth)
            {
                EnemyHealthAvailableLabel.ForeColor = Color.Gold;
            }
            if (enemyHealth <= criticalHealth)
            {
                EnemyHealthAvailableLabel.ForeColor = Color.Red;
            }

            //Check if enemy health is below 0 or above 100
            // if it is either, set value to 0 or 100
            if (enemyHealth >= 100)
            {
                enemyHealthProgressBar.Value = 100;
            }
            else if (enemyHealth <= 0)
            {
                enemyHealthProgressBar.Value = 0;
            }
            else
            {
                enemyHealthProgressBar.Value = enemyHealth;
            }

            // Check if AI has any health left. If AI does have health left allow them to take a turn
            // otherwise, declare player the winner, end the game, and go back to start screen
            if (enemyHealth > 0)
            {
                // decrease enemy effects before aiTurn begins
                aiEffects();
                aiTurn();
            }
            else
            {
                //MessageBox.Show("Congratulations, you win! You are a bad mamajama!");
                WinnerForm WinnerForm = new WinnerForm();
                this.Hide();
                WinnerForm.ShowDialog();
                this.Close();
                
            }
        }

        private void HealButton_Click(object sender, EventArgs e)
        {
            // Get a random number from 5 - 20 whatever random number
            // is selected is the amount of health that will be added to
            // the player
            Random rnd = new Random();
            int healthRestored = rnd.Next(5, 21);
            health += healthRestored;

            //Display much health was restored in a dialog box
            string template = "You have successfully restored {0} health";
            string data = healthRestored.ToString();
            string message = string.Format(template, data);
            actionsListBox.Items.Add(message);
            actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;

            // change the display to reflect the new amount of health
            HealthAvailableLabel.Text = health.ToString();

            // Check if player has over 100 health
            // if they have, make sure the bar only goes to 100 to avoid an error
            if (health >= 100)
            {
                playerHealthBar.Value = 100;
            }
            else
            {
                playerHealthBar.Value = health;
            }


            // if player heals to above low or critical hp change color accordingly
            if (health > criticalHealth)
            {
                HealthAvailableLabel.ForeColor = Color.Gold;
            }
            if (health > lowHealth)
            {
                HealthAvailableLabel.ForeColor = Color.Lime;
            }

            // decrease enemy effects before aiTurn begins
            aiEffects();

            // execute AI turn
            aiTurn();

        }

        private void MagicButton_Click(object sender, EventArgs e)
        {
            // check if popup box is already showing, if it is not show it and perform normal actions
            if (MagicGroupBox.Visible == false)
            {
                if (magic >= playerMagicDrain)
                {
                    MagicGroupBox.Visible = true;
                    MagicGroupBox.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You do not have enough magic left to use a potion!");
                }
            }
            // if popup menu is already open, close it.
            else
            {
                //close the popup menu for potions
                MagicGroupBox.Visible = false;
                MagicGroupBox.Enabled = false;
            }
        }

        private void strengthButton_Click(object sender, EventArgs e)
        {
            strengthPotion += 3;
            //Display how many turns the strength potion will last in the actions box
            string template = "You will increase damage by 33% for {0} turns";
            string data = strengthPotion.ToString();
            string message = string.Format(template, data);
            actionsListBox.Items.Add(message);
            actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;

            //clsoe the popup menu for potions
            MagicGroupBox.Visible = false;
            MagicGroupBox.Enabled = false;

            // subtract the playerMagicDrain from current magic stat
            magic -= playerMagicDrain;

            MagicAvailableLabel.Text = magic.ToString();

            // decrease enemy effects before aiTurn begins
            aiEffects();

            // execute AI turn
            aiTurn();
        }

        private void defensePotionButton_Click(object sender, EventArgs e)
        {
            defensePotion += 3;
            //Display how many turns the defense potion will last in the actions box
            string template = "You have increased your defense by 33% for {0} turns";
            string data = defensePotion.ToString();
            string message = string.Format(template, data);
            actionsListBox.Items.Add(message);
            actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;

            //clsoe the popup menu for potions
            MagicGroupBox.Visible = false;
            MagicGroupBox.Enabled = false;

            // subtract playerMagicDrain from magic
            magic -= playerMagicDrain;

            MagicAvailableLabel.Text = magic.ToString();

            // decrease enemy effects before aiTurn begins
            aiEffects();

            // execute AI turn
            aiTurn();
        }

        private void DefendButton_Click(object sender, EventArgs e)
            {
            // Check first if user has any defense attributes available
            if (defense >= playerDefenseDrain)
            {
                //increase defend for 2 turns.
                defend += 2;
                // decrease defend potion by 1 to show how long effect will actually last
                // since it is decreased as soon as it is the opponents turn
                // this is only necessary when the player has 0 defend

                //Display how many turns the defense potion will last in the actions box
                string template = "You have increased your defense by 50% for {0} turns";
                string data = defend.ToString();
                string message = string.Format(template, data);
                actionsListBox.Items.Add(message);
                actionsListBox.SelectedIndex = actionsListBox.Items.Count - 1;

                // subtract playerDefenseDrain from defense
                defense -= playerDefenseDrain;

                DefenseAvailableLabel.Text = defense.ToString();

                // decrease enemy effects before aiTurn begins
                aiEffects();

                // execute AI turn
                aiTurn();
            }
            else
            {
                MessageBox.Show("You do not have enough defense left to defend!");
            }
        }

        private void AttackAvailableLabel_Click(object sender, EventArgs e)
        {

        }

        private void EnemyGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
