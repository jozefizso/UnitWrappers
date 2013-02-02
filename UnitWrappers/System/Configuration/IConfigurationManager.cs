using System.Collections.Specialized;
using System.Configuration;

namespace UnitWrappers.System.Configuration
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Configuration.ConfigurationManager"/> class.
    /// </summary>
    public interface IConfigurationManager
    {
        // Properties

        /// <summary>
        /// Gets the AppSettingsSection  data for the current application's default configuration.
        /// </summary>
        NameValueCollection AppSettings { get; }

        /// <summary>
        /// Gets the ConnectionStringsSection  data for the current application's default configuration.
        /// </summary>
        ConnectionStringSettingsCollection ConnectionStrings { get; }

		object GetSection(string sectionName);
		global::System.Configuration.Configuration OpenExeConfiguration(string exePath);
		global::System.Configuration.Configuration OpenExeConfiguration(ConfigurationUserLevel configurationUserLevel);
		global::System.Configuration.Configuration OpenMachineConfiguration();
		global::System.Configuration.Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap exeConfigurationFileMap, ConfigurationUserLevel configurationUserLevel);
		global::System.Configuration.Configuration OpenMappedMachineConfiguration(ConfigurationFileMap configurationFileMap);
		void RefreshSection(string sectionName);


    }
}