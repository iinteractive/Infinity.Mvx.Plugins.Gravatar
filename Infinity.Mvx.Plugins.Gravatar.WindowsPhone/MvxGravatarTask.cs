using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Mvx.Plugins.Gravatar.WindowsPhone
{
    public class MvxGravatarTask
        : IMvxGravatarTask
    {
        private static readonly SHA1 _md5Hasher;

        static MvxGravatarTask()
        {
            _md5Hasher = new SHA1Managed();
        }

        public Uri CreateGravatarUrl(string email, int size)
        {
            var hashString = _md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(email.Trim()));

            return new Uri(string.Format("http://www.gravatar.com/avatar/{0}.jpg?s={1}&d=mm", hashString, size));
        }
    }
}
