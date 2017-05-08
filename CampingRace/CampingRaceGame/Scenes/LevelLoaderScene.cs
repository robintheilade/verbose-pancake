using CampingRaceGame.Scenes.SceneObjects;
using Microsoft.Xna.Framework;
using System;

namespace CampingRaceGame.Scenes
{
    public class LevelLoaderScene : ILevelLoaderScene
    {
        private readonly ISceneManager sceneManager;
        private readonly Game game;
        private readonly ISceneObjectFactory sceneObjectFactory;
        private readonly ILevel level;
        private SceneObject[] sceneObjects;
        private bool changedScene;

        public LevelLoaderScene(ISceneManager sceneManager, Game game, ISceneObjectFactory sceneObjectFactory, ILevel level)
        {
            if (sceneManager == null)
            {
                throw new ArgumentNullException(nameof(sceneManager));
            }
            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }
            if (sceneObjectFactory == null)
            {
                throw new ArgumentNullException(nameof(sceneObjectFactory));
            }
            if(level == null)
            {
                throw new ArgumentNullException(nameof(level));
            }

            this.sceneManager = sceneManager;
            this.game = game;
            this.sceneObjectFactory = sceneObjectFactory;
            this.level = level;
        }

        public void Load()
        {
            var tree = this.sceneObjectFactory.CreateTree();
            var player = this.sceneObjectFactory.CreatePlayer();

            this.sceneObjects = new SceneObject[]
            {
                tree,
                player,
            };
        }

        public void Unload()
        {
        }

        public void Update(GameTime gameTime)
        {
            if(!this.changedScene)
            {
                this.changedScene = true;
                this.level.SceneObjects = this.sceneObjects;
                this.sceneManager.ChangeScene<ILevelScene>();
            }
        }

        public void Draw(GameTime gameTime)
        {
        }
    }
}
