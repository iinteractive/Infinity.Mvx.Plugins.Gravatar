using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Infinity.Mvx.Plugins.Gravatar.Droid
{
    public class MvxDroidGravatar
        : IMvxGravatarTask
    {
        private static MD5 _md5Hasher;

        static MvxDroidGravatar()
        {
            _md5Hasher = MD5.Create();
        }

        public Uri CreateGravatarUri(string email, int size)
        {
            return new Uri(CreateGravatarUrl(email, size));
        }

        public string CreateGravatarUrl(string email, int size)
        {
            var hashString = _md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(email.Trim()));

            var url = string.Format("http://www.gravatar.com/avatar/{0}.jpg?s={1}&d=mm", string.Join("", hashString.Select (x => x.ToString("x2"))), size);
            return url;
        }
    }
}