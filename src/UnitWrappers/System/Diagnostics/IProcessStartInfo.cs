using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security;
using System.Text;

namespace UnitWrappers.System.Diagnostics
{
    /// <summary>
    /// Description of IProcessStartInfo
    /// </summary>
    public interface IProcessStartInfo
    {

        // Properties

        /// <summary>
        /// Gets or sets the set of command-line arguments to use when starting the application.
        /// </summary>
        string Arguments { get; set; }
        /// <summary>
        /// Gets or sets the application or document to start.
        /// </summary>
        string FileName { get; set; }
        /// <summary>
        /// Gets <see cref="T:System.Diagnostics.ProcessStartInfo"/> object.
        /// </summary>
        ProcessStartInfo UnderlyingObject { get; }
        /// <summary>
        /// Gets or sets a value indicating whether to use the operating system shell to start the process.
        /// </summary>
        bool UseShellExecute { get; set; }


        bool CreateNoWindow { get; set; }

        string Domain { get; set; }
        StringDictionary EnvironmentVariables { get; }
        bool ErrorDialog { get; set; }
        IntPtr ErrorDialogParentHandle { get; set; }
        bool LoadUserProfile { get; set; }
        SecureString Password { get; set; }
        bool RedirectStandardError { get; set; }
        bool RedirectStandardInput { get; set; }
        bool RedirectStandardOutput { get; set; }
        Encoding StandardErrorEncoding { get; set; }
        Encoding StandardOutputEncoding { get; set; }
        string UserName { get; set; }
        /// <summary>
        /// Gets or sets the verb to use when opening the application or document specified by the FileName property.
        /// </summary>
        string Verb { get; set; }
        string[] Verbs { get; }
        ProcessWindowStyle WindowStyle { get; set; }
        string WorkingDirectory { get; set; }


    }
}