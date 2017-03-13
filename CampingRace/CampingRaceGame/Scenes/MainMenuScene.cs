using Microsoft.Xna.Framework;
using System;

namespace CampingRaceGame.Scenes
{
    public class MainMenuScene : IMainMenuScene
    {
        private readonly ISceneManager sceneManager;
        private readonly Game game;

        public MainMenuScene(ISceneManager sceneManager, Game game)
        {
            if (sceneManager == null)
            {
                throw new ArgumentNullException(nameof(sceneManager));
            }
            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }

            this.sceneManager = sceneManager;
            this.game = game;
        }

        public void Load()
        {
        }

        public void Unload()
        {
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Gold);
        }
    }
}
