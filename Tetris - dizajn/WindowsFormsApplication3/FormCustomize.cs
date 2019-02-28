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
    public partial class FormCustomize : Form
    {
        public FormCustomize()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true)
            {
                MessageBox.Show("Please enter values ​​for all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(textBox1.Text) > 50 || int.Parse(textBox1.Text) < 10 || int.Parse(textBox2.Text) > 50 || int.Parse(textBox2.Text) < 10)
            {
                MessageBox.Show("The minimum field dimensions are 10x10, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(textBox3.Text) > 3000 || int.Parse(textBox3.Text) < 100)
            {
                MessageBox.Show("Impossible game speed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tetris.DimX = int.Parse(textBox1.Text);
            Tetris.DimY = int.Parse(textBox2.Text);
            Main.TimerInterval = int.Parse(textBox3.Text);

            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
