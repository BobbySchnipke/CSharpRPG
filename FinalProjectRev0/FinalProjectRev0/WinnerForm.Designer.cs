namespace TurnBasedBattleGame
{
    partial class WinnerForm
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
            this.youWinLabel = new System.Windows.Forms.Label();
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // youWinLabel
            // 
            this.youWinLabel.AutoSize = true;
            this.youWinLabel.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youWinLabel.ForeColor = System.Drawing.Color.Lime;
            this.youWinLabel.Location = new System.Drawing.Point(299, 214);
            this.youWinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.youWinLabel.Name = "youWinLabel";
            this.youWinLabel.Size = new System.Drawing.Size(595, 142);
            this.youWinLabel.TabIndex = 1;
            this.youWinLabel.Text = "You Win!";
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.AutoSize = true;
            this.congratulationsLabel.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratulationsLabel.ForeColor = System.Drawing.Color.Lime;
            this.congratulationsLabel.Location = new System.Drawing.Point(195, 121);
            this.congratulationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.Size = new System.Drawing.Size(788, 95);
            this.congratulationsLabel.TabIndex = 0;
            this.congratulationsLabel.Text = "Congratulations";
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Gray;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(705, 423);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(363, 213);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Leave a Champion";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            this.quitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.quitButton_MouseMove);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Gray;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.Color.White;
            this.playAgainButton.Location = new System.Drawing.Point(220, 423);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(363, 213);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Press Your Luck";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            this.playAgainButton.MouseLeave += new System.EventHandler(this.playAgainButton_MouseLeave);
            this.playAgainButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playAgainButton_MouseMove);
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1232, 800);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.congratulationsLabel);
            this.Controls.Add(this.youWinLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "WinnerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winner!!!!!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label youWinLabel;
        private System.Windows.Forms.Label congratulationsLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button playAgainButton;
    }
}