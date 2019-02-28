using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FormWelcome : Form
    {
        string playerName, playerSurname;

        public FormWelcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("To start enter your name and surname", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            playerName = txtName.Text;
            playerSurname = txtSurname.Text;

            Main m = new Main(playerName,playerSurname);
            m.ShowDialog();
        }
    }
}
