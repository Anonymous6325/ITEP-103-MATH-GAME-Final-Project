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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Loading LoadForm = new Loading();

            // Show Form1 and hide the Menu form
            LoadForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the application when the exit button is clicked
            Application.Exit();
        }
    }
}
