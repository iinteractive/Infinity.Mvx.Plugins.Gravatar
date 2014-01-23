using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Infinity.Mvx.Plugins.Gravatar.Touch
{
    public class MvxGravatarTask
        : IMvxGravatarTask
    {
        private static MD5 _md5Hasher;

        static MvxGravatarTask()
        {
            _md5Hasher = MD5.Create();
        }

        public Uri CreateGravatarUrl(string email, int size)
        {
            var hashString = _md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(email.Trim()));

            return new Uri(string.Format("http://www.gravatar.com/avatar/{0}.jpg?s={1}&d=mm", hashString, size));
        }
    }
}