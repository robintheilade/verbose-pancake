﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
            var keyboard = Keyboard.GetState();
            if(keyboard.IsKeyDown(Keys.F1))
            {
                this.sceneManager.ChangeScene<ILevelLoaderScene>();
            }
        }

        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Gold);
        }
    }
}
