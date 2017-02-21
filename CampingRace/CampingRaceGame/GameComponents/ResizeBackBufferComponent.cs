using Microsoft.Xna.Framework;
using System;

namespace CampingRaceGame.GameComponents
{
    public class ResizeBackBufferComponent : DrawableGameComponent, IDrawable
    {
        private readonly GraphicsDeviceManager graphicsDeviceManager;

        public ResizeBackBufferComponent(Game game, GraphicsDeviceManager graphicsDeviceManager) : base(game)
        {
            if (graphicsDeviceManager == null)
            {
                throw new ArgumentNullException(nameof(graphicsDeviceManager));
            }

            this.graphicsDeviceManager = graphicsDeviceManager;
        }

        public override void Initialize()
        {
            base.Initialize();

            var displayMode = this.GraphicsDevice.DisplayMode;
            this.graphicsDeviceManager.PreferredBackBufferWidth = displayMode.Width;
            this.graphicsDeviceManager.PreferredBackBufferHeight = displayMode.Height;
            this.graphicsDeviceManager.ApplyChanges();

            this.Enabled = false;
            this.Visible = false;
        }
    }
}
