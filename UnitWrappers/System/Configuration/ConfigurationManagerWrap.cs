using System.Collections.Specialized;
using System.Configuration;

namespace UnitWrappers.System.Configuration
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Configuration.ConfigurationManager"/> class.
    /// </summary>
    public class ConfigurationManagerWrap : IConfigurationManager
    {
        /// <inheritdoc />
        public NameValueCollection AppSettings
        {
            get { return ConfigurationManager.AppSettings; }
        }

		/// <inheritdoc />
        public ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return ConfigurationManager.ConnectionStrings; }
        }

		/// <inheritdoc />
		public object GetSection(string pSectionName)
		{
			return ConfigurationManager.GetSection(pSectionName);
		}

		/// <inheritdoc />
		public global::System.Configuration.Configuration OpenExeConfiguration(string exePath)
		{
            return ConfigurationManager.OpenExeConfiguration(exePath);
		}

		/// <inheritdoc />
		public global::System.Configuration.Configuration OpenExeConfiguration(ConfigurationUserLevel pConfigurationUserLevel)
		{
			return ConfigurationManager.OpenExeConfiguration(pConfigurationUserLevel);
		}

		/// <inheritdoc />
		public global::System.Configuration.Configuration OpenMachineConfiguration()
		{
			return ConfigurationManager.OpenMachineConfiguration();
		}

		/// <inheritdoc />
		public global::System.Configuration.Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap pExeConfigurationFileMap, ConfigurationUserLevel pConfigurationUserLevel)
		{
			return ConfigurationManager.OpenMappedExeConfiguration(pExeConfigurationFileMap, pConfigurationUserLevel);
		}

		/// <inheritdoc />
		public global::System.Configuration.Configuration OpenMappedMachineConfiguration(ConfigurationFileMap pConfigurationFileMap)
		{

			return ConfigurationManager.OpenMappedMachineConfiguration(pConfigurationFileMap);
		}

		/// <inheritdoc />
		public void RefreshSection(string pSectionName)
		{
			ConfigurationManager.RefreshSection(pSectionName);
		}
    }
}