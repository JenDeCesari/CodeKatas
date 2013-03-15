using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas
{
    class BerlinClock
    {
        public static void CalculateSimple(DateTime time)
        {            
            int hour = time.Hour;
            int minutes = time.Minute;
            int seconds = time.Second;
            int redHourFirstRow = 0;
            string RHFirstRow = string.Empty;
            int redHourSecondRow = 0;
            string RHSecondRow = string.Empty;
            int redMinutesFirstRow = 0;
            string RMFirstRow = string.Empty;
            int redMinuteSecondRow = 0;
            string RMSecondRow = string.Empty;
            bool yellowSeconds;
            bool red3 = false ;
            bool red6 = false;
            bool red9 = false;
            StringBuilder output = new StringBuilder("\n\n");

            string t = time.ToShortTimeString();
            
            output.Append(t);
            output.Append("\n");

            while (hour != 0)
            {
                if (hour >= 5)
                {
                    redHourFirstRow++;
                    hour -= 5;
                }

                if (hour <= 4)
                {
                    redHourSecondRow++;
                    hour -= 1;
                }
            }

            if (minutes >= 45)
            {
                red9 = true;
                minutes -= 45;
            }

            if (minutes >= 30)
            {
                red6 = true;
                minutes -= 30;
            }

            if (minutes >= 15)
            {
                red3 = true;
                minutes -= 15;
            }

            while (minutes != 0)
            {
                if (minutes >= 5)
                {
                    redMinutesFirstRow++;
                    minutes -= 5;
                }

                if (minutes <= 4)
                {
                    redMinuteSecondRow++;
                    minutes -= 1;
                }
            }

            int y;
            int x = Math.DivRem(seconds, 2, out y);

            if (y == 0)
            {
                yellowSeconds = true;
            }
            else
            {
                yellowSeconds = false;
            }

            if (yellowSeconds)
                output.Append("\n\nBerlin Clock:\n\nY\n");
            else
                output.Append("\n\nBerlin Clock:\n\nO\n");
            #region refactor

            if (redHourFirstRow >= 0)
            {
                switch (redHourFirstRow)
                {
                    case 1:
                        RHFirstRow += "ROOO\n";
                        break;
                    case 2:
                        RHFirstRow += "RROO\n";
                        break;
                    case 3:
                        RHFirstRow += "RRRO\n";
                        break;
                    case 4:
                        RHFirstRow += "RRRR\n";
                        break;
                    default:
                        RHFirstRow += "OOOO\n";
                        break;
                }                              
            }
            if (redHourSecondRow >= 0)
            {                
                switch (redHourSecondRow)
                {
                    case 1:
                        RHSecondRow += "ROOO\n";
                        break;
                    case 2:
                        RHSecondRow += "RROO\n";
                        break;
                    case 3:
                        RHSecondRow += "RRRO\n";
                        break;
                    case 4:
                        RHSecondRow += "RRRR\n";
                        break;
                    default:
                        RHSecondRow += "OOOO\n";
                        break;
                }
            }
            switch (redMinutesFirstRow)
            {
                case 1:
                    if (red3 == true)
                    {
                        RMFirstRow += "YYRYOOOOOOO\n";
                    }
                    if (red6 == true)
                    {
                        RMFirstRow += "YYRYYRYOOOO\n";
                    }
                    if (red9 == true)
                    {
                        RMFirstRow += "YYRYYRYYRYO\n";
                    }
                    else
                    {
                        RMFirstRow += "YOOOOOOOOOO\n";
                    }
                    break;
                case 2:
                    if (red3 == true)
                    {
                        RMFirstRow += "YYROOOOOOOO\n";
                    }
                    if (red6 == true)
                    {
                        RMFirstRow += "YYRYYRYYOOO\n";
                    }
                    if (red9 == true)
                    {
                        RMFirstRow += "YYRYYRYYRYY\n";
                    }
                    else
                    {
                        RMFirstRow += "YYOOOOOOOOO\n";
                    }
                    break;
              
                case 0:
                    if (red3 == true)
                    {
                        RMFirstRow += "YYROOOOOOOO\n";
                    }
                    if (red6 == true)
                    {
                        RMFirstRow += "YYRYYROOOOO\n";
                    }
                    if (red9 == true)
                    {
                        RMFirstRow += "YYRYYRYYROO\n";
                    }
                    else
                    {
                        RMFirstRow += "OOOOOOOOOOO\n";
                    }
                    break;
                default:
                    RMFirstRow += "OOOOOOOOOOO\n";
                    break;
            }           

            if (redMinuteSecondRow >= 0)
            {
                switch (redMinuteSecondRow)
                {
                    case 1:
                        RMSecondRow += "YOOO\n";
                        break;
                    case 2:
                        RMSecondRow += "YYOO\n";
                        break;
                    case 3:
                        RMSecondRow += "YYYO\n";
                        break;
                    case 4:
                        RMSecondRow += "YYYY\n";
                        break;
                    default:
                        RMSecondRow += "OOOO\n";
                        break;
                }
            }

            string end = RHFirstRow +  RHSecondRow + RMFirstRow + RMSecondRow;
            output.Append(end);

            Console.WriteLine(output);
            Console.ReadKey();

        }            
            #endregion
    }
}

/// <summary>
/// Create a representation of the Berlin Clock for a given time (hh::mm:ss).

//The Berlin Uhr (Clock) is a rather strange way to show the time. 
//On the top of the clock there is a yellow lamp that blinks on/off every two seconds. 
//The time is calculated by adding rectangular lamps.

//The top two rows of lamps are red. These indicate the hours of a day. In the top row there are 4 red lamps. 
//Every lamp represents 5 hours. In the lower row of red lamps every lamp represents 1 hour. 
//So if two lamps of the first row and three of the second row are switched on that indicates 5+5+3=13h or 1 pm.

//The two rows of lamps at the bottom count the minutes. The first of these rows has 11 lamps, the second 4. 
//In the first row every lamp represents 5 minutes. 
//In this first row the 3rd, 6th and 9th lamp are red and indicate the first quarter, half and last quarter of an hour. 
//The other lamps are yellow. In the last row with 4 lamps every lamp represents 1 minute.

//The lamps are switched on from left to right.
/// </summary>