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
        private SceneObject[] sceneObjects;
        private bool changedScene;

        public SceneObject[] SceneObjects
        {
            get;
            private set;
        }

        public LevelLoaderScene(ISceneManager sceneManager, Game game, ISceneObjectFactory sceneObjectFactory)
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

            this.sceneManager = sceneManager;
            this.game = game;
            this.sceneObjectFactory = sceneObjectFactory;
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
                this.SceneObjects = this.sceneObjects;
                this.sceneManager.ChangeScene<ILevelScene>();
            }
        }

        public void Draw(GameTime gameTime)
        {
        }
    }
}
