using CampingRaceGame.GameComponents;
using Microsoft.Xna.Framework;
using System;

namespace CampingRaceGame.Scenes
{
    public class LevelScene : ILevelScene
    {
        private readonly ISceneManager sceneManager;
        private readonly Game game;
        private readonly ILevel level;
        private PlayersComponent playersComponent;

        public LevelScene(ISceneManager sceneManager, Game game, ILevel level)
        {
            if (sceneManager == null)
            {
                throw new ArgumentNullException(nameof(sceneManager));
            }
            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }
            if (level == null)
            {
                throw new ArgumentNullException(nameof(level));
            }

            this.sceneManager = sceneManager;
            this.game = game;
            this.level = level;
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
            this.game.GraphicsDevice.Clear(Color.LemonChiffon);
            foreach (var sceneObject in this.level.SceneObjects)
            {
                sceneObject.Draw();
            }
        }
    }
}
