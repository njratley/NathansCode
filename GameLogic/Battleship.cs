using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    /// <summary>
    /// NJR: Battlship child class, A battleship has a different amount of hits than that of a Destroyer.
    /// However a Battleship will share many of the other same attributes as any other ship type.
    /// </summary>
    class Battleship : Ship
    {

        /// <summary>
        ///NJR: myHitPoints numeric representation of how many squares the Battleship will occupy
        /// and also how many hits it will take to sink.
        /// </summary>

        public const int myHitPoints = 5;
        public char[] xLocations = new char[myHitPoints];
        public int[] yLocations = new int[myHitPoints];

        /// <summary>
        /// Default / Empty constructor for the Battleship Class.
        /// </summary>
        public Battleship()
        {

        }


        public Battleship(string vShipName, GridOrientation vShipOrientation, GridDirection vShipDirection, 
            char[] vXLocation, int[] vYlocation) 
            : base(vShipName, vShipOrientation, vShipDirection)
        {
            xLocations = vXLocation;
            yLocations = vYlocation;
            
            DefineAttributes();

        }

        public override void DefineAttributes()
        {
            XLocation = new char[myHitPoints];
            XLocation = xLocations;
           
            YLocation = new int[myHitPoints];
            YLocation = yLocations;
            HitPoints = myHitPoints;


        }
    }
}
