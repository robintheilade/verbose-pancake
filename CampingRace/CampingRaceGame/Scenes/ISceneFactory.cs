namespace CampingRaceGame.Scenes
{
    public interface ISceneFactory
    {
        TScene Create<TScene>() where TScene : IScene;
    }
}
