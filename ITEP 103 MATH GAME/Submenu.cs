using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEP_103_MATH_GAME
{
    public partial class Submenu : Form
    {
        public Submenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close both the Submenu and Game forms, then show the MENU form
            Game gameForm = this.Owner as Game;
            if (gameForm != null)
            {
                gameForm.Close();
            }
            MENU mmenu = new MENU();
            mmenu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Restart the game and hide the Submenu form
            var gameForm = this.Owner as Game;
            if (gameForm != null)
            {
                gameForm.ResetGame();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
