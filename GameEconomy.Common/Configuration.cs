using Microsoft.Extensions.Configuration;

namespace GameEconomy.Common
{
    public static class Configuration
    {
        public static T SettingsFromConfiguration<T>(this IConfiguration configuration) where T : new()
        {
            return configuration.GetSection(typeof(T).Name).Get<T>();
        }
    }
}
