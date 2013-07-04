using System;
using NUnit.Framework;
using NSubstitute;
using UnitWrappers.System.Reflection;

namespace UnitWrappers.Samples.System.Reflection
{
    public class AssemblySample
    {
        private IAssembly _assembly;
        private readonly IAssemblySystem _assemblySystem;

        public AssemblySample(IAssembly assembly,IAssemblySystem assemblySystem)
        {
            _assembly = assembly;
            _assemblySystem = assemblySystem;
        }

        public string GetAssemblyVersion()
        {
            _assembly = _assemblySystem.GetExecutingAssembly();
            return _assembly.GetName().Version.ToString();
        }
    }

    public class AssemblySampleTests
    {
        [Test]
        public void GetAssemblyVersion_test()
        {

            IAssembly assemblyStub = Substitute.For<IAssembly>();
            IAssemblySystem assemblySystemStub = Substitute.For<IAssemblySystem>();
            IAssemblyName assemblyNameStub = Substitute.For<IAssemblyName>();

            assemblySystemStub.GetExecutingAssembly().Returns(assemblyStub);
            assemblyStub.GetName().Returns(assemblyNameStub);
            assemblyNameStub.Version = new Version(1, 2, 3, 4);

            Assert.AreEqual("1.2.3.4", new AssemblySample(assemblyStub, assemblySystemStub).GetAssemblyVersion());
        }
    }
}
