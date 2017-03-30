using CampingRaceGame.GameComponents;
using CampingRaceGame.Scenes.SceneObjects;
using Microsoft.Xna.Framework;
using System;

namespace CampingRaceGame.Scenes
{
    public class LevelScene : ILevelScene
    {
        private readonly ISceneManager sceneManager;
        private readonly Game game;
        private SceneObject[] sceneObjects;
        private PlayersComponent playersComponent;

        public LevelScene(ISceneManager sceneManager, Game game, SceneObject[] sceneObjects)
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
            this.sceneObjects = sceneObjects;
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
            foreach (var sceneObject in this.sceneObjects)
            {
                sceneObject.Draw();
            }
        }
    }
}
