/* Program: Hearts
 * Author: Takirul Takirul
 * Date: February 20, 2024
 * Description: In this program, I have created a C# Windows application that includes 
 * game-play logic, computer players, a graphical user interface, object-oriented 
 * programming concepts, internal documentation, and a user guide and tutorial. 
 * It also includes the number of cards and the number of players.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearts
{
    /// <summary>
    /// The Form1 class is a partial class that represents the main form of the application.
    /// This class contains all the event handlers and controls for the main form.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method handles the event when the 'User Guide' menu item is clicked.
        /// It creates a new instance of Form2 and displays it as a modal dialog.
        /// </summary>
        /// <param name="sender">The source of the event. This is generally the object that raised the event.</param>
        /// <param name="e">An object that contains event data.</param>
        private void UserGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class.
            Form2 Form2 = new Form2();

            // Show Form 2 as a modal dialog.
            Form2.ShowDialog();
        }

        /// <summary>
        /// This method handles the event when the 'Game Rules' menu item is clicked.
        /// It creates a new instance of Form3 and displays it as a modal dialog.
        /// </summary>
        /// <param name="sender">The source of the event. This is generally the object that raised the event.</param>
        /// <param name="e">An object that contains event data.</param>
        private void GameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form3 class.
            Form3 Form3 = new Form3();

            // Show Form 3 as a modal dialog.
            Form3.ShowDialog();
        }

        /// <summary>
        /// This method is called when the form is loaded. It creates a new instance of the Game class and starts the game.
        /// </summary>
        /// <param name="sender">The source of the event. This is generally the object that raised the event.</param>
        /// <param name="e">An object that contains event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new instance of the Game class.
            Game heartsGame = new Game();

            // Start the game.
            heartsGame.PlayGame();
        }

        /// <summary>
        /// This method is called when the 'Deal' button is clicked. It should contain the logic to deal the cards.
        /// </summary>
        /// <param name="sender">The source of the event. This is generally the object that raised the event.</param>
        /// <param name="e">An object that contains event data.</param>
        private void dealButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is called when the 'Exit' button is clicked. It closes the form, effectively exiting the application.
        /// </summary>
        /// <param name="sender">The source of the event. This is generally the object that raised the event.</param>
        /// <param name="e">An object that contains event data.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            Close();
        }
    }
}
