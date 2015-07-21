﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("UnitWrappers.Core")]
[assembly: AssemblyDescription("Interfaces for CLR/BCL/.NET classes")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("UnitWrappers")]

#if PORTABLE 
[assembly: CLSCompliant(true)]
#endif

#if NET40 || NET35
[assembly: ComVisible(true)]
[assembly: Guid("B631C867-9B89-451B-8B49-6DD48E1E0524")]
#endif



#if NET35 || NET40
[assembly: InternalsVisibleTo(@"WPFWrappers, PublicKey=00240000048000009400000006020000002400005253413100040000010001005d97ca4508432c
2d4000fc39af5c546a0ef3a2268ecfefe2e0babee286d7393fb07110d9bc3186d4df5adb420929
22189ed9d48b263197f34749e0a97bf10dd18bd46a6fc5506c75e029c22f70454e496e2f28fb0f
41b1fb0a5bdf1a5bc93ac48cd0c15419c9a6efa10e3ac41ba150f9d8d903dff04d7771b3b1d6ab
c3cdb6cb")]
#endif