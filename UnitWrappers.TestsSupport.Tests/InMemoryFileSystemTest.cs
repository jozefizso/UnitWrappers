using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UnitWrappers.System.IO;
using UnitWrappers.TestsSupport.System.IO;

namespace UnitWrappers.TestsSupport.Tests
{
    [TestFixture]
    public class InMemoryFileSystemTest
    {
        [Test]
        public void CreateDirectory_itAndParentExistsOnly()
        {
            var fs = new InMemoryFileSystem();
            IDirectory d = fs;

            d.CreateDirectory("C:/d/e");

            Assert.True(d.Exists("C:/d/e"));
            Assert.True(d.Exists("C:/d"));
            Assert.False(d.Exists("C:/d/e/f"));
        }

        [Test]
        public void RealFileSystem()
        {
            var fit = typeof (FileInfoWrap);
            var fst = typeof(FileStreamWrap);
        }
    }
}
