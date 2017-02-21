using Autofac;
using CampingRaceGame.Autofac;
using Microsoft.Xna.Framework;
using System;

namespace CampingRaceWindows
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var scope = AutofacConfig.Register())
            {
                using (var game = scope.Resolve<Game>())
                {
                    game.Run();
                }
            }
        }
    }
#endif
}
