namespace CampingRaceGame.Scenes
{
    public interface ISceneFactory
    {
        TScene Create<TScene>(params object[] args) where TScene : IScene;
    }
}
