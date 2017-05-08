using CampingRaceGame.Scenes.SceneObjects;

namespace CampingRaceGame
{
    public interface ILevel
    {
        SceneObject[] SceneObjects
        {
            get;
            set;
        }
    }
}
