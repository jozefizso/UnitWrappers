using NUnit.Framework;
using NSubstitute;
using UnitWrappers.System.IO;

namespace UnitWrappers.Samples.System.IO
{
    public class FileInfoSample
    {
        public void CreateAndDeleteFile(IFileInfo fi)
        {
            FileStreamBase fs = fi.Create();
            fs.Close();
            fi.Delete();
        }
    }

    public class FileInfoSampleTest
    {
        [Test]
        public void Check_that_FileInfo_methods_Create_and_Delete_are_called()
        {
            // Add mock repository.
            IFileInfo fileInfoRepository = Substitute.For<IFileInfo>();
            FileStreamBase fileStreamRepository = Substitute.For<FileStreamBase>();

            // Create expectations
            fileInfoRepository.Create().Returns(fileStreamRepository);


            // Test
            new FileInfoSample().CreateAndDeleteFile(fileInfoRepository);

            // Verify expectations.
            fileStreamRepository.Received().Close();
            fileInfoRepository.Received().Delete();
        }

    }
}