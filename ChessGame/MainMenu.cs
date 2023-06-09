﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InGameForm inGame = new InGameForm(true, false);
            inGame.ShowDialog();
            this.Close();
        }

        private void Connection_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.ShowDialog();
            this.Close();

        }
    }
}
