using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton.AppConfig
{
    sealed class ConfigManager
    {
        private readonly IDictionary<string, object> _settings = new Dictionary<string, object>();
        private readonly static Lazy<ConfigManager> _instance = new Lazy<ConfigManager>(() => new ConfigManager());

        private ConfigManager() {}

        public static ConfigManager Instance => _instance.Value;

        public void Set(string key, object value)
        {
            _settings.Add(key, value);
        }

        public object Get(string key)
        {
            return _settings[key];
        }

    }
}
