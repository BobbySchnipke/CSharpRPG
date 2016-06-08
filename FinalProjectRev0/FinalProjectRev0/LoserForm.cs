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
    public partial class LoserForm : Form
    {
        public LoserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tryagainButton_Click(object sender, EventArgs e)
        {
            // return to start menu
                StartScreen StartScreen = new StartScreen();
                this.Hide();
                StartScreen.ShowDialog();
                this.Close();
            }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tryagainButton_MouseMove(object sender, MouseEventArgs e)
        {
            // Change colors for mouse over effect
            tryagainButton.ForeColor = Color.Lime;
            tryagainButton.FlatAppearance.BorderColor = Color.Lime;
        }

        private void tryagainButton_MouseLeave(object sender, EventArgs e)
        {
            // Change colors for mouse over effect
            tryagainButton.ForeColor = Color.White;
            tryagainButton.FlatAppearance.BorderColor = Color.White;
        }

        private void quitButton_MouseMove(object sender, MouseEventArgs e)
        {
            // Change colors for mouse over effect
            quitButton.ForeColor = Color.Red;
            quitButton.FlatAppearance.BorderColor = Color.Red;
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            // Change colors for mouse over effect
            quitButton.ForeColor = Color.White;
            quitButton.FlatAppearance.BorderColor = Color.White;
        }
    }
    }
