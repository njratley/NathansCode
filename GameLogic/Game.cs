using System;
using System.Windows;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace GameLogic
{
    public class Game
    {
        /// <summary>
        /// Game Grid as a multidimensional array could be used as an alternative.
        /// </summary>
        public string[,] GameGrid = new string[10, 10];
        public List<Ship> ShipList { get; set; }
        public List<string> AttacksMade { get; set; }
        public int NumMisses { get; set; }
        public int NumHits { get; set; }
        public int WinConditionHits { get; set; }
        public int WinConditionMisses { get; set; }


        /// <summary>
        /// Default Blank / Empty Constructor For The Game Class.
        /// </summary>
        public Game()
        {


        }

        public Game(bool newGame)
        {
            if (newGame)
            AttacksMade = new List<string>();
            ShipList = new List<Ship>();
            /// This is hard coded but ideally would be 100 (10X10 grid total) - total number of hit points for all ships in this example 13 (Battleship 5, Destroyers 4x2)
            WinConditionMisses = 100 - 13;
            WinConditionHits = 13; /// Again this would be assigned based on ship hit points.



           
        }

        public void CreateShips()
        {

            int XGridValue = 0; /// This will need conversion later to corresponding Char.
            char XLetterValue;
            int YGridvalue = 0;
            GridOrientation ShipOrientation;
            GridDirection ShipDirection;
            int StartingCoOrdinate;
            char[] XLocations;
            int[] YLocations;
            bool validPlacement = false;

            for (int s = 1; s < 4; s++)
            {
               


                switch (s)
                {
                    case 1:
                        /// Start with Battleship.
                        /// Create the largest ship first, easier this way as have more valid grid locations to choose from.
                        /// Create the X/Y arrays that will be passed to the ship / battleship object.
                        XLocations = new char[5];
                        YLocations = new int[5];

                        /// Assign a Random Orientation
                        /// 1 = Horizontal
                        /// 2 = Vertical
                        ShipOrientation = (GridOrientation)RandomNumberGenerator(1, 3); // Need to add one on to the maximum to get value between 1 and 2.
                        /// Assign a random starting co-ordinate 1 - 10
                        StartingCoOrdinate = RandomNumberGenerator(1, 11);

                        /// Debug data below.
                        //ShipOrientation = GridOrientation.Horizontal;
                        //StartingCoOrdinate = 10;


                        /// Assign the best direction based on the starting co-ordinate.
                        ShipDirection = GetDirection(ShipOrientation, StartingCoOrdinate);

                        if (ShipOrientation == GridOrientation.Horizontal)
                        {
                            XGridValue = StartingCoOrdinate;
                            XLetterValue = ConvertToLetter(XGridValue);
                            YGridvalue = RandomNumberGenerator(1, 11);

                        }
                        else
                        {
                            YGridvalue = StartingCoOrdinate;
                            XGridValue = RandomNumberGenerator(1, 11);
                            XLetterValue = ConvertToLetter(XGridValue);
                        }
                        /// Now we have assigned the variables based on orientation 
                        /// we can use them as ship direction is dependent on ship orientation.
                        switch (ShipDirection)
                        {
                            case GridDirection.Up:
                                StartingCoOrdinate += 1;

                                for (int u = 1; u < 6; u++)
                                {
                                    XLocations[u - 1] = XLetterValue;
                                    YLocations[u - 1] = StartingCoOrdinate - u;

                                }

                                break;

                            case GridDirection.Down:
                                StartingCoOrdinate += -1;
                                for (int d = 1; d < 6; d++)

                                {
                                    XLocations[d - 1] = XLetterValue;
                                    YLocations[d - 1] = StartingCoOrdinate + d;

                                }

                                break;

                            case GridDirection.Left:
                                {
                                    StartingCoOrdinate += 1;
                                    for (int L = 1; L < 6; L++)

                                    {
                                        XLocations[L - 1] = ConvertToLetter(StartingCoOrdinate - L);
                                        YLocations[L - 1] = YGridvalue;

                                    }

                                }
                                break;

                            case GridDirection.Right:
                                {
                                    StartingCoOrdinate += -1;
                                    for (int R = 1; R < 6; R++)

                                    {
                                        XLocations[R - 1] = ConvertToLetter(StartingCoOrdinate + R);
                                        YLocations[R - 1] = YGridvalue;

                                    }
                                }
                                break;
                        }


                        /// MessageBox.Show(String.Format("Orientation = {1}{0}Direction = {2}{0}Start Co-ord - X:{3} Y:{4} ", Environment.NewLine, ShipOrientation, ShipDirection, XLetterValue.ToString(),YGridvalue));
                        ShipList.Add(new Battleship("HMS Queen Elizabeth", ShipOrientation, ShipDirection, XLocations, YLocations));
                        break;


                    case 2:

                        /// IF TIME ALLOWED WOULD HAVE PUT A METHOD IN HERE AND A LOOP 
                        /// TO ENSURE THAT THE SHIP DID NOT OVERLAP THE FIRST.

                        /// Create the second largest ship, same reasoning as above.

                        /// Now the first Destroyer
                        
                        XLocations = new char[4];
                        Array.Clear(XLocations, 0, 4);
                        YLocations = new int[4];
                        Array.Clear(YLocations, 0, 4);

                        /// Assign a Random Orientation
                        /// 1 = Horizontal
                        /// 2 = Vertical
                        ShipOrientation = (GridOrientation)RandomNumberGenerator(1, 3); // Need to add one on to the maximum to get value between 1 and 2.
                        /// Assign a random starting co-ordinate 1 - 10
                        StartingCoOrdinate = RandomNumberGenerator(1, 11);

                        /// Assign the best direction based on the starting co-ordinate.
                        ShipDirection = GetDirection(ShipOrientation, StartingCoOrdinate);

                        if (ShipOrientation == GridOrientation.Horizontal)
                        {
                            XGridValue = StartingCoOrdinate;
                            XLetterValue = ConvertToLetter(XGridValue);
                            YGridvalue = RandomNumberGenerator(1, 11);

                        }
                        else
                        {
                            YGridvalue = StartingCoOrdinate;
                            XGridValue = RandomNumberGenerator(1, 11);
                            XLetterValue = ConvertToLetter(XGridValue);
                        }
                        /// Now we have assigned the variables based on orientation 
                        /// we can use them as ship direction is dependent on ship orientation.
                        switch (ShipDirection)
                        {
                            case GridDirection.Up:
                                StartingCoOrdinate += 1;

                                for (int u = 1; u < 5; u++)
                                {
                                    XLocations[u - 1] = XLetterValue;
                                    YLocations[u - 1] = StartingCoOrdinate - u;

                                }

                                break;

                            case GridDirection.Down:
                                StartingCoOrdinate += -1;
                                for (int d = 1; d < 5; d++)

                                {
                                    XLocations[d - 1] = XLetterValue;
                                    YLocations[d - 1] = StartingCoOrdinate + d;

                                }

                                break;

                            case GridDirection.Left:
                                {
                                    StartingCoOrdinate += 1;
                                    for (int L = 1; L < 5; L++)

                                    {
                                        XLocations[L - 1] = ConvertToLetter(StartingCoOrdinate - L);
                                        YLocations[L - 1] = YGridvalue;

                                    }

                                }
                                break;

                            case GridDirection.Right:
                                {
                                    StartingCoOrdinate += -1;
                                    for (int R = 1; R < 5; R++)

                                    {
                                        XLocations[R - 1] = ConvertToLetter(StartingCoOrdinate + R);
                                        YLocations[R - 1] = YGridvalue;

                                    }
                                }
                                break;
                        }



                        ShipList.Add(new Destroyer("HMS Duncan", ShipOrientation, ShipDirection, XLocations, YLocations));
                        break;

                    case 3:
                        ///Create the final ship with the valid co-ordinates we have left.
                        /// IF TIME ALLOWED WOULD HAVE PUT A METHOD IN HERE AND A LOOP 
                        /// TO ENSURE THAT THE SHIP DID NOT OVERLAP THE FIRST AND SECOND.

                        /// Create the last ship which although is the same size is last anyway.
                        /// If this was a smaller sized class of ship then it would be last instead.

                        /// Now the Second Destroyer

                        XLocations = new char[4];
                        Array.Clear(XLocations, 0, 4);
                        YLocations = new int[4];
                        Array.Clear(YLocations, 0, 4);
                        /// Assign a Random Orientation
                        /// 1 = Horizontal
                        /// 2 = Vertical
                        ShipOrientation = (GridOrientation)RandomNumberGenerator(1, 3); // Need to add one on to the maximum to get value between 1 and 2.
                        /// Assign a random starting co-ordinate 1 - 10
                        StartingCoOrdinate = RandomNumberGenerator(1, 11);

                        /// Assign the best direction based on the starting co-ordinate.
                        ShipDirection = GetDirection(ShipOrientation, StartingCoOrdinate);

                        if (ShipOrientation == GridOrientation.Horizontal)
                        {
                            XGridValue = StartingCoOrdinate;
                            XLetterValue = ConvertToLetter(XGridValue);
                            YGridvalue = RandomNumberGenerator(1, 11);

                        }
                        else
                        {
                            YGridvalue = StartingCoOrdinate;
                            XGridValue = RandomNumberGenerator(1, 11);
                            XLetterValue = ConvertToLetter(XGridValue);
                        }
                        /// Now we have assigned the variables based on orientation 
                        /// we can use them as ship direction is dependent on ship orientation.
                        switch (ShipDirection)
                        {
                            case GridDirection.Up:
                                StartingCoOrdinate += 1;

                                for (int u = 1; u < 5; u++)
                                {
                                    XLocations[u - 1] = XLetterValue;
                                    YLocations[u - 1] = StartingCoOrdinate - u;

                                }

                                break;

                            case GridDirection.Down:
                                StartingCoOrdinate += -1;
                                for (int d = 1; d < 5; d++)

                                {
                                    XLocations[d - 1] = XLetterValue;
                                    YLocations[d - 1] = StartingCoOrdinate + d;

                                }

                                break;

                            case GridDirection.Left:
                                {
                                    StartingCoOrdinate += 1;
                                    for (int L = 1; L < 5; L++)

                                    {
                                        XLocations[L - 1] = ConvertToLetter(StartingCoOrdinate - L);
                                        YLocations[L - 1] = YGridvalue;

                                    }

                                }
                                break;

                            case GridDirection.Right:
                                {
                                    StartingCoOrdinate += -1;
                                    for (int R = 1; R < 5; R++)

                                    {
                                        XLocations[R - 1] = ConvertToLetter(StartingCoOrdinate + R);
                                        YLocations[R - 1] = YGridvalue;

                                    }
                                }
                                break;
                        }
                        ShipList.Add(new Destroyer("HMS Defender", ShipOrientation, ShipDirection, XLocations, YLocations));
                        break;

                    default:
                        break;
                }
            }


        }


        public int RandomNumberGenerator(int min, int max)
        {

            int rndNum;
            Random rnd = new Random();
            rndNum = rnd.Next(min, max);
            return rndNum;
           

        }

        /// <summary>
        /// Validate the Y co-ordinate.
        /// </summary>
        /// <param name="Y"></param>
        /// <returns></returns>
        public bool validY(string Y)
        {
            bool yIsValid = false;

            int n;
            bool isNumeric = int.TryParse(Y, out n);
            if (isNumeric)
            {
                if (n < 1 || n > 10)
                {
                    yIsValid = false;
                }

                else
                {
                    yIsValid = true;
                }
            }


            return yIsValid;
        }

        /// <summary>
        /// Validate the X Co-ordinate.  
        /// </summary>
        /// <param name="X"></param>
        /// <returns>True or false dependent on if x co-ordinate is valid.</returns>
        public bool validX(string X)

        {
            bool xIsValid;

            if (Regex.IsMatch(X, @"^[a-jA-J]+$"))
            {
                char.TryParse(X, out char xChar);


                int index = ((int)char.ToUpper(xChar)) - 64;

                if (index < 1 || index > 10)
                {
                    xIsValid = false;
                }
                else
                {
                    xIsValid = true;
                }
            }
            else
            {
                xIsValid = false;
            }

            return xIsValid;
        }

        /// <summary>
        /// Need to validate the shot
        /// Note that the validation for X and Y is done within their own methods and brought back into this one.
        /// This is intentional so that they are independent and could be modified/extended or reported on (e.g. error messages) individually.
        /// </summary>
        /// <param name="x">Input for the X co-ordinate.</param>
        /// <param name="y">Input for the Y co-ordinate.</param>
        /// <returns>True or False based on whether the shot is valid or not.</returns>
        public bool ValidateShot(string x, string y)
        {
            bool bCheckX = validX(x);
            bool bCheckY = validY(y);
            bool allValid = false;
            string sComparison;

            sComparison = string.Format("{0},{1}", x, y);

            if (bCheckX && bCheckY)
            {
            
                if (AttacksMade.Count > 0)
                {
                    for (int a = 0; a < AttacksMade.Count; a++)
                    {
                        ///Ignorecase should work but to be entirely sure placing an upper conversion in as a catch all.
                        if (string.Equals(sComparison.ToUpper(), AttacksMade[a].ToUpper(),StringComparison.InvariantCultureIgnoreCase))
                        {
                            allValid = false;
                            break;

                        }
                        else
                        {
                            allValid = true;
                        }
                            
                    }
                }
                else
                {
                    allValid = true;
                    AttacksMade = new List<string>();
                }
   
              
            }
            else
            {
                allValid = false;
            }
           
            if (allValid)
            {
                MessageBox.Show(String.Format("This would then check against the ship locations in their respective arrays to see if was a hit or a miss{0}It would then add Hit or Miss to the attack log", Environment.NewLine));
                int makeBelieveHitMiss;
                string damageConfirm;

                makeBelieveHitMiss = RandomNumberGenerator(1, 3);

                if (makeBelieveHitMiss < 2)
                {
                    NumHits += 1;
                    damageConfirm = " HIT!!!";
                }
                else
                {
                    damageConfirm = " awww too bad a miss!!";
                    NumMisses += 1;
                }
                MessageBox.Show(damageConfirm);
                AttacksMade.Add(string.Format("{0},{1}", x, y));
               
            }


            if(NumHits == WinConditionHits |  NumMisses == WinConditionMisses)
            {
                MessageBox.Show("Well Done - You have won this not quite fully functional version of the game");
            }

            return allValid;
        }

        public GridDirection GetDirection (GridOrientation vOrientation,int startLocation)
        {
            GridDirection optimalDirection;
            optimalDirection = GridDirection.Right;

            if (vOrientation == GridOrientation.Horizontal)
            {
                /// This could be improved rather than hard coded.
                if (startLocation > 5)
                {
                    optimalDirection = GridDirection.Left;

                }
                else
                {
                    optimalDirection = GridDirection.Right;
                }

                /// Now we know direction get the starting Y position
                startLocation = RandomNumberGenerator(1, 11);

               
            }
            else
            {
                {
                    if (startLocation > 5)
                    {
                        optimalDirection = GridDirection.Up;

                    }
                    else
                    {
                        optimalDirection = GridDirection.Down;
                    }
                }
            }


            return optimalDirection;
        }

        public string ShipDetailOutput(int a)
        {
            StringBuilder sb = new StringBuilder();
            a += -1;
            
                sb.AppendLine(String.Format("Ship Name:{0} Hit Points:{1}", ShipList[a].ShipName, ShipList[a].HitPoints));
                sb.AppendLine(String.Format("Ship Orientation:{0} Ship Direction:{1}", ShipList[a].ShipOrientation.ToString(), ShipList[a].ShipDirection.ToString()));
                sb.AppendLine("Co-ordinates: ");
                for (int g = 0; g < ShipList[a].HitPoints; g++)
                {
                    sb.AppendLine(String.Format("{0},{1}", ShipList[a].XLocation[g].ToString(), ShipList[a].YLocation[g].ToString()));
                }
                
            

            return sb.ToString();
        }


        public char ConvertToLetter(int vXGridNumber)
        {
            char xLetter;
            xLetter = Convert.ToChar(vXGridNumber + 64);

            return xLetter;
        }

    }

}

