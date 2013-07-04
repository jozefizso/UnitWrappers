using NUnit.Framework;
using UnitWrappers.System.IO;

namespace UnitWrappers.Tests.System.IO
{
    [TestFixture]
    public class FileInfoWrapTests
    {
        [Test]
        public void TypeLoaded()
        {
            var fit = typeof(FileInfoWrap);
        }
    }
}