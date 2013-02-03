using System.Diagnostics;
using NUnit.Framework;
using UnitWrappers.System.Diagnostics;

namespace UnitWrappers.NET40.Tests.System.Diagnostics
{
    [TestFixture]
    public class ProcessWrapTests
    {


        [Test]
        public void Constructor_Sets_ProcessInstance()
        {
            var wrap = new ProcessWrap();
            Assert.IsNotNull(((IWrap<Process>)wrap).UnderlyingObject);
        }
    }
}