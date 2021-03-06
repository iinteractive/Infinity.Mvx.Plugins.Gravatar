using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Converters;
using Cirrious.CrossCore.Plugins;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Infinity.Mvx.Plugins.Gravatar.Touch
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Cirrious.CrossCore.Mvx.RegisterSingleton<IMvxGravatarTask>(new MvxTouchGravatar());
        }
    }
}