namespace CampingRaceGame.Scenes
{
    public interface ISceneManager
    {
        void ChangeScene<TScene>() where TScene : IScene;
    }
}
