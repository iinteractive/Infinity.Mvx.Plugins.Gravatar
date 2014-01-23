using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Infinity.Mvx.Plugins.Gravatar.WindowsStore
{
    public class MvxGravatarTask
        : IMvxGravatarTask
    {

        private static HashAlgorithmProvider _algorithmProvider;
        private static IBuffer _buffer;

        static MvxGravatarTask()
        {
            _algorithmProvider = HashAlgorithmProvider.OpenAlgorithm("MD5");
        }

        public Uri CreateGravatarUrl(string email, int size)
        {
            _buffer = CryptographicBuffer.ConvertStringToBinary((email ?? string.Empty).Trim(), BinaryStringEncoding.Utf8);
            var hashed = _algorithmProvider.HashData(_buffer);

            return new Uri(string.Format("http://www.gravatar.com/avatar/{0}.jpg?s={1}&d=mm", CryptographicBuffer.EncodeToHexString(hashed), size));
        }
    }
}
