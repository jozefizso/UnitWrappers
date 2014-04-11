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
    public class AssemblyNameWrap : IAssemblyName,IWrap<AssemblyName>
    {
    	
		AssemblyName _underlyingObject;
    	
    	public static implicit operator AssemblyNameWrap(AssemblyName o)
        {
            return new AssemblyNameWrap(o);
        }

        public static implicit operator AssemblyName(AssemblyNameWrap o)
        {
            return o._underlyingObject;
        }
        
    	
        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyNameWrap"/> class. 
        /// </summary>
        public AssemblyNameWrap()
        {
            _underlyingObject = new AssemblyName();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyNameWrap"/> class. 
        /// </summary>
        /// <param name="assemblyName">AssemblyName object.</param>
        public AssemblyNameWrap(AssemblyName assemblyName)
        {
            _underlyingObject = assemblyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UnitWrappers.System.Reflection.AssemblyNameWrap"/> class. 
        /// </summary>
        /// <param name="assemblyName">The display name of the assembly, as returned by the FullName property.</param>
        public AssemblyNameWrap(string assemblyName)
        {
            _underlyingObject = new AssemblyName(assemblyName);
        }



    	
		 AssemblyName IWrap<AssemblyName>.UnderlyingObject {
			get { return _underlyingObject; }
		}

        public string CodeBase
        {
            get { return _underlyingObject.CodeBase; }
            set { _underlyingObject.CodeBase = value; }
        }

        public CultureInfo CultureInfo
        {
            get { return _underlyingObject.CultureInfo; }
            set { _underlyingObject.CultureInfo = value; }
        }

        public string EscapedCodeBase
        {
            get { return _underlyingObject.EscapedCodeBase; }
        }

        public AssemblyNameFlags Flags
        {
            get { return _underlyingObject.Flags; }
            set { _underlyingObject.Flags = value; }
        }

        public string FullName
        {
            get { return _underlyingObject.FullName; }
        }

        public AssemblyHashAlgorithm HashAlgorithm
        {
            get { return _underlyingObject.HashAlgorithm; }
            set { _underlyingObject.HashAlgorithm = value; }
        }

        public StrongNameKeyPair KeyPair
        {
            get { return _underlyingObject.KeyPair; }
            set { _underlyingObject.KeyPair = value; }
        }

        public string Name
        {
            get { return _underlyingObject.Name; }
            set { _underlyingObject.Name = value; }
        }

        public ProcessorArchitecture ProcessorArchitecture
        {
            get { return _underlyingObject.ProcessorArchitecture; }
            set { _underlyingObject.ProcessorArchitecture = value; }
        }

        public Version Version
        {
            get { return _underlyingObject.Version; }
            set { _underlyingObject.Version = value; }
        }

        public AssemblyVersionCompatibility VersionCompatibility
        {
            get { return _underlyingObject.VersionCompatibility; }
            set { _underlyingObject.VersionCompatibility = value; }
        }

        public object Clone()
        {
            return _underlyingObject.Clone();
        }

        public IAssemblyName GetAssemblyName(string assemblyFile)
        {
            return new AssemblyNameWrap(AssemblyName.GetAssemblyName(assemblyFile));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            _underlyingObject.GetObjectData(info, context);
        }

        public byte[] GetPublicKey()
        {
            return _underlyingObject.GetPublicKey();
        }

        public byte[] GetPublicKeyToken()
        {
            return _underlyingObject.GetPublicKeyToken();
        }

        public void OnDeserialization(object sender)
        {
            _underlyingObject.OnDeserialization(sender);
        }

        public bool ReferenceMatchesDefinition(IAssemblyName reference, IAssemblyName definition)
        {
        	var unRef = ((IWrap<AssemblyName>)reference).UnderlyingObject;
        	var unDef =  ((IWrap<AssemblyName>)definition).UnderlyingObject;
            return AssemblyName.ReferenceMatchesDefinition(unRef,unDef);
        }

        public void SetPublicKey(byte[] publicKey)
        {
            _underlyingObject.SetPublicKey(publicKey);
        }

        public void SetPublicKeyToken(byte[] publicKeyToken)
        {
            _underlyingObject.SetPublicKeyToken(publicKeyToken);
        }

        public override string ToString()
        {
            return _underlyingObject.ToString();
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