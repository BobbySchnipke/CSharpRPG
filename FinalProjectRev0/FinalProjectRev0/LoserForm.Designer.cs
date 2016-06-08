namespace TurnBasedBattleGame
{
    partial class LoserForm
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
            this.youLoseLabel = new System.Windows.Forms.Label();
            this.luckLabel = new System.Windows.Forms.Label();
            this.tryagainButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // youLoseLabel
            // 
            this.youLoseLabel.AutoSize = true;
            this.youLoseLabel.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youLoseLabel.ForeColor = System.Drawing.Color.Red;
            this.youLoseLabel.Location = new System.Drawing.Point(239, 137);
            this.youLoseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.youLoseLabel.Name = "youLoseLabel";
            this.youLoseLabel.Size = new System.Drawing.Size(645, 142);
            this.youLoseLabel.TabIndex = 0;
            this.youLoseLabel.Text = "YOU LOSE!";
            this.youLoseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // luckLabel
            // 
            this.luckLabel.AutoSize = true;
            this.luckLabel.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckLabel.ForeColor = System.Drawing.Color.Red;
            this.luckLabel.Location = new System.Drawing.Point(60, 331);
            this.luckLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.luckLabel.Name = "luckLabel";
            this.luckLabel.Size = new System.Drawing.Size(1040, 95);
            this.luckLabel.TabIndex = 1;
            this.luckLabel.Text = "Better luck next time!";
            // 
            // tryagainButton
            // 
            this.tryagainButton.BackColor = System.Drawing.Color.Gray;
            this.tryagainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryagainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryagainButton.ForeColor = System.Drawing.Color.White;
            this.tryagainButton.Location = new System.Drawing.Point(212, 495);
            this.tryagainButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tryagainButton.Name = "tryagainButton";
            this.tryagainButton.Size = new System.Drawing.Size(332, 177);
            this.tryagainButton.TabIndex = 2;
            this.tryagainButton.Text = "Try Again";
            this.tryagainButton.UseVisualStyleBackColor = false;
            this.tryagainButton.Click += new System.EventHandler(this.tryagainButton_Click);
            this.tryagainButton.MouseLeave += new System.EventHandler(this.tryagainButton_MouseLeave);
            this.tryagainButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tryagainButton_MouseMove);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Gray;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(688, 495);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(332, 177);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Leave a Loser";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            this.quitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.quitButton_MouseMove);
            // 
            // LoserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1232, 800);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.tryagainButton);
            this.Controls.Add(this.luckLabel);
            this.Controls.Add(this.youLoseLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LoserForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOSER!!!!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label youLoseLabel;
        private System.Windows.Forms.Label luckLabel;
        private System.Windows.Forms.Button tryagainButton;
        private System.Windows.Forms.Button quitButton;
    }
}