namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>A disk used in Air Hockey.</para>
    /// <para>Hitting the puck into your opponent's goal earns you a point.</para>
    /// </summary>
    public class Puck : Actor
    {
        public bool isActive;
        public int score;
        public int radius = 30;

        /// <summary>
        /// Constructs a new instance of a Puck.
        /// </summary>
        public Puck()
        {
            isActive = false;
            score = 0;
        }
        
        /// <summary>
        /// Determines that the puck has a radius.
        /// </summary>
        public override bool HasRadius()
        {
            return true;
        }

        /// <summary>
        /// Determines whether the game has been won.
        /// </summary>
        public bool WonGame()
        {
            if (score == 7)
                return true;
            else
                return false;
        }
    }
}