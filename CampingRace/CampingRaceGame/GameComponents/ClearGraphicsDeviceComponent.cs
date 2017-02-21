using Microsoft.Xna.Framework;

namespace CampingRaceGame.GameComponents
{
    public class ClearGraphicsDeviceComponent : DrawableGameComponent, IDrawable
    {
        public ClearGraphicsDeviceComponent(Game game)
            : base(game)
        {
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            this.GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
