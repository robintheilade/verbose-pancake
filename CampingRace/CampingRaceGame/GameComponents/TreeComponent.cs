using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CampingRaceGame.GameComponents
{
    public class TreeComponent : DrawableGameComponent
    {
        private Texture2D treeTexture;
        private SpriteBatch spriteBatch;
        private Vector2 position;

        public TreeComponent(Game game) : base(game)
        {
        }

        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            this.treeTexture = this.Game.Content.Load<Texture2D>("Textures/Tree");
            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            this.spriteBatch.Dispose();
            this.treeTexture.Dispose();
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            this.position.Y = this.Game.Window.ClientBounds.Height - this.treeTexture.Height;
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            var spriteBatch = this.spriteBatch;
            spriteBatch.Begin();
            spriteBatch.Draw(this.treeTexture, this.position, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
