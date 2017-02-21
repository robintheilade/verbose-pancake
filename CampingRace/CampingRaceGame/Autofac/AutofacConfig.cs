using Autofac;

namespace CampingRaceGame.Autofac
{
    public static class AutofacConfig
    {
        public static ILifetimeScope Register()
        {
            var assembly = typeof(AutofacConfig).Assembly;
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(assembly);
            var container = builder.Build();
            return container;
        }
    }
}
