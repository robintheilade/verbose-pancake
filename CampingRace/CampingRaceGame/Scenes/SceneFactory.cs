using Autofac;
using System;
using System.Linq;

namespace CampingRaceGame.Scenes
{
    public class SceneFactory : ISceneFactory
    {
        private readonly ILifetimeScope scope;

        public SceneFactory(ILifetimeScope scope)
        {
            if(scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            this.scope = scope;
        }

        public TScene Create<TScene>(params object[] args) where TScene : IScene
        {
            var parameters = args.Select((o, i) => new PositionalParameter(i, o));
            return this.scope.Resolve<TScene>(parameters);
        }
    }
}
