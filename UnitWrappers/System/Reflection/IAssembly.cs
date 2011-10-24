using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using UnitWrappers.System.IO;

namespace UnitWrappers.System.Reflection
{
    /// <summary>
    /// Wrapper for <see cref="Assembly"/> class.
    /// </summary>
    public interface IAssembly : IEvidenceFactory, ICustomAttributeProvider, ISerializable
    {

        // Properties

        /// <summary>
        /// Gets <see cref="T:System.Reflection.Assembly"/> object.
        /// </summary>
        Assembly AssemblyInstance { get; }
        /// <summary>
        /// Gets the location of the assembly as specified originally, for example, in an <see cref="AssemblyName"/> object.
        /// </summary>
        string CodeBase { get; }
        /// <summary>
        /// Gets the entry point of this assembly. 
        /// </summary>
        MethodInfo EntryPoint { get; }
        /// <summary>
        /// Gets the URI, including escape characters, that represents the codebase.
        /// </summary>
        string EscapedCodeBase { get; }
        /// <summary>
        /// Gets the display name of the assembly. 
        /// </summary>
        string FullName { get; }
        /// <summary>
        /// Gets a value indicating whether the assembly was loaded from the global assembly cache. 
        /// </summary>
        bool GlobalAssemblyCache { get; }
        /// <summary>
        /// Gets the host context with which the assembly was loaded. 
        /// </summary>
        [ComVisible(false)]
        long HostContext { get; }
        /// <summary>
        /// Gets a string representing the version of the common language runtime (CLR) saved in the file containing the manifest. 
        /// </summary>
        [ComVisible(false)]
        string ImageRuntimeVersion { get; }
        /// <summary>
        /// Gets the path or UNC location of the loaded file that contains the manifest. 
        /// </summary>
        string Location { get; }
        /// <summary>
        /// Gets the module that contains the manifest for the current assembly. 
        /// </summary>
        [ComVisible(false)]
        Module ManifestModule { get; }
        /// <summary>
        /// Gets a <see cref="T:System.Boolean"/> value indicating whether this assembly was loaded into the reflection-only context. 
        /// </summary>
        [ComVisible(false)]
        bool ReflectionOnly { get; }

        // Methods

        /// <summary>
        /// Locates the specified type from this assembly and creates an instance of it using the system activator, using case-sensitive search.
        /// </summary>
        /// <param name="typeName">The Type.FullName of the type to locate.</param>
        /// <returns>An instance of Object representing the type, with culture, arguments, binder, and activation attributes set to nullNothingnullptra null reference (Nothing in Visual Basic), and BindingFlags set to Public or Instance, or nullNothingnullptra null reference (Nothing in Visual Basic) if typeName is not found.</returns>
        object CreateInstance(string typeName);
        /// <summary>
        /// Locates the specified type from this assembly and creates an instance of it using the system activator, with optional case-sensitive search.
        /// </summary>
        /// <param name="typeName">The Type.FullName of the type to locate.</param>
        /// <param name="ignoreCase"> true to ignore the case of the type name; otherwise, false.</param>
        /// <returns>An instance of Object representing the type, with culture, arguments, binder, and activation attributes set to nullNothingnullptra null reference (Nothing in Visual Basic), and BindingFlags set to Public or Instance, or nullNothingnullptra null reference (Nothing in Visual Basic) if typeName is not found.</returns>
        object CreateInstance(string typeName, bool ignoreCase);
        /// <summary>
        /// Locates the specified type from this assembly and creates an instance of it using the system activator, with optional case-sensitive search and having the specified culture, arguments, and binding and activation attributes.
        /// </summary>
        /// <param name="typeName">The Type.FullName of the type to locate.</param>
        /// <param name="ignoreCase"> true to ignore the case of the type name; otherwise, false.</param>
        /// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of bit flags from BindingFlags.</param>
        /// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If binder is nullNothingnullptra null reference (Nothing in Visual Basic), the default binder is used.</param>
        /// <param name="args">An array of type Object containing the arguments to be passed to the constructor. This array of arguments must match in number, order, and type the parameters of the constructor to be invoked. If the default constructor is desired, args must be an empty array or nullNothingnullptra null reference (Nothing in Visual Basic).</param>
        /// <param name="culture">An instance of CultureInfo used to govern the coercion of types. If this is nullNothingnullptra null reference (Nothing in Visual Basic), the CultureInfo for the current thread is used. (This is necessary to convert a String that represents 1000 to a Double value, for example, since 1000 is represented differently by different cultures.)</param>
        /// <param name="activationAttributes">An array of one or more attributes that can participate in activation. Typically, an array that contains a single UrlAttribute object. The UrlAttribute specifies the URL that is required to activate a remote object.</param>
        /// <returns>An instance of Object representing the type and matching the specified criteria, or nullNothingnullptra null reference (Nothing in Visual Basic) if typeName is not found.</returns>
        object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);

