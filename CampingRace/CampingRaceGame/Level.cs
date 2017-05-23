using CampingRaceGame.Scenes.SceneObjects;

namespace CampingRaceGame
{
    /// <summary>
    /// Represents a level in the game.
    /// </summary>
    public class Level : ILevel
    {
        /// <summary>
        /// Gets or sets the array of <see cref="SceneObject"/> in the current level.
        /// </summary>
        public SceneObject[] SceneObjects
        {
            get;
            set;
        }
    }
}
