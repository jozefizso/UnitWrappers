using System;
using NUnit.Framework;
using UnitWrappers.System.IO;
using UnitWrappers.System.Security.AccessControl;

namespace UnitWrappers.Tests.System.IO
{
    [TestFixture]
    public class DirectoryWrapTests
    {
        const string path = "TempTest";

        private IDirectory _directoryWrap;
        private IDirectoryInfo _directoryInfoWrap;

        [SetUp]
        public void StartTest()
        {
            _directoryWrap = new DirectoryWrap();
            _directoryInfoWrap = _directoryWrap.CreateDirectory(path);
            Assert.IsTrue(_directoryInfoWrap.Exists, "Directory TempTest must be created.");
        }

        [TearDown]
        public void FinishTest()
        {
            if (_directoryWrap.Exists(path))
                _directoryWrap.Delete(path, true);
        }

        [Test]
        public void CreateDirectory_and_Delete_directory_Test()
        {
            _directoryWrap.Delete(path);
            Assert.IsFalse(_directoryWrap.Exists(path), "Directory TempTest must be removed.");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullException_is_thrown_if_directorySecurity_is_null()
        {
            _directoryWrap.CreateDirectory(path, null);
        }

        [Test]
        public void Delete_with_subfolders()
        {
            _directoryWrap.Delete(path, true);
            Assert.IsFalse(_directoryWrap.Exists(path), @"Directory TempTest\Sub1 must be removed.");
        }

        [Test]
        public void GetAccessControl_test()
        {
            IDirectorySecurity directorySecurity = _directoryWrap.GetAccessControl(path);
            Assert.IsNotNull(directorySecurity.DirectorySecurityInstance);
        }

        [Test]
        public void GetParent_test()
        {
            IDirectoryInfo di = _directoryWrap.GetParent(path);
            Assert.AreEqual("NET40", di.Name);
        }
    }
}