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

		object GetSection(string pSectionName);
		global::System.Configuration.Configuration OpenExeConfiguration(string pExePath);
		global::System.Configuration.Configuration OpenExeConfiguration(ConfigurationUserLevel pConfigurationUserLevel);
		global::System.Configuration.Configuration OpenMachineConfiguration();
		global::System.Configuration.Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap pExeConfigurationFileMap, ConfigurationUserLevel pConfigurationUserLevel);
		global::System.Configuration.Configuration OpenMappedMachineConfiguration(ConfigurationFileMap pConfigurationFileMap);
		void RefreshSection(string pSectionName);

        /*
                // Methods
            public static object GetSection(string sectionName);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenExeConfiguration(ConfigurationUserLevel userLevel);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenExeConfiguration(string exePath);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenMachineConfiguration();
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenMappedExeConfiguration(ExeConfigurationFileMap fileMap, ConfigurationUserLevel userLevel);
            [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
            public static System.Configuration.Configuration OpenMappedMachineConfiguration(ConfigurationFileMap fileMap);
            public static void RefreshSection(string sectionName);
        */
    }
}