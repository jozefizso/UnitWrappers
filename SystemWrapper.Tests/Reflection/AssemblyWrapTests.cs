using System;
using SystemWrapper.IO;
using SystemWrapper.Reflection;
using MbUnit.Framework;

namespace SystemWrapper.Tests.Reflection
{
    [TestFixture]
    public class AssemblyWrapTests
    {
        [Test]
        public void GetFiles_Test()
        {
            IAssemblySystem assemblySystem = new AssemblySystem();
            IAssembly sampleAssembly = assemblySystem.GetAssembly(new Int32().GetType());
            IFileStream[] fileStreams = sampleAssembly.GetFiles();
            Assert.AreEqual(1, fileStreams.Length);
            Assert.EndsWith(fileStreams[0].Name, "mscorlib.dll");
        }
    }
}