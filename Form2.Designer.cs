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
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.userGuideLabel = new System.Windows.Forms.Label();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.introductionTextLabel = new System.Windows.Forms.Label();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.mainMenuTextLabel = new System.Windows.Forms.Label();
            this.helpMenuLabel = new System.Windows.Forms.Label();
            this.helpMenuTextLabel = new System.Windows.Forms.Label();
            this.startingAGameLabel = new System.Windows.Forms.Label();
            this.startingAGameTextLabel = new System.Windows.Forms.Label();
            this.gameSettingsLabel = new System.Windows.Forms.Label();
            this.gameSettingsTextLabel = new System.Windows.Forms.Label();
            this.gameplayLabel = new System.Windows.Forms.Label();
            this.gameplayTextLabel = new System.Windows.Forms.Label();
            this.endingTheGameLabel = new System.Windows.Forms.Label();
            this.endingTheGameTextLabel = new System.Windows.Forms.Label();
            this.supportLabel = new System.Windows.Forms.Label();
            this.supportTextLabel = new System.Windows.Forms.Label();
            this.onlineVideoTutorialLabel = new System.Windows.Forms.Label();
            this.onlineVideoTutorialTextLabel = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userGuideLabel
            // 
            this.userGuideLabel.AutoSize = true;
            this.userGuideLabel.Font = new System.Drawing.Font("Source Serif Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuideLabel.Location = new System.Drawing.Point(580, 29);
            this.userGuideLabel.Name = "userGuideLabel";
            this.userGuideLabel.Size = new System.Drawing.Size(186, 45);
            this.userGuideLabel.TabIndex = 0;
            this.userGuideLabel.Text = "User Guide";
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductionLabel.Location = new System.Drawing.Point(51, 101);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(148, 32);
            this.introductionLabel.TabIndex = 1;
            this.introductionLabel.Text = "Introduction";
            // 
            // introductionTextLabel
            // 
            this.introductionTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductionTextLabel.Location = new System.Drawing.Point(52, 143);
            this.introductionTextLabel.Name = "introductionTextLabel";
            this.introductionTextLabel.Size = new System.Drawing.Size(687, 85);
            this.introductionTextLabel.TabIndex = 2;
            this.introductionTextLabel.Text = "Hearts is a classic card game where the aim is to avoid scoring points. This user" +
    "-friendly application allows you to customize your game experience and play agai" +
    "nst computer-controlled players.";
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(51, 236);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(133, 32);
            this.mainMenuLabel.TabIndex = 3;
            this.mainMenuLabel.Text = "Main Menu";
            // 
            // mainMenuTextLabel
            // 
            this.mainMenuTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTextLabel.Location = new System.Drawing.Point(52, 275);
            this.mainMenuTextLabel.Name = "mainMenuTextLabel";
            this.mainMenuTextLabel.Size = new System.Drawing.Size(687, 89);
            this.mainMenuTextLabel.TabIndex = 4;
            this.mainMenuTextLabel.Text = "Game: Start a new game or continue a saved game.\r\nHelp: Access support resources " +
    "like the user guide, game rules, troubleshooting, settings, and contact informat" +
    "ion.";
            // 
            // helpMenuLabel
            // 
            this.helpMenuLabel.AutoSize = true;
            this.helpMenuLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMenuLabel.Location = new System.Drawing.Point(51, 380);
            this.helpMenuLabel.Name = "helpMenuLabel";
            this.helpMenuLabel.Size = new System.Drawing.Size(129, 32);
            this.helpMenuLabel.TabIndex = 5;
            this.helpMenuLabel.Text = "Help Menu";
            // 
            // helpMenuTextLabel
            // 
            this.helpMenuTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMenuTextLabel.Location = new System.Drawing.Point(52, 428);
            this.helpMenuTextLabel.Name = "helpMenuTextLabel";
            this.helpMenuTextLabel.Size = new System.Drawing.Size(687, 198);
            this.helpMenuTextLabel.TabIndex = 6;
            this.helpMenuTextLabel.Text = resources.GetString("helpMenuTextLabel.Text");
            // 
            // startingAGameLabel
            // 
            this.startingAGameLabel.AutoSize = true;
            this.startingAGameLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingAGameLabel.Location = new System.Drawing.Point(51, 653);
            this.startingAGameLabel.Name = "startingAGameLabel";
            this.startingAGameLabel.Size = new System.Drawing.Size(180, 32);
            this.startingAGameLabel.TabIndex = 7;
            this.startingAGameLabel.Text = "Starting a Game";
            // 
            // startingAGameTextLabel
            // 
            this.startingAGameTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingAGameTextLabel.Location = new System.Drawing.Point(52, 695);
            this.startingAGameTextLabel.Name = "startingAGameTextLabel";
            this.startingAGameTextLabel.Size = new System.Drawing.Size(687, 107);
            this.startingAGameTextLabel.TabIndex = 8;
            this.startingAGameTextLabel.Text = "To begin playing Hearts:\r\n1. Select Game from the main menu.\r\n2. Choose to start " +
    "a new game or load a saved game.\r\n3. If starting a new game, you will be prompte" +
    "d to customize your game settings.";
            // 
            // gameSettingsLabel
            // 
            this.gameSettingsLabel.AutoSize = true;
            this.gameSettingsLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSettingsLabel.Location = new System.Drawing.Point(765, 101);
            this.gameSettingsLabel.Name = "gameSettingsLabel";
            this.gameSettingsLabel.Size = new System.Drawing.Size(163, 32);
            this.gameSettingsLabel.TabIndex = 9;
            this.gameSettingsLabel.Text = "Game Settings";
            // 
            // gameSettingsTextLabel
            // 
            this.gameSettingsTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSettingsTextLabel.Location = new System.Drawing.Point(766, 143);
            this.gameSettingsTextLabel.Name = "gameSettingsTextLabel";
            this.gameSettingsTextLabel.Size = new System.Drawing.Size(593, 101);
            this.gameSettingsTextLabel.TabIndex = 10;
            this.gameSettingsTextLabel.Text = resources.GetString("gameSettingsTextLabel.Text");
            // 
            // gameplayLabel
            // 
            this.gameplayLabel.AutoSize = true;
            this.gameplayLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameplayLabel.Location = new System.Drawing.Point(765, 258);
            this.gameplayLabel.Name = "gameplayLabel";
            this.gameplayLabel.Size = new System.Drawing.Size(120, 32);
            this.gameplayLabel.TabIndex = 11;
            this.gameplayLabel.Text = "Gameplay";
            // 
            // gameplayTextLabel
            // 
            this.gameplayTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameplayTextLabel.Location = new System.Drawing.Point(766, 296);
            this.gameplayTextLabel.Name = "gameplayTextLabel";
            this.gameplayTextLabel.Size = new System.Drawing.Size(593, 121);
            this.gameplayTextLabel.TabIndex = 12;
            this.gameplayTextLabel.Text = resources.GetString("gameplayTextLabel.Text");
            // 
            // endingTheGameLabel
            // 
            this.endingTheGameLabel.AutoSize = true;
            this.endingTheGameLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingTheGameLabel.Location = new System.Drawing.Point(765, 427);
            this.endingTheGameLabel.Name = "endingTheGameLabel";
            this.endingTheGameLabel.Size = new System.Drawing.Size(193, 32);
            this.endingTheGameLabel.TabIndex = 13;
            this.endingTheGameLabel.Text = "Ending the Game";
            // 
            // endingTheGameTextLabel
            // 
            this.endingTheGameTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingTheGameTextLabel.Location = new System.Drawing.Point(766, 470);
            this.endingTheGameTextLabel.Name = "endingTheGameTextLabel";
            this.endingTheGameTextLabel.Size = new System.Drawing.Size(593, 70);
            this.endingTheGameTextLabel.TabIndex = 14;
            this.endingTheGameTextLabel.Text = "The game ends when a player reaches the predetermined score limit. The player wit" +
    "h the lowest score at that time is the winner.";
            // 
            // supportLabel
            // 
            this.supportLabel.AutoSize = true;
            this.supportLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportLabel.Location = new System.Drawing.Point(765, 538);
            this.supportLabel.Name = "supportLabel";
            this.supportLabel.Size = new System.Drawing.Size(99, 32);
            this.supportLabel.TabIndex = 15;
            this.supportLabel.Text = "Support";
            // 
            // supportTextLabel
            // 
            this.supportTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportTextLabel.Location = new System.Drawing.Point(766, 585);
            this.supportTextLabel.Name = "supportTextLabel";
            this.supportTextLabel.Size = new System.Drawing.Size(593, 53);
            this.supportTextLabel.TabIndex = 16;
            this.supportTextLabel.Text = "If you need help or wish to provide feedback, please use the Contact Us option in" +
    " the help menu.";
            // 
            // onlineVideoTutorialLabel
            // 
            this.onlineVideoTutorialLabel.AutoSize = true;
            this.onlineVideoTutorialLabel.Font = new System.Drawing.Font("Source Serif Pro Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineVideoTutorialLabel.Location = new System.Drawing.Point(765, 651);
            this.onlineVideoTutorialLabel.Name = "onlineVideoTutorialLabel";
            this.onlineVideoTutorialLabel.Size = new System.Drawing.Size(236, 32);
            this.onlineVideoTutorialLabel.TabIndex = 17;
            this.onlineVideoTutorialLabel.Text = "Online Video Tutorial";
            // 
            // onlineVideoTutorialTextLabel
            // 
            this.onlineVideoTutorialTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineVideoTutorialTextLabel.Location = new System.Drawing.Point(766, 695);
            this.onlineVideoTutorialTextLabel.Name = "onlineVideoTutorialTextLabel";
            this.onlineVideoTutorialTextLabel.Size = new System.Drawing.Size(593, 69);
            this.onlineVideoTutorialTextLabel.TabIndex = 18;
            this.onlineVideoTutorialTextLabel.Text = "For additional information on how to play Windows Hearts Game, please visit the f" +
    "ollowing link:";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Source Serif Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(767, 750);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(258, 24);
            this.linkLabel.TabIndex = 19;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "How to Play Hearts (Card Game)";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1414, 834);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.onlineVideoTutorialTextLabel);
            this.Controls.Add(this.onlineVideoTutorialLabel);
            this.Controls.Add(this.supportTextLabel);
            this.Controls.Add(this.supportLabel);
            this.Controls.Add(this.endingTheGameTextLabel);
            this.Controls.Add(this.endingTheGameLabel);
            this.Controls.Add(this.gameplayTextLabel);
            this.Controls.Add(this.gameplayLabel);
            this.Controls.Add(this.gameSettingsTextLabel);
            this.Controls.Add(this.gameSettingsLabel);
            this.Controls.Add(this.startingAGameTextLabel);
            this.Controls.Add(this.startingAGameLabel);
            this.Controls.Add(this.helpMenuTextLabel);
            this.Controls.Add(this.helpMenuLabel);
            this.Controls.Add(this.mainMenuTextLabel);
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.introductionTextLabel);
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.userGuideLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userGuideLabel;
        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.Label introductionTextLabel;
        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Label mainMenuTextLabel;
        private System.Windows.Forms.Label helpMenuLabel;
        private System.Windows.Forms.Label helpMenuTextLabel;
        private System.Windows.Forms.Label startingAGameLabel;
        private System.Windows.Forms.Label startingAGameTextLabel;
        private System.Windows.Forms.Label gameSettingsLabel;
        private System.Windows.Forms.Label gameSettingsTextLabel;
        private System.Windows.Forms.Label gameplayLabel;
        private System.Windows.Forms.Label gameplayTextLabel;
        private System.Windows.Forms.Label endingTheGameLabel;
        private System.Windows.Forms.Label endingTheGameTextLabel;
        private System.Windows.Forms.Label supportLabel;
        private System.Windows.Forms.Label supportTextLabel;
        private System.Windows.Forms.Label onlineVideoTutorialLabel;
        private System.Windows.Forms.Label onlineVideoTutorialTextLabel;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}