        /// <summary>
        /// Determines whether this assembly and the specified object are equal.
        /// </summary>
        /// <param name="o">The object to compare with this instance.</param>
        /// <returns> true if o is equal to this instance; otherwise, false.</returns>
        bool Equals(object o);


        /// <summary>
        /// Gets the public types defined in this assembly that are visible outside the assembly.
        /// </summary>
        /// <returns>An array of Type objects that represent the types defined in this assembly that are visible outside the assembly.</returns>
        Type[] GetExportedTypes();
        /// <summary>
        /// Gets a IFileStream for the specified file in the file table of the manifest of this assembly.
        /// </summary>
        /// <param name="name">The name of the specified file. Do not include the path to the file.</param>
        /// <returns>A IFileStream for the specified file, or nullNothingnullptra null reference (Nothing in Visual Basic) if the file is not found.</returns>
        IFileStream GetFile(string name);
        /// <summary>
        /// Gets the files in the file table of an assembly manifest.
        /// </summary>
        /// <returns>An array of IFileStream objects.</returns>
        IFileStream[] GetFiles();
        /// <summary>
        /// Gets the files in the file table of an assembly manifest, specifying whether to include resource modules.
        /// </summary>
        /// <param name="getResourceModules"> true to include resource modules; otherwise, false.</param>
        /// <returns>An array of IFileStream objects.</returns>
        IFileStream[] GetFiles(bool getResourceModules);
        /// <summary>
        /// Returns the hash code for this instance. 
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        int GetHashCode();
        /// <summary>
        /// Gets an <see cref="T:UnitWrappers.System.Reflection.IAssemblyName"/> for this assembly. 
        /// </summary>
        /// <returns>An <see cref="T:UnitWrappers.System.Reflection.IAssemblyName"/> for this assembly. </returns>
        IAssemblyName GetName();
        /// <summary>
        /// Gets the <see cref="T:UnitWrappers.System.Reflection.IAssemblyName"/> objects for all the assemblies referenced by this assembly. 
        /// </summary>
        /// <returns>An array of type <see cref="T:UnitWrappers.System.Reflection.IAssemblyName"/> containing all the assemblies referenced by this assembly.</returns>
        IAssemblyName[] GetReferencedAssemblies();


        /*
            public Module[] GetLoadedModules();
            public Module[] GetLoadedModules(bool getResourceModules);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName);
            public virtual string[] GetManifestResourceNames();
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual Stream GetManifestResourceStream(string name);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual Stream GetManifestResourceStream(Type type, string name);
            public Module GetModule(string name);
            public Module[] GetModules();
            public Module[] GetModules(bool getResourceModules);
            public virtual AssemblyName GetName(bool copiedName);
            [SecurityPermission(SecurityAction.LinkDemand, Flags=SecurityPermissionFlag.SerializationFormatter)]
            public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
            public Assembly GetSatelliteAssembly(CultureInfo culture);
            public Assembly GetSatelliteAssembly(CultureInfo culture, Version version);
            public virtual Type GetType(string name);
            public virtual Type GetType(string name, bool throwOnError);
            public Type GetType(string name, bool throwOnError, bool ignoreCase);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public virtual Type[] GetTypes();
            public virtual bool IsDefined(Type attributeType, bool inherit);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(byte[] rawAssembly);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(AssemblyName assemblyRef);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(string assemblyString);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(string assemblyString, Evidence assemblySecurity);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
            [MethodImpl(MethodImplOptions.NoInlining), SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlEvidence)]
            public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);
            public static Assembly LoadFile(string path);
            [SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlEvidence)]
            public static Assembly LoadFile(string path, Evidence securityEvidence);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
            public Module LoadModule(string moduleName, byte[] rawModule);
            public Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly ReflectionOnlyLoad(string assemblyString);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly ReflectionOnlyLoad(byte[] rawAssembly);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static Assembly ReflectionOnlyLoadFrom(string assemblyFile);
            Type _Assembly.GetType();
            public override string ToString();
          
         * // Events
            public event ModuleResolveEventHandler ModuleResolve;

       */

    }
}