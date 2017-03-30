using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampingRaceGame.Scenes.SceneObjects
{
    public class SpriteSceneObjectComponent : ISceneObjectComponent
    {
        private readonly SceneObject owner;
        private readonly string textureName;
        private readonly Game game;

        public SpriteSceneObjectComponent(SceneObject owner, string textureName, Game game)
        {
            this.owner = owner;
            this.textureName = textureName;
            this.game = game;
        }
    }
}
