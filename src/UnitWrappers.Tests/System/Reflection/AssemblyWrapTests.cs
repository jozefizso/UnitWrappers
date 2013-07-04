using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using UnitWrappers.System.IO;
using UnitWrappers.System.Reflection;

namespace UnitWrappers.Tests.System.Reflection
{
    [TestFixture]
    public class AssemblyWrapTests
    {
        [Test]
        public void GetFiles_Test()
        {
            IAssemblySystem assemblySystem = new AssemblySystem();
            IAssembly sampleAssembly = assemblySystem.GetAssembly(new Int32().GetType());
            FileStreamBase[] fileStreams = sampleAssembly.GetFiles();
            Assert.AreEqual(1, fileStreams.Length);
            Assert.That(fileStreams[0].Name,new EndsWithConstraint("mscorlib.dll"));
        }
    }
}