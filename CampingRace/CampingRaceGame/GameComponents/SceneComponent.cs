using CampingRaceGame.Scenes;
using Microsoft.Xna.Framework;
using System;

namespace CampingRaceGame.GameComponents
{
    public class SceneComponent : DrawableGameComponent, ISceneManager
    {
        private readonly ISceneFactory scenesFactory;
        private IScene currentScene;

        public SceneComponent(Game game, ISceneFactory scenesFactory) : base(game)
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

        public void ChangeScene<TScene>(params object[] args) where TScene : IScene
        {
            var scene = this.scenesFactory.Create<TScene>(args);

            if(this.currentScene != null)
            {
                this.currentScene.Unload();
            }

            this.currentScene = scene;
            this.currentScene.Load();
        }
    }
}
