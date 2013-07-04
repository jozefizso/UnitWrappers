using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace UnitWrappers.System.IO
{

    public interface IStreamSystem
    {
        /// <summary>
        /// Creates a thread-safe (synchronized) wrapper around the specified <see cref="T:System.IO.Stream"/> object.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A thread-safe <see cref="T:System.IO.Stream"/> object.
        /// 
        /// </returns>
        /// <param name="stream">The <see cref="T:System.IO.Stream"/> object to synchronize.
        ///                 </param><exception cref="T:System.ArgumentNullException"><paramref name="stream"/> is null.
        ///                 </exception>
        [HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
        Stream Synchronized(Stream stream);
    }
}
