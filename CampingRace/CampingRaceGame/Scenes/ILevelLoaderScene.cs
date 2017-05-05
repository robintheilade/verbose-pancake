using CampingRaceGame.Scenes.SceneObjects;

namespace CampingRaceGame.Scenes
{
    public interface ILevelLoaderScene : IScene
    {
        SceneObject[] SceneObjects
        {
            get;
        }
    }
}