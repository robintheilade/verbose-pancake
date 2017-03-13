using Microsoft.Xna.Framework;

namespace CampingRaceGame.Scenes
{
    public interface IScene
    {
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime);

        void Load();
        void Unload();
    }
}
