using Autofac;
using Autofac.Core;

namespace CampingRaceGame.Autofac
{
    public class InterfaceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            var assembly = typeof(InterfaceModule).Assembly;
            builder
                .RegisterAssemblyTypes(assembly)
                .Except<GameModule>()
                .Except<InterfaceModule>()
                .AsImplementedInterfaces()
                .SingleInstance()
                ;
        }
    }
}
