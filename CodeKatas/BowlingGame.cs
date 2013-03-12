using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CodeKatas
{
    class BowlingGame
    {
        //Count and sum the scores of a bowling game of one player

        //A bowling game consists of 10 frames in which the player tries to knock down  the 10 pins.  
        //In every frame the player can throw one or two times.  The actual number depends on strikes and spares.  
        //The score of a frame is the number of knocked down pins plus bonuses for strikes and spares.  
        //After every frame the 10 pins are reset.

        //The player has a strike if he knocks down all 10 pins with the first rolll in a frame.  The frame ends 
        //immediately (since there are no pins left for a second roll).  The vonus for that frame is the number of 
        //pins knocked down by the next two rolls.  That is the next frame, except if the player rolls a strike 
        //again.

        //The player has a spare if he knocks down all 1- pins with the two roles of a frame.  The bonus for that 
        //frame i the number of pins knocked down by the enxt roll (first roll of the next frame).

        //10th frame:  If the player rolls a strike or spare in the 10th frame he can roll the additional balls for 
        //the bonus.  But he cn never roll more than 3 balls in teh 10th frame.  The additional rolls only counbt 
        //for the onbus not for the regular frame count:  10, 10, 10 in the 10th frame gives 230 pints (10 points 
        //for the first strike and 20 points for the bonus)  1,0 10 in the 120th frame gives 20 points.

        //A gutter game is when the player never hits a pin (20 zero scores)

        //A perfect game is when the player rolls 12 strikes (10 regualr strikes and 2 strikes for the bonus in the 
        //10th frame.  The perfect games scores to 300 points. 

        //Write a class BowlingGame with two methods:  roll(pins : int) and score() : int  For every roll the roll 
        //method is called.  the score method returns the total score. 

        private void CalculateSimple()
        {
            
        }
    }
}
