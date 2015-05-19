using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("UnitWrappers")]
[assembly: AssemblyDescription("Unit testable class wrappers for CLR/BCL/.NET")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("UnitWrappers")]

#if PORTABLE 
[assembly: CLSCompliant(true)]
#endif

#if NET40 || NET35
[assembly: ComVisible(true)]
[assembly: Guid("f50b78bf-5353-4df2-a4cc-536e5d05c823")]
#endif


[assembly: AssemblyVersion("0.6.5.0")]
[assembly: AssemblyFileVersion("0.6.5.0")]
#if NET35 || NET40
[assembly: InternalsVisibleTo(@"WPFWrappers, PublicKey=00240000048000009400000006020000002400005253413100040000010001005d97ca4508432c
2d4000fc39af5c546a0ef3a2268ecfefe2e0babee286d7393fb07110d9bc3186d4df5adb420929
22189ed9d48b263197f34749e0a97bf10dd18bd46a6fc5506c75e029c22f70454e496e2f28fb0f
41b1fb0a5bdf1a5bc93ac48cd0c15419c9a6efa10e3ac41ba150f9d8d903dff04d7771b3b1d6ab
c3cdb6cb")]
#endif