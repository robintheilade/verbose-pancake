namespace CampingRaceGame.Scenes
{
    public interface ISceneManager
    {
        void ChangeScene<TScene>(params object[] args) where TScene : IScene;
    }
}
