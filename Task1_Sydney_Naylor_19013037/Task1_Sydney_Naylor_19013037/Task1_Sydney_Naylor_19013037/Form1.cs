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
        GameEngine engine = new GameEngine();
        Timer timer = new Timer();
        GameState gameState = GameState.PAUSED;

        public frmGame()
        {
            InitializeComponent();

            engine = new GameEngine();
            lblArea.Text = engine.GetMapDisplay();
            rTxtBox.Text = engine.GetUnitInfo() + engine.GetBuildingInfo();
            //rTxtBox.Text = engine.GetBuildingInfo();
            lblRounds.Text = "Round: " + engine.Round;

            timer = new Timer();
            timer.Interval = 1000/60;
            timer.Tick += LblRounds_Click;
            
        }
        private void UpdateUI()
        {
            lblArea.Text = engine.GetMapDisplay();
            rTxtBox.Text = engine.GetUnitInfo() + engine.GetBuildingInfo();
            //rTxtBox.Text = engine.GetBuildingInfo();
            lblRounds.Text = "Round: " + engine.Round;
        }
        public enum GameState
        {
            RUNNING,
            PAUSED,
            ENDED
        }
        private void LblRounds_Click(object sender, EventArgs e)
        {
            engine.GameLoop();
            UpdateUI();

            if (engine.GameOver)
            {
                timer.Stop();
                lblArea.Text = engine.WinningTeam + " WON! \n" + lblArea.Text;
                gameState = GameState.ENDED;
                btnStartPause.Text = "Restart";
            }
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
