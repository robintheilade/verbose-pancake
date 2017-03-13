using Autofac;
using Autofac.Core;
using CampingRaceGame.GameComponents;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace CampingRaceGame.Autofac
{
    public class GameModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder
                .RegisterType<GraphicsDeviceManager>()
                .AsImplementedInterfaces()
                .AsSelf()
                .SingleInstance()
                ;
            builder
                .RegisterType<Game>()
                .OnActivated(this.HandleGameActivated)
                .SingleInstance();
                ;
        }

        private void HandleGameActivated(IActivatedEventArgs<Game> obj)
        {
            var graphicsDeviceManager = obj.Context.Resolve<GraphicsDeviceManager>();
            //graphicsDeviceManager.IsFullScreen = true;

            var game = obj.Instance;
            game.Content.RootDirectory = "Content";

            var drawOrders = new[]
            {
                typeof(TreeComponent),
                typeof(PlayersComponent),
            };

            var components = obj.Context.Resolve<IEnumerable<IGameComponent>>();
            foreach (var component in components)
            {
                var drawable = component as IDrawable;
                if (drawable != null)
                {
                    var type = drawable.GetType();
                    drawable.DrawOrder = Array.IndexOf(drawOrders, type);
                }

                game.Components.Add(component);
            }
        }
    }
}
