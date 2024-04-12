/* Program: Hearts
 * Author: Takirul
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method handles the event when a link is clicked in the LinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event. This is generally the object that raised the event.</param>
        /// <param name="e">An object that contains event data.</param>
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Start a process to open the specified URL in the browser.
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=CxiTg7YVt0A");
        }
    }
}
