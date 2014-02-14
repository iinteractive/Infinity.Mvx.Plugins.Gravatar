using Cirrious.CrossCore.Plugins;

namespace Infinity.Mvx.Plugins.Gravatar.WindowsPhone
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Cirrious.CrossCore.Mvx.RegisterSingleton<IMvxGravatarTask>(new MvxWindowsPhoneGravatar());
        }
    }
}
