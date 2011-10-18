using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SystemWrapper.Reflection
{
    public interface IAssemblySystem
    {
        /// <summary>
        /// Loads an assembly given its file name or path. 
        /// </summary>
        /// <param name="assemblyFile">The name or path of the file that contains the manifest of the assembly.</param>
        /// <returns>The loaded assembly. </returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        IAssembly LoadFrom(string assemblyFile);

        /// <summary>
        /// Gets the currently loaded assembly in which the specified class is defined. 
        /// </summary>
        /// <param name="type">A Type object representing a class in the assembly that will be returned.</param>
        /// <returns>The assembly in which the specified class is defined.</returns>
        IAssembly GetAssembly(Type type);
        /// <summary>
        /// Returns the IAssembly of the method that invoked the currently executing method. 
        /// </summary>
        /// <returns>The Assembly object of the method that invoked the currently executing method.</returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        IAssembly GetCallingAssembly();

        /// <summary>
        /// Gets the process executable in the default application domain. In other application domains, this is the first executable that was executed by AppDomain.ExecuteAssembly.
        /// </summary>
        /// <returns>The Assembly that is the process executable in the default application domain, or the first executable that was executed by AppDomain.ExecuteAssembly. Can return nullNothingnullptra null reference (Nothing in Visual Basic) when called from unmanaged code. </returns>
        IAssembly GetEntryAssembly();
        /// <summary>
        /// Gets the assembly that contains the code that is currently executing.
        /// </summary>
        /// <returns>A IAssembly representing the assembly that contains the code that is currently executing. </returns>
        [MethodImpl(MethodImplOptions.NoInlining)]
        IAssembly GetExecutingAssembly();

        /// <summary>
        /// Creates the name of a type qualified by the display name of its assembly.
        /// </summary>
        /// <param name="assemblyName">The display name of an assembly.</param>
        /// <param name="typeName">The full name of a type.</param>
        /// <returns>A String that is the full name of the type qualified by the display name of the assembly.</returns>
        [MethodImpl(MethodImplOptions.InternalCall)]
        string CreateQualifiedName(string assemblyName, string typeName);
    }
}
