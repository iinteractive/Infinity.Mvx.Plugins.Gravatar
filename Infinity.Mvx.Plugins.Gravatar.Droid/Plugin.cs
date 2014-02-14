using Cirrious.CrossCore.Plugins;

namespace Infinity.Mvx.Plugins.Gravatar.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Cirrious.CrossCore.Mvx.RegisterSingleton<IMvxGravatarTask>(new MvxDroidGravatar());
        }
    }
}