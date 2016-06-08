namespace TurnBasedBattleGame
{
    partial class GamePlayForm
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
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthAvailableLabel = new System.Windows.Forms.Label();
            this.AttackAvailableLabel = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.MagicAvailableLabel = new System.Windows.Forms.Label();
            this.MagicLabel = new System.Windows.Forms.Label();
            this.DefenseAvailableLabel = new System.Windows.Forms.Label();
            this.DefensLabel = new System.Windows.Forms.Label();
            this.HealButton = new System.Windows.Forms.Button();
            this.AttackButton = new System.Windows.Forms.Button();
            this.MagicButton = new System.Windows.Forms.Button();
            this.DefendButton = new System.Windows.Forms.Button();
            this.PlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.EnemyGroupBox = new System.Windows.Forms.GroupBox();
            this.enemyHealthProgressBar = new System.Windows.Forms.ProgressBar();
            this.EnemyHealthLabel = new System.Windows.Forms.Label();
            this.EnemyHealthAvailableLabel = new System.Windows.Forms.Label();
            this.EnemyAttackLabel = new System.Windows.Forms.Label();
            this.EnemyAttackAvailableLabel = new System.Windows.Forms.Label();
            this.EnemyMagicLabel = new System.Windows.Forms.Label();
            this.EnemyDefenseAvailableLabel = new System.Windows.Forms.Label();
            this.EnemyMagicAvailableLabel = new System.Windows.Forms.Label();
            this.EnemyDefenseLabel = new System.Windows.Forms.Label();
            this.MagicGroupBox = new System.Windows.Forms.GroupBox();
            this.defensePotionButton = new System.Windows.Forms.Button();
            this.strengthButton = new System.Windows.Forms.Button();
            this.actionsListBox = new System.Windows.Forms.ListBox();
            this.PlayerGroupBox.SuspendLayout();
            this.EnemyGroupBox.SuspendLayout();
            this.MagicGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Black;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.ForeColor = System.Drawing.Color.Lime;
            this.HealthLabel.Location = new System.Drawing.Point(28, 132);
            this.HealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(116, 39);
            this.HealthLabel.TabIndex = 0;
            this.HealthLabel.Text = "Health";
            this.HealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HealthAvailableLabel
            // 
            this.HealthAvailableLabel.AutoSize = true;
            this.HealthAvailableLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HealthAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthAvailableLabel.ForeColor = System.Drawing.Color.Lime;
            this.HealthAvailableLabel.Location = new System.Drawing.Point(53, 171);
            this.HealthAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HealthAvailableLabel.Name = "HealthAvailableLabel";
            this.HealthAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HealthAvailableLabel.Size = new System.Drawing.Size(67, 49);
            this.HealthAvailableLabel.TabIndex = 1;
            this.HealthAvailableLabel.Text = "50";
            this.HealthAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttackAvailableLabel
            // 
            this.AttackAvailableLabel.AutoSize = true;
            this.AttackAvailableLabel.BackColor = System.Drawing.Color.Transparent;
            this.AttackAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttackAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackAvailableLabel.ForeColor = System.Drawing.Color.Blue;
            this.AttackAvailableLabel.Location = new System.Drawing.Point(249, 171);
            this.AttackAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttackAvailableLabel.Name = "AttackAvailableLabel";
            this.AttackAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttackAvailableLabel.Size = new System.Drawing.Size(67, 49);
            this.AttackAvailableLabel.TabIndex = 3;
            this.AttackAvailableLabel.Text = "50";
            this.AttackAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AttackAvailableLabel.Click += new System.EventHandler(this.AttackAvailableLabel_Click);
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.BackColor = System.Drawing.Color.Black;
            this.AttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackLabel.ForeColor = System.Drawing.Color.Lime;
            this.AttackLabel.Location = new System.Drawing.Point(227, 132);
            this.AttackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(111, 39);
            this.AttackLabel.TabIndex = 2;
            this.AttackLabel.Text = "Attack";
            this.AttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MagicAvailableLabel
            // 
            this.MagicAvailableLabel.AutoSize = true;
            this.MagicAvailableLabel.BackColor = System.Drawing.Color.Transparent;
            this.MagicAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MagicAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicAvailableLabel.ForeColor = System.Drawing.Color.Blue;
            this.MagicAvailableLabel.Location = new System.Drawing.Point(454, 171);
            this.MagicAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MagicAvailableLabel.Name = "MagicAvailableLabel";
            this.MagicAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MagicAvailableLabel.Size = new System.Drawing.Size(67, 49);
            this.MagicAvailableLabel.TabIndex = 7;
            this.MagicAvailableLabel.Text = "50";
            this.MagicAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MagicLabel
            // 
            this.MagicLabel.AutoSize = true;
            this.MagicLabel.BackColor = System.Drawing.Color.Black;
            this.MagicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicLabel.ForeColor = System.Drawing.Color.Lime;
            this.MagicLabel.Location = new System.Drawing.Point(433, 132);
            this.MagicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MagicLabel.Name = "MagicLabel";
            this.MagicLabel.Size = new System.Drawing.Size(108, 39);
            this.MagicLabel.TabIndex = 6;
            this.MagicLabel.Text = "Magic";
            this.MagicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefenseAvailableLabel
            // 
            this.DefenseAvailableLabel.AutoSize = true;
            this.DefenseAvailableLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefenseAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DefenseAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefenseAvailableLabel.ForeColor = System.Drawing.Color.Blue;
            this.DefenseAvailableLabel.Location = new System.Drawing.Point(660, 171);
            this.DefenseAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DefenseAvailableLabel.Name = "DefenseAvailableLabel";
            this.DefenseAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DefenseAvailableLabel.Size = new System.Drawing.Size(67, 49);
            this.DefenseAvailableLabel.TabIndex = 9;
            this.DefenseAvailableLabel.Text = "50";
            this.DefenseAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefensLabel
            // 
            this.DefensLabel.AutoSize = true;
            this.DefensLabel.BackColor = System.Drawing.Color.Black;
            this.DefensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefensLabel.ForeColor = System.Drawing.Color.Lime;
            this.DefensLabel.Location = new System.Drawing.Point(621, 132);
            this.DefensLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DefensLabel.Name = "DefensLabel";
            this.DefensLabel.Size = new System.Drawing.Size(144, 39);
            this.DefensLabel.TabIndex = 8;
            this.DefensLabel.Text = "Defense";
            this.DefensLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HealButton
            // 
            this.HealButton.BackColor = System.Drawing.Color.Gray;
            this.HealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealButton.ForeColor = System.Drawing.Color.White;
            this.HealButton.Location = new System.Drawing.Point(20, 62);
            this.HealButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(133, 62);
            this.HealButton.TabIndex = 10;
            this.HealButton.Text = "HEAL";
            this.HealButton.UseVisualStyleBackColor = false;
            this.HealButton.Click += new System.EventHandler(this.HealButton_Click);
            // 
            // AttackButton
            // 
            this.AttackButton.BackColor = System.Drawing.Color.Gray;
            this.AttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackButton.ForeColor = System.Drawing.Color.White;
            this.AttackButton.Location = new System.Drawing.Point(216, 62);
            this.AttackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(133, 62);
            this.AttackButton.TabIndex = 11;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = false;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // MagicButton
            // 
            this.MagicButton.BackColor = System.Drawing.Color.Gray;
            this.MagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicButton.ForeColor = System.Drawing.Color.White;
            this.MagicButton.Location = new System.Drawing.Point(421, 62);
            this.MagicButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MagicButton.Name = "MagicButton";
            this.MagicButton.Size = new System.Drawing.Size(133, 62);
            this.MagicButton.TabIndex = 12;
            this.MagicButton.Text = "Magic";
            this.MagicButton.UseVisualStyleBackColor = false;
            this.MagicButton.Click += new System.EventHandler(this.MagicButton_Click);
            // 
            // DefendButton
            // 
            this.DefendButton.BackColor = System.Drawing.Color.Gray;
            this.DefendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefendButton.ForeColor = System.Drawing.Color.White;
            this.DefendButton.Location = new System.Drawing.Point(627, 65);
            this.DefendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DefendButton.Name = "DefendButton";
            this.DefendButton.Size = new System.Drawing.Size(133, 62);
            this.DefendButton.TabIndex = 13;
            this.DefendButton.Text = "Defend";
            this.DefendButton.UseVisualStyleBackColor = false;
            this.DefendButton.Click += new System.EventHandler(this.DefendButton_Click);
            // 
            // PlayerGroupBox
            // 
            this.PlayerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerGroupBox.Controls.Add(this.playerHealthBar);
            this.PlayerGroupBox.Controls.Add(this.MagicButton);
            this.PlayerGroupBox.Controls.Add(this.AttackButton);
            this.PlayerGroupBox.Controls.Add(this.HealthLabel);
            this.PlayerGroupBox.Controls.Add(this.DefendButton);
            this.PlayerGroupBox.Controls.Add(this.HealthAvailableLabel);
            this.PlayerGroupBox.Controls.Add(this.AttackLabel);
            this.PlayerGroupBox.Controls.Add(this.AttackAvailableLabel);
            this.PlayerGroupBox.Controls.Add(this.HealButton);
            this.PlayerGroupBox.Controls.Add(this.MagicLabel);
            this.PlayerGroupBox.Controls.Add(this.DefenseAvailableLabel);
            this.PlayerGroupBox.Controls.Add(this.MagicAvailableLabel);
            this.PlayerGroupBox.Controls.Add(this.DefensLabel);
            this.PlayerGroupBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerGroupBox.ForeColor = System.Drawing.Color.Lime;
            this.PlayerGroupBox.Location = new System.Drawing.Point(205, 506);
            this.PlayerGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerGroupBox.Name = "PlayerGroupBox";
            this.PlayerGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerGroupBox.Size = new System.Drawing.Size(801, 290);
            this.PlayerGroupBox.TabIndex = 15;
            this.PlayerGroupBox.TabStop = false;
            this.PlayerGroupBox.Text = "Player";
            this.PlayerGroupBox.Enter += new System.EventHandler(this.PlayerGroupBox_Enter);
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.BackColor = System.Drawing.Color.Black;
            this.playerHealthBar.ForeColor = System.Drawing.Color.Lime;
            this.playerHealthBar.Location = new System.Drawing.Point(8, 215);
            this.playerHealthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerHealthBar.MarqueeAnimationSpeed = 5;
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(776, 64);
            this.playerHealthBar.Step = 5;
            this.playerHealthBar.TabIndex = 11;
            this.playerHealthBar.Value = 50;
            // 
            // EnemyGroupBox
            // 
            this.EnemyGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EnemyGroupBox.Controls.Add(this.enemyHealthProgressBar);
            this.EnemyGroupBox.Controls.Add(this.EnemyHealthLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemyHealthAvailableLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemyAttackLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemyAttackAvailableLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemyMagicLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemyDefenseAvailableLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemyMagicAvailableLabel);
            this.EnemyGroupBox.Controls.Add(this.EnemyDefenseLabel);
            this.EnemyGroupBox.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold);
            this.EnemyGroupBox.ForeColor = System.Drawing.Color.Red;
            this.EnemyGroupBox.Location = new System.Drawing.Point(205, 15);
            this.EnemyGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnemyGroupBox.Name = "EnemyGroupBox";
            this.EnemyGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnemyGroupBox.Size = new System.Drawing.Size(801, 234);
            this.EnemyGroupBox.TabIndex = 16;
            this.EnemyGroupBox.TabStop = false;
            this.EnemyGroupBox.Text = "The Bad Guy";
            this.EnemyGroupBox.Enter += new System.EventHandler(this.EnemyGroupBox_Enter);
            // 
            // enemyHealthProgressBar
            // 
            this.enemyHealthProgressBar.BackColor = System.Drawing.Color.Black;
            this.enemyHealthProgressBar.ForeColor = System.Drawing.Color.Lime;
            this.enemyHealthProgressBar.Location = new System.Drawing.Point(8, 149);
            this.enemyHealthProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enemyHealthProgressBar.MarqueeAnimationSpeed = 5;
            this.enemyHealthProgressBar.Name = "enemyHealthProgressBar";
            this.enemyHealthProgressBar.Size = new System.Drawing.Size(776, 64);
            this.enemyHealthProgressBar.Step = 5;
            this.enemyHealthProgressBar.TabIndex = 10;
            this.enemyHealthProgressBar.Value = 50;
            // 
            // EnemyHealthLabel
            // 
            this.EnemyHealthLabel.AutoSize = true;
            this.EnemyHealthLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHealthLabel.ForeColor = System.Drawing.Color.Red;
            this.EnemyHealthLabel.Location = new System.Drawing.Point(33, 53);
            this.EnemyHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyHealthLabel.Name = "EnemyHealthLabel";
            this.EnemyHealthLabel.Size = new System.Drawing.Size(116, 39);
            this.EnemyHealthLabel.TabIndex = 0;
            this.EnemyHealthLabel.Text = "Health";
            this.EnemyHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyHealthAvailableLabel
            // 
            this.EnemyHealthAvailableLabel.AutoSize = true;
            this.EnemyHealthAvailableLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyHealthAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnemyHealthAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHealthAvailableLabel.ForeColor = System.Drawing.Color.Lime;
            this.EnemyHealthAvailableLabel.Location = new System.Drawing.Point(59, 96);
            this.EnemyHealthAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyHealthAvailableLabel.Name = "EnemyHealthAvailableLabel";
            this.EnemyHealthAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnemyHealthAvailableLabel.Size = new System.Drawing.Size(65, 49);
            this.EnemyHealthAvailableLabel.TabIndex = 1;
            this.EnemyHealthAvailableLabel.Text = "50";
            // 
            // EnemyAttackLabel
            // 
            this.EnemyAttackLabel.AutoSize = true;
            this.EnemyAttackLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyAttackLabel.ForeColor = System.Drawing.Color.Red;
            this.EnemyAttackLabel.Location = new System.Drawing.Point(234, 53);
            this.EnemyAttackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyAttackLabel.Name = "EnemyAttackLabel";
            this.EnemyAttackLabel.Size = new System.Drawing.Size(111, 39);
            this.EnemyAttackLabel.TabIndex = 2;
            this.EnemyAttackLabel.Text = "Attack";
            this.EnemyAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyAttackAvailableLabel
            // 
            this.EnemyAttackAvailableLabel.AutoSize = true;
            this.EnemyAttackAvailableLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyAttackAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnemyAttackAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyAttackAvailableLabel.ForeColor = System.Drawing.Color.Blue;
            this.EnemyAttackAvailableLabel.Location = new System.Drawing.Point(257, 96);
            this.EnemyAttackAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyAttackAvailableLabel.Name = "EnemyAttackAvailableLabel";
            this.EnemyAttackAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnemyAttackAvailableLabel.Size = new System.Drawing.Size(65, 49);
            this.EnemyAttackAvailableLabel.TabIndex = 3;
            this.EnemyAttackAvailableLabel.Text = "50";
            this.EnemyAttackAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyMagicLabel
            // 
            this.EnemyMagicLabel.AutoSize = true;
            this.EnemyMagicLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyMagicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyMagicLabel.ForeColor = System.Drawing.Color.Red;
            this.EnemyMagicLabel.Location = new System.Drawing.Point(438, 53);
            this.EnemyMagicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyMagicLabel.Name = "EnemyMagicLabel";
            this.EnemyMagicLabel.Size = new System.Drawing.Size(108, 39);
            this.EnemyMagicLabel.TabIndex = 6;
            this.EnemyMagicLabel.Text = "Magic";
            this.EnemyMagicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyDefenseAvailableLabel
            // 
            this.EnemyDefenseAvailableLabel.AutoSize = true;
            this.EnemyDefenseAvailableLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyDefenseAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnemyDefenseAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyDefenseAvailableLabel.ForeColor = System.Drawing.Color.Blue;
            this.EnemyDefenseAvailableLabel.Location = new System.Drawing.Point(635, 96);
            this.EnemyDefenseAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyDefenseAvailableLabel.Name = "EnemyDefenseAvailableLabel";
            this.EnemyDefenseAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnemyDefenseAvailableLabel.Size = new System.Drawing.Size(65, 49);
            this.EnemyDefenseAvailableLabel.TabIndex = 9;
            this.EnemyDefenseAvailableLabel.Text = "50";
            // 
            // EnemyMagicAvailableLabel
            // 
            this.EnemyMagicAvailableLabel.AutoSize = true;
            this.EnemyMagicAvailableLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyMagicAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnemyMagicAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyMagicAvailableLabel.ForeColor = System.Drawing.Color.Blue;
            this.EnemyMagicAvailableLabel.Location = new System.Drawing.Point(460, 96);
            this.EnemyMagicAvailableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyMagicAvailableLabel.Name = "EnemyMagicAvailableLabel";
            this.EnemyMagicAvailableLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnemyMagicAvailableLabel.Size = new System.Drawing.Size(65, 49);
            this.EnemyMagicAvailableLabel.TabIndex = 7;
            this.EnemyMagicAvailableLabel.Text = "50";
            // 
            // EnemyDefenseLabel
            // 
            this.EnemyDefenseLabel.AutoSize = true;
            this.EnemyDefenseLabel.BackColor = System.Drawing.Color.Black;
            this.EnemyDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyDefenseLabel.ForeColor = System.Drawing.Color.Red;
            this.EnemyDefenseLabel.Location = new System.Drawing.Point(595, 53);
            this.EnemyDefenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyDefenseLabel.Name = "EnemyDefenseLabel";
            this.EnemyDefenseLabel.Size = new System.Drawing.Size(144, 39);
            this.EnemyDefenseLabel.TabIndex = 8;
            this.EnemyDefenseLabel.Text = "Defense";
            this.EnemyDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MagicGroupBox
            // 
            this.MagicGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MagicGroupBox.Controls.Add(this.defensePotionButton);
            this.MagicGroupBox.Controls.Add(this.strengthButton);
            this.MagicGroupBox.Enabled = false;
            this.MagicGroupBox.ForeColor = System.Drawing.Color.White;
            this.MagicGroupBox.Location = new System.Drawing.Point(628, 422);
            this.MagicGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MagicGroupBox.Name = "MagicGroupBox";
            this.MagicGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MagicGroupBox.Size = new System.Drawing.Size(169, 150);
            this.MagicGroupBox.TabIndex = 17;
            this.MagicGroupBox.TabStop = false;
            this.MagicGroupBox.Visible = false;
            // 
            // defensePotionButton
            // 
            this.defensePotionButton.BackColor = System.Drawing.Color.Gray;
            this.defensePotionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defensePotionButton.Location = new System.Drawing.Point(13, 81);
            this.defensePotionButton.Margin = new System.Windows.Forms.Padding(0);
            this.defensePotionButton.Name = "defensePotionButton";
            this.defensePotionButton.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.defensePotionButton.Size = new System.Drawing.Size(140, 55);
            this.defensePotionButton.TabIndex = 1;
            this.defensePotionButton.Text = "Defense Potion";
            this.defensePotionButton.UseVisualStyleBackColor = false;
            this.defensePotionButton.Click += new System.EventHandler(this.defensePotionButton_Click);
            // 
            // strengthButton
            // 
            this.strengthButton.BackColor = System.Drawing.Color.Gray;
            this.strengthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthButton.Location = new System.Drawing.Point(13, 18);
            this.strengthButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.strengthButton.Name = "strengthButton";
            this.strengthButton.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.strengthButton.Size = new System.Drawing.Size(140, 55);
            this.strengthButton.TabIndex = 0;
            this.strengthButton.Text = "Strength Potion";
            this.strengthButton.UseVisualStyleBackColor = false;
            this.strengthButton.Click += new System.EventHandler(this.strengthButton_Click);
            // 
            // actionsListBox
            // 
            this.actionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionsListBox.FormattingEnabled = true;
            this.actionsListBox.ItemHeight = 30;
            this.actionsListBox.Location = new System.Drawing.Point(213, 260);
            this.actionsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionsListBox.Name = "actionsListBox";
            this.actionsListBox.Size = new System.Drawing.Size(775, 154);
            this.actionsListBox.TabIndex = 18;
            // 
            // GamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1229, 789);
            this.Controls.Add(this.actionsListBox);
            this.Controls.Add(this.MagicGroupBox);
            this.Controls.Add(this.EnemyGroupBox);
            this.Controls.Add(this.PlayerGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1247, 836);
            this.MinimumSize = new System.Drawing.Size(1247, 836);
            this.Name = "GamePlayForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePlayForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamePlayForm_FormClosed);
            this.Load += new System.EventHandler(this.GamePlayForm_Load);
            this.PlayerGroupBox.ResumeLayout(false);
            this.PlayerGroupBox.PerformLayout();
            this.EnemyGroupBox.ResumeLayout(false);
            this.EnemyGroupBox.PerformLayout();
            this.MagicGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label HealthAvailableLabel;
        private System.Windows.Forms.Label AttackAvailableLabel;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Label MagicAvailableLabel;
        private System.Windows.Forms.Label MagicLabel;
        private System.Windows.Forms.Label DefenseAvailableLabel;
        private System.Windows.Forms.Label DefensLabel;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button MagicButton;
        private System.Windows.Forms.Button DefendButton;
        private System.Windows.Forms.GroupBox PlayerGroupBox;
        private System.Windows.Forms.GroupBox EnemyGroupBox;
        private System.Windows.Forms.Label EnemyHealthLabel;
        private System.Windows.Forms.Label EnemyHealthAvailableLabel;
        private System.Windows.Forms.Label EnemyAttackLabel;
        private System.Windows.Forms.Label EnemyAttackAvailableLabel;
        private System.Windows.Forms.Label EnemyMagicLabel;
        private System.Windows.Forms.Label EnemyDefenseAvailableLabel;
        private System.Windows.Forms.Label EnemyMagicAvailableLabel;
        private System.Windows.Forms.Label EnemyDefenseLabel;
        private System.Windows.Forms.Button HealButton;
        private System.Windows.Forms.GroupBox MagicGroupBox;
        private System.Windows.Forms.Button defensePotionButton;
        private System.Windows.Forms.Button strengthButton;
        private System.Windows.Forms.ProgressBar enemyHealthProgressBar;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.ListBox actionsListBox;
    }
}