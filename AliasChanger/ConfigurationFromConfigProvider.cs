using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AliasChanger
{
    public class ConfigurationFromConfigProvider : IConfigurationProvider
    {
        private readonly string configuration;
        public ConfigurationFromConfigProvider(string configuration)
        {
            this.configuration = configuration;
        }

        public Dictionary<string, string> GetConfiguration()
        {
            var json = File.ReadAllText(this.configuration);

            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return values;
        }
    }
}