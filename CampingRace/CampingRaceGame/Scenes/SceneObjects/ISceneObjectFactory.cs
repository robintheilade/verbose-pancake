namespace CampingRaceGame.Scenes.SceneObjects
{
    public interface ISceneObjectFactory
    {
        SceneObject CreateTree();
        SceneObject CreatePlayer();
    }
}
