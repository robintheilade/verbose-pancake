using CampingRaceGame.Scenes.SceneObjects;

namespace CampingRaceGame
{
    /// <summary>
    /// Represents a level in the game.
    /// </summary>
    public interface ILevel
    {
        /// <summary>
        /// Gets or sets the array of <see cref="SceneObject"/> in the current level.
        /// </summary>
        SceneObject[] SceneObjects
        {
            get;
            set;
        }
    }
}
