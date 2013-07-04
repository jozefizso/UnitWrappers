using System;
using System.IO;
using System.Runtime.Remoting;
using System.Security.Permissions;
using System.Text;

namespace UnitWrappers.System.IO
{
    /// <summary>
    /// Wrapper for <see cref="T:System.IO.StreamWriter"/> class.
    /// </summary>
    public interface IStreamWriter:ITextWriter
    {


        /// <summary>
        /// Gets or sets a value indicating whether the StreamWriteBase will flush its buffer to the underlying stream after every call to StreamWriteBase.Write. 
        /// </summary>
        bool AutoFlush { get; set; }
        /// <summary>
        /// Gets the underlying stream that interfaces with a backing store.
        /// </summary>
        Stream BaseStream { get; }

        /// <summary>
        /// Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.
        /// </summary>
        /// <param name="requestedType">The Type of the object that the new ObjRef will reference.</param>
        /// <returns>Information required to generate a proxy.</returns>
        [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.Infrastructure)]
        ObjRef CreateObjRef(Type requestedType);

 
    }
}