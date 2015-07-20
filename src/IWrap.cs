using System;
#if !PORTABLE
using System.Runtime.InteropServices;
#endif
namespace UnitWrappers
{

	[AssemblyNeutral]
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	public sealed class AssemblyNeutralAttribute : Attribute
    {
    }

    /// <summary>
    /// Should always be implemented explicitly.
    /// </summary>
    /// <typeparam name="T"></typeparam>
#if !PORTABLE
	//experimenting with type equivalence and related( read around [TypeIdentifierAttribute])
	[Guid("6EDAAE95-2BDA-435D-A80D-D9BB68C085F7")]
#endif
	// experimenting with new runtime type equivalence
	[AssemblyNeutral]
    public interface IWrap<out T>
    {
        T UnderlyingObject { get; }
    }
}