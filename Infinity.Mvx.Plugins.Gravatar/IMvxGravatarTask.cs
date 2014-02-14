using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Mvx.Plugins.Gravatar
{
    public interface IMvxGravatarTask
    {
        Uri CreateGravatarUri(string email, int size);
        string CreateGravatarUrl(string email, int size);
    }
}
