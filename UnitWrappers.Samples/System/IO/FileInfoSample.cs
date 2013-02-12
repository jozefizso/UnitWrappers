using NUnit.Framework;
using Rhino.Mocks;
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
            IFileInfo fileInfoRepository = MockRepository.GenerateMock<IFileInfo>();
            FileStreamBase fileStreamRepository = MockRepository.GenerateMock<FileStreamBase>();

            // Create expectations
            fileInfoRepository.Expect(x => x.Create()).Return(fileStreamRepository);
            fileStreamRepository.Expect(x => x.Close());
            fileInfoRepository.Expect(x => x.Delete());

            // Test
            new FileInfoSample().CreateAndDeleteFile(fileInfoRepository);

            // Verify expectations.
            fileInfoRepository.VerifyAllExpectations();
            fileStreamRepository.VerifyAllExpectations();
        }

    }
}