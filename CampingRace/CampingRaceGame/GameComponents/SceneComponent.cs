using CampingRaceGame.Scenes;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CampingRaceGame.GameComponents
{
    public class SceneComponent : DrawableGameComponent, ISceneManager
    {
        private readonly Func<IEnumerable<IScene>> scenesFactory;
        private IEnumerable<IScene> scenes;
        private IScene currentScene;

        public SceneComponent(Game game, Func<IEnumerable<IScene>> scenesFactory) : base(game)
        {
            if(scenesFactory == null)
            {
                throw new ArgumentNullException(nameof(scenesFactory));
            }

            this.scenesFactory = scenesFactory;
        }

        public override void Initialize()
        {
            base.Initialize();
            this.scenes = this.scenesFactory();
            this.ChangeScene<IInitialScene>();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.currentScene.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            this.currentScene.Draw(gameTime);
        }

        public void ChangeScene<TScene>() where TScene : IScene
        {
            var scene = this.scenes.OfType<TScene>().First();

            if(this.currentScene != null)
            {
                this.currentScene.Unload();
            }

            this.currentScene = scene;
            this.currentScene.Load();
        }
    }
}
