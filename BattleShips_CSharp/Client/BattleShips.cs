using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace Client
{
    public partial class BattleShips : Form
    {
        public Game GameInstance;
        public BattleShips()
        {
            InitializeComponent();

            Game NewGame = new Game();

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            
        /// try
                
                bool ValidShot = GameInstance.ValidateShot(tbxX.Text, tbxY.Text);
                if (ValidShot)
                {
                    ///Proceed to check if it's a hit or a miss.
                  



                }
                MessageBox.Show(string.Format("Was this a valid Shot? {0}", ValidShot));
            ///lbxShotsFired.DataSource = GameInstance.AttacksMade;

            lbxShotsFired.Items.Clear();
            foreach (string attack in GameInstance.AttacksMade)
            {
                lbxShotsFired.Items.Add(String.Format("Attack made at co-ordinates {0}",attack));
            }
            tbxHits.Text = GameInstance.NumHits.ToString();
            tbxMisses.Text = GameInstance.NumMisses.ToString();
        }

        private void btnStartReset_Click(object sender, EventArgs e)
        {
            GameInstance = new Game(true);
            rtbShips.Clear();
            GameInstance.AttacksMade = new List<string>();
            /// Below are hardcoded ideally and given more time these would be worked out properly based on each of the ships hit points and size of grid.
            GameInstance.WinConditionHits = 13;
            GameInstance.WinConditionMisses = 100 - 13;
            GameInstance.CreateShips();
            lbxShotsFired.Items.Clear();
            btnFire.Enabled = true;
            lbxShotsFired.Enabled = true;
            tbxX.Enabled = true;
            tbxY.Enabled = true;
            tbxHits.Text = "0";
            tbxMisses.Text = "0";
            //lblShipOne.Text = GameInstance.ShipDetailOutput(1);
            rtbShips.AppendText(GameInstance.ShipDetailOutput(1));
            rtbShips.AppendText(Environment.NewLine);
            rtbShips.AppendText(GameInstance.ShipDetailOutput(2));
            rtbShips.AppendText(Environment.NewLine);
            rtbShips.AppendText(GameInstance.ShipDetailOutput(3));



        }

    }
}
