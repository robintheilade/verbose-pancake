using Autofac;

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
                .AsImplementedInterfaces()
                .SingleInstance()
                ;
        }
    }
}
