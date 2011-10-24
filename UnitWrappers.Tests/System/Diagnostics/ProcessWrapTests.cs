using NUnit.Framework;
using UnitWrappers.System.Diagnostics;

namespace UnitWrappers.Tests.System.Diagnostics
{
    [TestFixture]
    public class ProcessWrapTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_Sets_ProcessInstance()
        {
            var instance = new ProcessWrap();
            Assert.IsNotNull(instance.ProcessInstance);
        }
    }
}