using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitWrappers.System
{
    /// <summary>
    /// Wraps <see cref="Environment"/>
    /// </summary>
    public class EnvironmentWrap : IEnvironment
    {
        /// <inheritdoc />
        public string CommandLine
        {
            get
            {
                return global::System.Environment.CommandLine;
            }
        }
        /// <inheritdoc />
        public string CurrentDirectory
        {
            get
            {
                return global::System.Environment.CurrentDirectory;
            }
            set
            {
                global::System.Environment.CurrentDirectory = value;
            }
        }
        /// <inheritdoc />
        public int ExitCode
        {
            get
            {
                return global::System.Environment.ExitCode;
            }
            set
            {
                global::System.Environment.ExitCode = value;
            }
        }
        /// <inheritdoc />
        public void Exit(int exitCode)
        {
            global::System.Environment.Exit(exitCode);
        }
        /// <inheritdoc />
        public void FailFast(string message)
        {
            global::System.Environment.FailFast(message);
        }
        /// <inheritdoc />
        public void ExpandEnvironmentVariables(string name)
        {
            global::System.Environment.ExpandEnvironmentVariables(name);
        }
        /// <inheritdoc />
        public string[] GetCommandLineArgs()
        {
            return global::System.Environment.GetCommandLineArgs();
        }
        /// <inheritdoc />
        public string GetEnvironmentVariable(string variable)
        {
            return global::System.Environment.GetEnvironmentVariable(variable);
        }
#if !ANDROID
        /// <inheritdoc />
        public string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target)
        {
            return global::System.Environment.GetEnvironmentVariable(variable, target);
        }

        /// <inheritdoc />
        public IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target)
        {
            return global::System.Environment.GetEnvironmentVariables(target);
        }

		/// <inheritdoc />
		public void SetEnvironmentVariable(string variable, string value)
		{
			global::System.Environment.SetEnvironmentVariable(variable, value);
		}
		/// <inheritdoc />
		public void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target)
		{
			global::System.Environment.SetEnvironmentVariable(variable, value, target);
		}
		
		/// <inheritdoc />
		public string SystemDirectory
		{
			get
			{
				return Environment.SystemDirectory;
			}
		}

#endif

		/// <inheritdoc />
		public IDictionary GetEnvironmentVariables()
		{
			return global::System.Environment.GetEnvironmentVariables();
		}
        /// <inheritdoc />
        public string GetFolderPath(global::System.Environment.SpecialFolder folder)
        {
            return global::System.Environment.GetFolderPath(folder);
        }
        /// <inheritdoc />
        public string[] GetLogicalDrives()
        {
            return global::System.Environment.GetLogicalDrives();
        }
        /// <inheritdoc />
        public bool HasShutdownStarted
        {
            get
            {
                return global::System.Environment.HasShutdownStarted;
            }
        }
#if !NET35 && !ANDROID
        /// <inheritdoc />
        public bool Is64BitOperatingSystem
        {
            get
            {
                return global::System.Environment.Is64BitOperatingSystem;
            }
        }
        /// <inheritdoc />
        public bool Is64BitProcess
        {
            get
            {
                return global::System.Environment.Is64BitProcess;
            }
        }

        /// <inheritdoc />
        public int SystemPageSize
        {
            get
            {
                return Environment.SystemPageSize;
            }
        }

#endif
        /// <inheritdoc />
        public string MachineName
        {
            get
            {
                return global::System.Environment.MachineName;
            }
        }
        /// <inheritdoc />
        public string NewLine
        {
            get
            {
                return global::System.Environment.NewLine;
            }
        }
        /// <inheritdoc />
        public OperatingSystem OSVersion
        {
            get
            {
                return global::System.Environment.OSVersion;
            }
        }
        /// <inheritdoc />
        public int ProcessorCount
        {
            get
            {
                return global::System.Environment.ProcessorCount;
            }
        }

        /// <inheritdoc />
        public string StackTrace
        {
            get
            {
                return Environment.StackTrace;
            }
        }

        /// <inheritdoc />
        public int TickCount
        {
            get
            {
                return Environment.TickCount;
            }
        }
        /// <inheritdoc />
        public string UserDomainName
        {
            get
            {
                return Environment.UserDomainName;
            }
        }
        /// <inheritdoc />
        public bool UserInteractive
        {
            get
            {
                return Environment.UserInteractive;
            }
        }
        /// <inheritdoc />
        public string UserName
        {
            get
            {
                return Environment.UserName;
            }
        }
        /// <inheritdoc />
        public Version Version
        {
            get
            {
                return Environment.Version;
            }
        }
        /// <inheritdoc />
        public long WorkingSet
        {
            get
            {
                return Environment.WorkingSet;
            }
        }
    }
}
