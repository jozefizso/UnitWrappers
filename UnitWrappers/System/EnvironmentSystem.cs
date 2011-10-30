using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitWrappers.System
{
    public class EnvironmentSystem : IEnvironmentSystem
    {
        public string CommandLine
        {
            get
            {
                return Environment.CommandLine;
            }
        }

        public string CurrentDirectory
        {
            get
            {
                return Environment.CurrentDirectory;
            }
            set
            {
                Environment.CurrentDirectory = value;
            }
        }

        public int ExitCode
        {
            get
            {
                return Environment.ExitCode;
            }
            set
            {
                Environment.ExitCode = value;
            }
        }

        public void Exit(int exitCode)
        {
            Environment.Exit(exitCode);
        }

        public void FailFast(string message)
        {
            Environment.FailFast(message);
        }

        public void ExpandEnvironmentVariables(string name)
        {
            Environment.ExpandEnvironmentVariables(name);
        }

        public string[] GetCommandLineArgs()
        {
            return Environment.GetCommandLineArgs();
        }

        public string GetEnvironmentVariable(string variable)
        {
            return Environment.GetEnvironmentVariable(variable);
        }

        public string GetEnvironmentVariable(string variable,EnvironmentVariableTarget target)
        {
            return Environment.GetEnvironmentVariable(variable,target);
        }

        public IDictionary GetEnvironmentVariables()
        {
            return Environment.GetEnvironmentVariables();
        }

        public IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target)
        {
            return Environment.GetEnvironmentVariables(target);
        }

        public string GetFolderPath(Environment.SpecialFolder folder)
        {
            return Environment.GetFolderPath(folder);
        }

        public string[] GetLogicalDrives()
        {
            return Environment.GetLogicalDrives();
        }

        public bool HasShutdownStarted
        {
            get
            {
                return Environment.HasShutdownStarted;
            }
        }
#if !NET35
        public bool Is64BitOperatingSystem
        {
            get
            {
                return Environment.Is64BitOperatingSystem;
            }
        }

        public bool Is64BitProcess
        {
            get
            {
                return Environment.Is64BitProcess;
            }
        }
#endif
        public string MachineName
        {
            get
            {
                return Environment.MachineName;
            }
        }

        public string NewLine
        {
            get
            {
                return Environment.NewLine;
            }
        }

        public OperatingSystem OSVersion
        {
            get
            {
                return Environment.OSVersion;
            }
        }

        public int ProcessorCount
        {
            get
            {
                return Environment.ProcessorCount;
            }
        }


    }
}
