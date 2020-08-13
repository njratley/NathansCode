using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{

    /// <summary>
    /// As with the Battleship child class we want a seperate class that captures unique properties to that of a Destoyer
    /// Again though we want to capture the common properties of a Ship from the parent class.
    /// </summary>
    class Destroyer : Ship
    {
        /// <summary>
        /// Value to assign the Destroyers hit points.
        /// Used a constant value here rather than declaring 4 in each method that requires the hit points.
        /// This way if we decide that Destroyers now have 3 hitpoints or another value this is a simple one place change.
        /// Damage to the ship should in my opinion be handled seperate to the total hit points and therefore will not fluctuate within a game.
        /// </summary>
        public const int myHitPoints = 4;
        public char[] xLocations = new char[myHitPoints];
        public int[] yLocations = new int[myHitPoints];

        /// <summary>
        /// Destroyer Default Blank / Empty Constructor.
        /// </summary>
        public Destroyer()
        {

        }

        public Destroyer(string vShipName,GridOrientation vShipOrientation,GridDirection vShipDirection,char[] vXLocations,int[] vYlocations)       
            : base(vShipName,vShipOrientation,vShipDirection)
        {
            xLocations = vXLocations;
            yLocations = vYlocations;
            DefineAttributes();

        }
        public override void DefineAttributes()
        {
           
            XLocation = new char[myHitPoints];
            YLocation = new int[myHitPoints];
            XLocation = xLocations;
            YLocation = yLocations;
            HitPoints = myHitPoints;


        }


    }
}
