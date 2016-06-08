namespace TurnBasedBattleGame
{
    partial class StartScreen
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
            this.components = new System.ComponentModel.Container();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.defenseTextBox = new System.Windows.Forms.TextBox();
            this.attackTextBox = new System.Windows.Forms.TextBox();
            this.magicTextBox = new System.Windows.Forms.TextBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.magicLabel = new System.Windows.Forms.Label();
            this.attackLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.healthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.attackToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.magicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.defenseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // healthTextBox
            // 
            this.healthTextBox.BackColor = System.Drawing.Color.Black;
            this.healthTextBox.Font = new System.Drawing.Font("NI7SEG", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthTextBox.ForeColor = System.Drawing.Color.Lime;
            this.healthTextBox.Location = new System.Drawing.Point(507, 256);
            this.healthTextBox.MaxLength = 3;
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(65, 36);
            this.healthTextBox.TabIndex = 1;
            this.healthTextBox.Text = "50";
            this.healthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.healthTextBox.TextChanged += new System.EventHandler(this.healthTextBox_TextChanged);
            // 
            // defenseTextBox
            // 
            this.defenseTextBox.BackColor = System.Drawing.Color.Black;
            this.defenseTextBox.Font = new System.Drawing.Font("NI7SEG", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseTextBox.ForeColor = System.Drawing.Color.Blue;
            this.defenseTextBox.Location = new System.Drawing.Point(508, 382);
            this.defenseTextBox.MaxLength = 3;
            this.defenseTextBox.Name = "defenseTextBox";
            this.defenseTextBox.Size = new System.Drawing.Size(65, 36);
            this.defenseTextBox.TabIndex = 4;
            this.defenseTextBox.Text = "50";
            this.defenseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // attackTextBox
            // 
            this.attackTextBox.BackColor = System.Drawing.Color.Black;
            this.attackTextBox.Font = new System.Drawing.Font("NI7SEG", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackTextBox.ForeColor = System.Drawing.Color.Blue;
            this.attackTextBox.Location = new System.Drawing.Point(507, 298);
            this.attackTextBox.MaxLength = 3;
            this.attackTextBox.Name = "attackTextBox";
            this.attackTextBox.Size = new System.Drawing.Size(65, 36);
            this.attackTextBox.TabIndex = 2;
            this.attackTextBox.Text = "50";
            this.attackTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // magicTextBox
            // 
            this.magicTextBox.BackColor = System.Drawing.Color.Black;
            this.magicTextBox.Font = new System.Drawing.Font("NI7SEG", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicTextBox.ForeColor = System.Drawing.Color.Blue;
            this.magicTextBox.Location = new System.Drawing.Point(507, 340);
            this.magicTextBox.MaxLength = 3;
            this.magicTextBox.Name = "magicTextBox";
            this.magicTextBox.Size = new System.Drawing.Size(65, 36);
            this.magicTextBox.TabIndex = 3;
            this.magicTextBox.Text = "50";
            this.magicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.Lime;
            this.healthLabel.Location = new System.Drawing.Point(357, 260);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(127, 32);
            this.healthLabel.TabIndex = 7;
            this.healthLabel.Text = "Health:";
            this.healthLabel.MouseHover += new System.EventHandler(this.Health_MouseHover);
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseLabel.ForeColor = System.Drawing.Color.Lime;
            this.defenseLabel.Location = new System.Drawing.Point(346, 386);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(138, 32);
            this.defenseLabel.TabIndex = 10;
            this.defenseLabel.Text = "Defense:";
            this.defenseLabel.MouseHover += new System.EventHandler(this.Defense_MouseHover);
            // 
            // magicLabel
            // 
            this.magicLabel.AutoSize = true;
            this.magicLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicLabel.ForeColor = System.Drawing.Color.Lime;
            this.magicLabel.Location = new System.Drawing.Point(378, 344);
            this.magicLabel.Name = "magicLabel";
            this.magicLabel.Size = new System.Drawing.Size(106, 32);
            this.magicLabel.TabIndex = 9;
            this.magicLabel.Text = "Magic:";
            this.magicLabel.MouseHover += new System.EventHandler(this.Magic_MouseHover);
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackLabel.ForeColor = System.Drawing.Color.Lime;
            this.attackLabel.Location = new System.Drawing.Point(358, 302);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(126, 32);
            this.attackLabel.TabIndex = 8;
            this.attackLabel.Text = "Attack:";
            this.attackLabel.Click += new System.EventHandler(this.label4_Click);
            this.attackLabel.MouseHover += new System.EventHandler(this.Attack_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please choose your attributes.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gray;
            this.startButton.Font = new System.Drawing.Font("Motorwerk", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(390, 557);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 57);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(325, 150);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 32);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameTextBox.Location = new System.Drawing.Point(427, 150);
            this.NameTextBox.MaxLength = 10;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(172, 39);
            this.NameTextBox.TabIndex = 0;
            // 
            // healthToolTip
            // 
            this.healthToolTip.ToolTipTitle = "Health";
            // 
            // attackToolTip
            // 
            this.attackToolTip.ToolTipTitle = "Attack";
            // 
            // magicToolTip
            // 
            this.magicToolTip.ToolTipTitle = "Magic";
            // 
            // defenseToolTip
            // 
            this.defenseToolTip.ToolTipTitle = "Defense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mouse over each attribute label for an explanation of the attribute.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(188, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(548, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Every attribute is required, but total can not exceed 200.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 60F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(907, 95);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prepare for Battle!";
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.ForeColor = System.Drawing.Color.White;
            this.copyRightLabel.Location = new System.Drawing.Point(790, 628);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(0, 13);
            this.copyRightLabel.TabIndex = 16;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(924, 650);
            this.Controls.Add(this.copyRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.magicLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.magicTextBox);
            this.Controls.Add(this.attackTextBox);
            this.Controls.Add(this.defenseTextBox);
            this.Controls.Add(this.healthTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 688);
            this.MinimumSize = new System.Drawing.Size(940, 688);
            this.Name = "StartScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Your Attributes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.TextBox defenseTextBox;
        private System.Windows.Forms.TextBox attackTextBox;
        private System.Windows.Forms.TextBox magicTextBox;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label magicLabel;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ToolTip healthToolTip;
        private System.Windows.Forms.ToolTip attackToolTip;
        private System.Windows.Forms.ToolTip magicToolTip;
        private System.Windows.Forms.ToolTip defenseToolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label copyRightLabel;
    }
}

