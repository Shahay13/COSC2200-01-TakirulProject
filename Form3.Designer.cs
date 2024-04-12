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
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gameRulesLabel = new System.Windows.Forms.Label();
            this.gameRulesTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameRulesLabel
            // 
            this.gameRulesLabel.AutoSize = true;
            this.gameRulesLabel.Font = new System.Drawing.Font("Source Serif Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRulesLabel.Location = new System.Drawing.Point(382, 29);
            this.gameRulesLabel.Name = "gameRulesLabel";
            this.gameRulesLabel.Size = new System.Drawing.Size(199, 45);
            this.gameRulesLabel.TabIndex = 0;
            this.gameRulesLabel.Text = "Game Rules";
            // 
            // gameRulesTextLabel
            // 
            this.gameRulesTextLabel.Font = new System.Drawing.Font("Source Serif Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRulesTextLabel.Location = new System.Drawing.Point(59, 95);
            this.gameRulesTextLabel.Name = "gameRulesTextLabel";
            this.gameRulesTextLabel.Size = new System.Drawing.Size(843, 534);
            this.gameRulesTextLabel.TabIndex = 1;
            this.gameRulesTextLabel.Text = resources.GetString("gameRulesTextLabel.Text");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(956, 669);
            this.Controls.Add(this.gameRulesTextLabel);
            this.Controls.Add(this.gameRulesLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameRulesLabel;
        private System.Windows.Forms.Label gameRulesTextLabel;
    }
}
