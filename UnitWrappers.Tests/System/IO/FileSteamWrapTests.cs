using NUnit.Framework;
using UnitWrappers.System.IO;

namespace UnitWrappers.NET40.Tests.System.IO
{
    [TestFixture]
    public class FileSteamWrapTests
    {
        [Test]
        public void TypeLoaded()
        {
            var fst = typeof (FileStreamWrap);
        }
    }
}
