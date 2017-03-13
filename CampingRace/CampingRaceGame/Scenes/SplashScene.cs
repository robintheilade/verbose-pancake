using Microsoft.Xna.Framework;
using System;

namespace CampingRaceGame.Scenes
{
    public class SplashScene : ISplashScene, IInitialScene
    {
        private readonly ISceneManager sceneManager;
        private readonly Game game;
        private double timeout;

        public SplashScene(ISceneManager sceneManager, Game game)
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
            this.timeout = 2000;
        }

        public void Load()
        {
        }

        public void Unload()
        {
        }

        public void Update(GameTime gameTime)
        {
            this.timeout -= gameTime.ElapsedGameTime.TotalMilliseconds;
            if (this.timeout <= 0.0d)
            {
                this.sceneManager.ChangeScene<IMainMenuScene>();
            }
        }

        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Silver);
        }
    }
}
