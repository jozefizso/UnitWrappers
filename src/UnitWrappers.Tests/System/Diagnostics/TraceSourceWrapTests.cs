using System.Diagnostics;
using UnitWrappers.System.Diagnostics;
using NUnit.Framework;


namespace UnitWrappers.NET40.Tests.System.Diagnostics
{
    [TestFixture]
    public class TraceSourceWrapTests
    {

     

        [Test]
        public void Create_setsUnderlyingObject()
        {
            var instance = new TraceSourceWrap("TRACE");
            Assert.IsNotNull((instance as IWrap<TraceSource>).UnderlyingObject);
            Assert.AreEqual(instance.Name, instance.Name);
        }

        [Test]
        public void Create_setsUnderlyingObjectWithRightLevel()
        {
            var instance = new TraceSourceWrap("TRACE", SourceLevels.All);
            Assert.AreEqual(SourceLevels.All,instance.Switch.Level);
        }
    }
}
