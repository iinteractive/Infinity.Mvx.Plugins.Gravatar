using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Mvx.Plugins.Gravatar
{
    public interface IMvxGravatarTask
    {
        Uri CreateGravatarUrl(string email, int size);
    }
}
