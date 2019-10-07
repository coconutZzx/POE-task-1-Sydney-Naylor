using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Sydney_Naylor_19013037
{
    public partial class frmGame : Form
    {
        Map map = new Map(5);
        public frmGame()
        {
            InitializeComponent();
            map.GenerateBattlefield();
            rTxtBox.Text = map.GetInfo();
            //for (int i = 0; i < map.numberUnits ; i++)
            //{
            //    txtBox.Text += map.units[i].ToString();
            //}
            
        }

        private void LblRounds_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            map.Populate();
            map.Render(lblArea);

            
            // map.GenerateBattlefield();
            // map.Populate();
            // map.Update();
            // map.Information(txtBox);
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
