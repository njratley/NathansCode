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
        public Game GameInstance = new Game();
        public BattleShips()
        {
            InitializeComponent();

            Game NewGame = new Game();

        }

    
       
      

        private void btnFire_Click(object sender, EventArgs e)
        {
            bool ValidShot = GameInstance.ValidateShot(tbxX.Text, tbxY.Text);
            if (validShot)
            {
                ///Proceed to check if it's a hit or a miss.
                
            }
            MessageBox.Show(String.Format("Valid Shot? {0}", ValidShot));
            
        }
    }
}
