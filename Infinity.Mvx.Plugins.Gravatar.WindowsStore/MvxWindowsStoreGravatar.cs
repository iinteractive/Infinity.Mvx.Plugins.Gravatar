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
    public class MvxWindowsStoreGravatar
        : IMvxGravatarTask
    {

        private static readonly HashAlgorithmProvider _algorithmProvider;
        private static IBuffer _buffer;

        static MvxWindowsStoreGravatar()
        {
            _algorithmProvider = HashAlgorithmProvider.OpenAlgorithm("MD5");
        }

        public Uri CreateGravatarUri(string email, int size)
        {
            return new Uri(CreateGravatarUrl(email, size));
        }

        public string CreateGravatarUrl(string email, int size)
        {
            _buffer = CryptographicBuffer.ConvertStringToBinary((email ?? string.Empty).Trim(), BinaryStringEncoding.Utf8);
            var hashed = _algorithmProvider.HashData(_buffer);

            return string.Format("http://www.gravatar.com/avatar/{0}.jpg?s={1}&d=mm", CryptographicBuffer.EncodeToHexString(hashed), size);
        }
    }
}
