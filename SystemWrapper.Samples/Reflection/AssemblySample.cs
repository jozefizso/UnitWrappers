using System;
using SystemWrapper.Reflection;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Samples
{
    public class AssemblySample
    {
        private IAssembly _assembly;

        public AssemblySample(IAssembly assembly)
        {
            _assembly = assembly;
        }

        public string GetAssemblyVersion()
        {
            _assembly = _assembly.GetExecutingAssembly();
            return _assembly.GetName().Version.ToString();
        }
    }

    public class AssemblySampleTests
    {
        [Test]
        public void GetAssemblyVersion_test()
        {
            IAssembly assemblyStub = MockRepository.GenerateStub<IAssembly>();
            IAssemblyName assemblyNameStub = MockRepository.GenerateStub<IAssemblyName>();

            assemblyStub.Stub(x => x.GetExecutingAssembly()).Return(assemblyStub);
            assemblyStub.Stub(x => x.GetName()).Return(assemblyNameStub);
            assemblyNameStub.Version = new Version(1, 2, 3, 4);

            Assert.AreEqual("1.2.3.4", new AssemblySample(assemblyStub).GetAssemblyVersion());
        }
    }
}
