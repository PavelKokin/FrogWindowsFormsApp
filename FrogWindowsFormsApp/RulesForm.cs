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
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void RulesForm_Load(object sender, EventArgs e)
        {
            firstRulesLabel.Text = "1. Цель игры - переместить лягушек, смотрящих вправо в правую часть игрового поля, смотрящих влево - в левую часть игрового поля";
            secondRulesLabel.Text = "2. Лягушка перемещается кликом мышки, если свободная кувшинка находится рядом, или через одну кувшинку";
            thirdRulesLabel.Text = "3. Игрок должен переместить все лягушек в нужное положение за минимальное количество ходов";
        }
    }
}
