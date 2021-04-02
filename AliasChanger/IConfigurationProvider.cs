using System.Collections.Generic;

namespace AliasChanger
{
    interface IConfigurationProvider
    {
        Dictionary<string, string> GetConfiguration();
    }
}
