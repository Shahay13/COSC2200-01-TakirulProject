/* Program: Hearts
 * Author: Takirul
 * Date: February 20, 2024
 * Description: In this program, I have created a C# Windows application that includes 
 * game-play logic, computer players, a graphical user interface, object-oriented 
 * programming concepts, internal documentation, and a user guide and tutorial. 
 * It also includes the number of cards and the number of players.
 */

namespace Hearts
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troubleshootingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1Label = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.youLabel = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.gameRulesToolStripMenuItem,
            this.troubleshootingToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.UserGuideToolStripMenuItem_Click);
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.gameRulesToolStripMenuItem.Text = "Game Rules";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.GameRulesToolStripMenuItem_Click);
            // 
            // troubleshootingToolStripMenuItem
            // 
            this.troubleshootingToolStripMenuItem.Name = "troubleshootingToolStripMenuItem";
            this.troubleshootingToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.troubleshootingToolStripMenuItem.Text = "Troubleshooting";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.BackColor = System.Drawing.Color.LightGreen;
            this.player1Label.Font = new System.Drawing.Font("Source Serif Pro Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(406, 57);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(77, 25);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Player 1";
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.BackColor = System.Drawing.Color.LightGreen;
            this.player3Label.Font = new System.Drawing.Font("Source Serif Pro Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Label.Location = new System.Drawing.Point(728, 466);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(77, 25);
            this.player3Label.TabIndex = 3;
            this.player3Label.Text = "Player 3";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.BackColor = System.Drawing.Color.LightGreen;
            this.player2Label.Font = new System.Drawing.Font("Source Serif Pro Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(53, 176);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(77, 25);
            this.player2Label.TabIndex = 4;
            this.player2Label.Text = "Player 2";
            // 
            // youLabel
            // 
            this.youLabel.AutoSize = true;
            this.youLabel.BackColor = System.Drawing.Color.LightGreen;
            this.youLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youLabel.Location = new System.Drawing.Point(374, 581);
            this.youLabel.Name = "youLabel";
            this.youLabel.Size = new System.Drawing.Size(42, 25);
            this.youLabel.TabIndex = 5;
            this.youLabel.Text = "You";
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.Color.LightGray;
            this.dealButton.Font = new System.Drawing.Font("Source Serif Pro Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(336, 329);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(208, 43);
            this.dealButton.TabIndex = 6;
            this.dealButton.Text = "&Deal";
            this.toolTip.SetToolTip(this.dealButton, "Click this button to start dealing cards to players. It initiates the distributio" +
        "n of cards for the current round or hand.");
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.LightGray;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Source Serif Pro Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(715, 590);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.toolTip.SetToolTip(this.exitButton, "Click this button to start dealing cards to players. It initiates the distributio" +
        "n of cards for the current round or hand.");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.dealButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(877, 648);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.youLabel);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player3Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hearts Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troubleshootingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label youLabel;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button exitButton;
    }
}
