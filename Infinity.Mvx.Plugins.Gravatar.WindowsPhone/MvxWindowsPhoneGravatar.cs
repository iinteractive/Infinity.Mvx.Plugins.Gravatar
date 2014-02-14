using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Mvx.Plugins.Gravatar.WindowsPhone
{
    public class MvxWindowsPhoneGravatar
        : IMvxGravatarTask
    {
        private static readonly Func<byte[], byte[]> Md5;

        static MvxWindowsPhoneGravatar()
        {
            Md5 = MD5Core.GetHash;
        }

        public Uri CreateGravatarUri(string email, int size)
        {
            return new Uri(CreateGravatarUrl(email, size));
        }

        public string CreateGravatarUrl(string email, int size)
        {
            var hashString = Md5(Encoding.UTF8.GetBytes(email.Trim()));

            return string.Format("http://www.gravatar.com/avatar/{0}.jpg?s={1}&d=mm", string.Join("", hashString.Select(s => s.ToString("x2"))), size);
        }
    }
}
