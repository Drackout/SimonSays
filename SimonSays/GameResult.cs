namespace SimonSays
{
    /// <summary>
    /// Represents the result of a game, including the losing pattern, the time 
    /// taken to finish, and the round number.
    /// </summary>
    public class GameResult
    {
        /// <summary>
        /// Gets the losing pattern for the game.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the losing pattern that caused 
        /// the loss in the game.
        /// </value>
        public string LosingPattern { get; }

        /// <summary>
        /// Gets the time taken to complete the game.
        /// </summary>
        /// <value>
        /// A <see cref="double"/> representing the time in seconds taken to 
        /// complete the game.
        /// </value>
        public double TimeTaken { get; }

        /// <summary>
        /// Gets the round number of the game.
        /// </summary>
        /// <value>
        /// An <see cref="int"/> representing the round number of the game.
        /// </value>
        public int Round { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameResult"/> class 
        /// with the specified losing pattern, time taken, and round number.
        /// </summary>
        /// <param name="losingPattern">The pattern that caused the loss in the 
        /// game, of type <see cref="string"/>.</param>
        /// <param name="timeTaken">The time taken to complete the game, of 
        /// type <see cref="double"/> (in seconds).</param>
        /// <param name="round">The round number of the game, of 
        /// type <see cref="int"/>.</param>
        public GameResult(string losingPattern, double timeTaken, int round)
        {
            LosingPattern = losingPattern; 
            TimeTaken = timeTaken; 
            Round = round; 
        }
        public GameResult()
        {}
    }
}