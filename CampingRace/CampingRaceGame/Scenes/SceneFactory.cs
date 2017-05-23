using Autofac;
using System;

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

        public TScene Create<TScene>() where TScene : IScene
        {
            return this.scope.Resolve<TScene>();
        }
    }
}
