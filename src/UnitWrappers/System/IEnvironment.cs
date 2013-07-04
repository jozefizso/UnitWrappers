using System;
using System.Collections;
using System.Security;

namespace UnitWrappers.System
{
    /// <summary>
    /// Provides information about, and means to manipulate, the current environment and platform. 
    /// </summary>
    public interface IEnvironment
    {
        /// <inheritdoc />
        string CommandLine { get; }

        /// <inheritdoc />
        string CurrentDirectory { get; set; }

        /// <inheritdoc />
        int ExitCode { get; set; }

        /// <inheritdoc />
        bool HasShutdownStarted { get; }
#if !NET35 && !ANDROID

        /// <inheritdoc />
        bool Is64BitOperatingSystem { get; }

        /// <inheritdoc />
        bool Is64BitProcess { get; }

        /// <inheritdoc />
        int SystemPageSize { get; }
#endif

        /// <inheritdoc />
        string MachineName { get; }

        /// <inheritdoc />
        string NewLine { get; }

        /// <inheritdoc />
        OperatingSystem OSVersion { get; }

        /// <inheritdoc />
        int ProcessorCount { get; }

        /// <inheritdoc />
        string StackTrace { get; }
        #if !ANDROID
        /// <inheritdoc />
        string SystemDirectory { get; }
#endif


        /// <inheritdoc />
        int TickCount { get; }

        /// <inheritdoc />
        string UserDomainName { get; }

        /// <inheritdoc />
        bool UserInteractive { get; }

        /// <inheritdoc />
        string UserName { get; }

        /// <inheritdoc />
        Version Version { get; }

        /// <inheritdoc />
        long WorkingSet { get; }

        /// <summary>
        /// Terminates this process and gives the underlying operating system the specified exit code.
        /// </summary>
        /// <param name="exitCode">Exit code to be given to the operating system.</param>
        /// <exception cref="SecurityException">The caller does not have sufficient security permission to perform this function.</exception>
        void Exit(int exitCode);

        /// <inheritdoc />
        void FailFast(string message);

        /// <summary>
        /// Replaces the name of each environment variable embedded in the specified string with the string equivalent of the value of the variable, then returns the resulting string
        /// </summary>
        /// <param name="name">A string containing the names of zero or more environment variables. Each environment variable is quoted with the percent sign character (%).</param>
        /// <returns>A string with each environment variable replaced by its value.</returns>
        /// <exception cref="ArgumentNullException">name is null</exception>
        void ExpandEnvironmentVariables(string name);

        /// <inheritdoc />
        string[] GetCommandLineArgs();

        /// <inheritdoc />
        string GetEnvironmentVariable(string variable);

#if !ANDROID
        /// <inheritdoc />
        string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target);
#endif
        /// <inheritdoc />
        IDictionary GetEnvironmentVariables();
        #if !ANDROID
        /// <inheritdoc />
        IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target);
#endif
        /// <inheritdoc />
        string GetFolderPath(global::System.Environment.SpecialFolder folder);

        /// <inheritdoc />
        string[] GetLogicalDrives();

#if !ANDROID
        /// <inheritdoc />
        void SetEnvironmentVariable(string variable, string value);

        /// <inheritdoc />
        void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target);
#endif
    }
}