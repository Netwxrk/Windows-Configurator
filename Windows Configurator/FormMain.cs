﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Configurator {
    public partial class FormMain : Form  {
        public FormMain() {
            InitializeComponent();
        }

        // Menu strip: File/Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Wait 0.25 seconds and close the program
            System.Threading.Thread.Sleep(250);
            Application.Exit();
        }

        // Menu strip: Help/About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a popup window
            FormPopup popup = new FormPopup();
            popup.Show();

            // Set title and text of the popup window
            popup.Text = "About";
            popup.setPopupText("The 'Windows Configurator' is a simplistic, yet powerfull tool to fully configure your Windows 7 Operating System and remove all the security or privacy flaws.");
        }
    }
}
