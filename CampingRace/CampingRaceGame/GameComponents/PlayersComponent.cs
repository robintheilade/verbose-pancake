using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CampingRaceGame.GameComponents
{
    public class PlayersComponent : DrawableGameComponent
    {
        private Texture2D humanTexture;
        private Vector2 humanPosition;
        private float movementMultiplier = 100.0f;
        private float humanTextureScale = 0.25f;
        private SpriteBatch spriteBatch;

        public PlayersComponent(Game game) : base(game)
        {
        }

        protected override void LoadContent()
        {
            this.humanTexture = this.Game.Content.Load<Texture2D>("Textures/Human");
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            base.LoadContent();
        }

        protected override void Dispose(bool disposing)
        {
            this.humanTexture.Dispose();
            this.spriteBatch.Dispose();
            base.Dispose(disposing);
        }

        public override void Update(GameTime gameTime)
        {
            var keyboard = Keyboard.GetState();
            if (keyboard.IsKeyDown(Keys.Right))
            {
                this.humanPosition.X += (float)gameTime.ElapsedGameTime.TotalSeconds * this.movementMultiplier;
            }
            else if (keyboard.IsKeyDown(Keys.Left))
            {
                this.humanPosition.X -= (float)gameTime.ElapsedGameTime.TotalSeconds * this.movementMultiplier;
            }
            this.humanPosition.Y = this.Game.Window.ClientBounds.Height - this.humanTexture.Height * this.humanTextureScale;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            var spriteBatch = this.spriteBatch;
            spriteBatch.Begin();
            spriteBatch.Draw(this.humanTexture, this.humanPosition, null, Color.White, 0.0f, Vector2.Zero, this.humanTextureScale, SpriteEffects.None, 0.0f);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
