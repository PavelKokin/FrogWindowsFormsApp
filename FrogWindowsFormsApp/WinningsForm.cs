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
    public partial class WinningsForm : Form
    {
        public WinningsForm(int countStep)
        {
            InitializeComponent();
            if (countStep == 24)
            {
                winTextLabel.Text = "Ура! Вы выиграли за\nминимальное количество\nшагов";
            }
            else
            {
                winTextLabel.Text = "Ура! Вы выиграли но не\nза минимальное количество\nшагов";
            }
        }

        private void WinningsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
