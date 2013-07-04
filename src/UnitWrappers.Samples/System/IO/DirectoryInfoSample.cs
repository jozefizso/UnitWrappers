using NUnit.Framework;
using NSubstitute;
using UnitWrappers.System.IO;

namespace UnitWrappers.Samples.System.IO
{
    public class DirectoryInfoSample
    {
        public bool TryToCreateDirectory(IDirectoryInfo directory)
        {
            if (directory.Exists)
                return false;

            directory.Create();
            return true;
        }
    }

    public class DirectoryInfoSampleTests
    {
        [Test]
        public void When_try_to_create_directory_that_already_exists_return_false()
        {
            var directoryInfoWrap = Substitute.For<IDirectoryInfo>();
            directoryInfoWrap.Exists.Returns(true);
//            directoryInfoWrap.Expect(x => x.Create()).Repeat.Never();
            Assert.AreEqual(false, new DirectoryInfoSample().TryToCreateDirectory(directoryInfoWrap));

            directoryInfoWrap.DidNotReceive().Create();
//            directoryInfoWrap.VerifyAllExpectations();
        }

        [Test]
        public void When_try_to_create_directory_that_does_not_exist_return_true()
        {
            var directoryInfoWrap = Substitute.For<IDirectoryInfo>();
            directoryInfoWrap.Exists.Returns(false);
//            directoryInfoWrap.Expect(x => x.Create());
            Assert.AreEqual(true, new DirectoryInfoSample().TryToCreateDirectory(directoryInfoWrap));

            directoryInfoWrap.Received().Create();
//            directoryInfoWrap.VerifyAllExpectations();
        }
    }
}