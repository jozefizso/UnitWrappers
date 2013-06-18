using System;
using System.Configuration.Assemblies;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace UnitWrappers.System.Reflection
{
    /// <summary>
    /// Wrapper for <see cref="AssemblyName"/> class.
    /// </summary>
    [Serializable]
    [ComVisible(true)]
    public class AssemblyNameWrap : IAssemblyName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyNameWrap"/> class. 
        /// </summary>
        public AssemblyNameWrap()
        {
            AssemblyNameInstance = new AssemblyName();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyNameWrap"/> class. 
        /// </summary>
        /// <param name="assemblyName">AssemblyName object.</param>
        public AssemblyNameWrap(AssemblyName assemblyName)
        {
            AssemblyNameInstance = assemblyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyNameWrap"/> class. 
        /// </summary>
        /// <param name="assemblyName">The display name of the assembly, as returned by the FullName property.</param>
        public AssemblyNameWrap(string assemblyName)
        {
            AssemblyNameInstance = new AssemblyName(assemblyName);
        }



        public AssemblyName AssemblyNameInstance { get; private set; }

        public string CodeBase
        {
            get { return AssemblyNameInstance.CodeBase; }
            set { AssemblyNameInstance.CodeBase = value; }
        }

        public CultureInfo CultureInfo
        {
            get { return AssemblyNameInstance.CultureInfo; }
            set { AssemblyNameInstance.CultureInfo = value; }
        }

        public string EscapedCodeBase
        {
            get { return AssemblyNameInstance.EscapedCodeBase; }
        }

        public AssemblyNameFlags Flags
        {
            get { return AssemblyNameInstance.Flags; }
            set { AssemblyNameInstance.Flags = value; }
        }

        public string FullName
        {
            get { return AssemblyNameInstance.FullName; }
        }

        public AssemblyHashAlgorithm HashAlgorithm
        {
            get { return AssemblyNameInstance.HashAlgorithm; }
            set { AssemblyNameInstance.HashAlgorithm = value; }
        }

        public StrongNameKeyPair KeyPair
        {
            get { return AssemblyNameInstance.KeyPair; }
            set { AssemblyNameInstance.KeyPair = value; }
        }

        public string Name
        {
            get { return AssemblyNameInstance.Name; }
            set { AssemblyNameInstance.Name = value; }
        }

        public ProcessorArchitecture ProcessorArchitecture
        {
            get { return AssemblyNameInstance.ProcessorArchitecture; }
            set { AssemblyNameInstance.ProcessorArchitecture = value; }
        }

        public Version Version
        {
            get { return AssemblyNameInstance.Version; }
            set { AssemblyNameInstance.Version = value; }
        }

        public AssemblyVersionCompatibility VersionCompatibility
        {
            get { return AssemblyNameInstance.VersionCompatibility; }
            set { AssemblyNameInstance.VersionCompatibility = value; }
        }

        public object Clone()
        {
            return AssemblyNameInstance.Clone();
        }

        public IAssemblyName GetAssemblyName(string assemblyFile)
        {
            return new AssemblyNameWrap(AssemblyName.GetAssemblyName(assemblyFile));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            AssemblyNameInstance.GetObjectData(info, context);
        }

        public byte[] GetPublicKey()
        {
            return AssemblyNameInstance.GetPublicKey();
        }

        public byte[] GetPublicKeyToken()
        {
            return AssemblyNameInstance.GetPublicKeyToken();
        }

        public void OnDeserialization(object sender)
        {
            AssemblyNameInstance.OnDeserialization(sender);
        }

        public bool ReferenceMatchesDefinition(IAssemblyName reference, IAssemblyName definition)
        {
            return AssemblyName.ReferenceMatchesDefinition(reference.AssemblyNameInstance, definition.AssemblyNameInstance);
        }

        public void SetPublicKey(byte[] publicKey)
        {
            AssemblyNameInstance.SetPublicKey(publicKey);
        }

        public void SetPublicKeyToken(byte[] publicKeyToken)
        {
            AssemblyNameInstance.SetPublicKeyToken(publicKeyToken);
        }

        public override string ToString()
        {
            return AssemblyNameInstance.ToString();
        }

        internal static IAssemblyName[] ConvertFileInfoArrayIntoIFileInfoWrapArray(AssemblyName[] assemblyNames)
        {
            AssemblyNameWrap[] wrapAssemblyNames = new AssemblyNameWrap[assemblyNames.Length];
            for (int i = 0; i < assemblyNames.Length; i++)
                wrapAssemblyNames[i] = new AssemblyNameWrap(assemblyNames[i]);
            return wrapAssemblyNames;
        }

    }
}