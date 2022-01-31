using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogWindowsFormsApp
{
    public partial class MainForm : Form
    {
        int countStep=0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void rightPictureBox1_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickedPictureBox)
        {
            var distance = Math.Abs(clickedPictureBox.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;
            if (distance <= 2)
            {
                var location = clickedPictureBox.Location;
                clickedPictureBox.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                countStep++;
                countStepLabel.Text = "Количество ходов - " + countStep;
            }
            else
            {
                MessageBox.Show("Так нельзя!");
            }
            CheckWinnings();
        }

        private void CheckWinnings()
        {
            if (rightPictureBox1.Location.X<=emptyPictureBox.Location.X && rightPictureBox2.Location.X<= emptyPictureBox.Location.X && rightPictureBox3.Location.X<= emptyPictureBox.Location.X && rightPictureBox4.Location.X<= emptyPictureBox.Location.X && emptyPictureBox.Location.X==440)
            {
                var winningsForm = new WinningsForm(countStep);
                var result = winningsForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    Application.Restart();
                }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rulesForm = new RulesForm();
            rulesForm.ShowDialog();
        }
    }
}
