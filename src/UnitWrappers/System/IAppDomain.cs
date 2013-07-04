using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;
using System.Security.Policy;
using UnitWrappers.System.Reflection;

namespace UnitWrappers.System
{
    /// <summary>
    /// Wrapper for <see cref="AppDomain"/> class.
    /// </summary>
    public interface IAppDomain
    {


        /// <summary>
        /// Gets the value stored in the current application domain for the specified name.
        /// </summary>
        /// <param name="name">The name of a predefined application domain property, or the name of an application domain property you have defined. </param>
        /// <returns>The value of the name property. </returns>
        object GetData(string name);
        /// <summary>
        /// Loads an Assembly given its IAssemblyName. 
        /// </summary>
        /// <param name="assemblyRef">An object that describes the assembly to load.</param>
        /// <returns>The loaded assembly.</returns>
        IAssembly Load(IAssemblyName assemblyRef);
        /// <summary>
        /// Assigns the specified value to the specified application domain property.
        /// </summary>
        /// <param name="name">The name of a user-defined application domain property to create or change.</param>
        /// <param name="data">The value of the property.</param>
        void SetData(string name, object data);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <param name="typeName"></param>
        /// <returns></returns>
        object CreateInstanceAndUnwrap(string assemblyName, string typeName);

        object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes);
        object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
        object CreateInstanceFromAndUnwrap(string assemblyName, string typeName);
        object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes);
        object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);

        void DoCallBack(CrossAppDomainDelegate callBackDelegate);


   
        /// <summary>
        /// Occurs when the resolution of an assembly fails.
        /// </summary>
        event ResolveEventHandler AssemblyResolve;

        event AssemblyLoadEventHandler AssemblyLoad;
        event EventHandler DomainUnload;
        event EventHandler ProcessExit;
        event ResolveEventHandler ReflectionOnlyAssemblyResolve;
        event ResolveEventHandler ResourceResolve;
        event ResolveEventHandler TypeResolve;
        event UnhandledExceptionEventHandler UnhandledException;

        AppDomainManager DomainManager { [SecurityPermission(SecurityAction.LinkDemand, ControlDomainPolicy = true)] get; }
        Evidence Evidence { [SecurityPermission(SecurityAction.Demand, ControlEvidence = true)] get; }
        AppDomainSetup SetupInformation { get; }
        string BaseDirectory { get; }
        string DynamicDirectory { get; }
        string FriendlyName { get; }
        /*

            [ComVisible(false)]
            public string ApplyPolicy(string assemblyName);
            public ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName);
            public ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
            public ObjectHandle CreateInstance(string assemblyName, string typeName);
            public ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
            public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
    
            public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
            public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
            public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes);
    
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes);
             
            [MethodImpl(MethodImplOptions.InternalCall), ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            public extern bool IsFinalizingForUnload();
            [MethodImpl(MethodImplOptions.NoInlining)]
            public Assembly Load(string assemblyString);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public Assembly Load(byte[] rawAssembly);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public Assembly Load(string assemblyString, Evidence assemblySecurity);
            [MethodImpl(MethodImplOptions.NoInlining)]
            public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
            [MethodImpl(MethodImplOptions.NoInlining), SecurityPermission(SecurityAction.Demand, ControlEvidence=true)]
            public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence);
            public Assembly[] ReflectionOnlyGetAssemblies();
            [SecurityPermission(SecurityAction.LinkDemand, ControlDomainPolicy=true)]
            public void SetAppDomainPolicy(PolicyLevel domainPolicy);
            [SecurityPermission(SecurityAction.LinkDemand, ControlAppDomain=true)]
            public void SetData(string name, object data, IPermission permission);
            [SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlPrincipal)]
            public void SetPrincipalPolicy(PrincipalPolicy policy);
            [SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.ControlPrincipal)]
            public void SetThreadPrincipal(IPrincipal principal);


            public ActivationContext ActivationContext { [SecurityPermission(SecurityAction.LinkDemand, ControlDomainPolicy=true)] get; }
            public ApplicationIdentity ApplicationIdentity { [SecurityPermission(SecurityAction.LinkDemand, ControlDomainPolicy=true)] get; }
            public ApplicationTrust ApplicationTrust { [SecurityPermission(SecurityAction.LinkDemand, ControlDomainPolicy=true)] get; }
         */
          object InitializeLifetimeService();
         bool IsDefaultAppDomain();
         int ExecuteAssembly(string assemblyFile);
         int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity);
         int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args);
         int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm);
         int ExecuteAssemblyByName(string assemblyName);
         int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity);
         int ExecuteAssemblyByName(IAssemblyName assemblyName, Evidence assemblySecurity, params string[] args);
         int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity, params string[] args);

         IAssembly[] GetAssemblies();

        int Id { [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] get; }
        string RelativeSearchPath { get; }

        bool ShadowCopyFiles { get; }


    }
}