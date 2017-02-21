using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Autofac;
using CampingRaceGame.Autofac;
using Microsoft.Xna.Framework;

namespace CampingRaceAndroid
{
    [Activity(Label = "CampingRaceAndroid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = Android.Content.PM.LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.SensorLandscape
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class Activity : Microsoft.Xna.Framework.AndroidGameActivity
    {
        private ILifetimeScope scope;
        private Game game;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.scope = AutofacConfig.Register();
            this.game = this.scope.Resolve<Game>();
            SetContentView((View)this.game.Services.GetService(typeof(View)));
            this.game.Run();
        }

        protected override void OnDestroy()
        {
            this.game.Dispose();
            this.scope.Dispose();
            base.OnDestroy();
        }
    }
}

