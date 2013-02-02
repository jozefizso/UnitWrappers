using System.Diagnostics;
using System.Windows.Forms;
using NUnit.Framework;
using UnitWrappers.System.Diagnostics;

namespace UnitWrappers.Tests.System.Diagnostics
{
    [TestFixture]
    public class ProcessStartInfoWrapTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_1_Sets_ProcessStartInfoInstance()
        {
            var instance = new ProcessStartInfoWrap();
            Assert.IsNotNull(instance.UnderlyingObject);
        }

        [Test]
        public void Constructor_2_Sets_ProcessStartInfoInstance()
        {
            var instance = new ProcessStartInfoWrap("filename");
            Assert.IsNotNull(instance.UnderlyingObject);
        }

        [Test]
        public void Constructor_3_Sets_ProcessStartInfoInstance()
        {
            var instance = new ProcessStartInfoWrap("filename", "arguments");
            Assert.IsNotNull(instance.UnderlyingObject);
        }

        [Test]
        public void Constructor_4_Sets_ProcessStartInfoInstance()
        {
            var info = new ProcessStartInfo(Application.ExecutablePath);
            var instance = new ProcessStartInfoWrap(info);
            Assert.AreSame(info, instance.UnderlyingObject);
        }
    }
}