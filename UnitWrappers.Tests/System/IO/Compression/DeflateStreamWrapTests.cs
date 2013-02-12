using System.IO;
using System.IO.Compression;
using System.Reflection;
using NUnit.Framework;
using Rhino.Mocks;
using UnitWrappers.System.IO;
using UnitWrappers.System.IO.Compression;

namespace UnitWrappers.Tests.System.IO.Compression
{
    [TestFixture]
    public class DeflateStreamWrapTests
    {
        private FileStream _fileStream;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            var assembly = Assembly.GetAssembly(typeof(DeflateStreamWrap));
            var testFilePath = assembly.CodeBase.Substring(8);  //remove the "file://" from the front
            testFilePath = Path.GetDirectoryName(testFilePath) + "\\TestData\\DeflateStreamWrapTestData.txt";

            _fileStream = new FileStream(testFilePath, FileMode.Open);
        }

        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Constructor_Sets_DeflateStreamInstance()
        //{
        //    var mockStream = MockRepository.GenerateMock<IStream>();
        //    mockStream.Stub(mo => mo.StreamInstance).Return(_fileStream);

        //    var instance = new DeflateStreamWrap(mockStream, CompressionMode.Compress);
        //    Assert.IsNotNull(instance.DeflateStreamInstance);
        //}

        //[Test]
        //public void Initialize_Sets_DeflateStreamInstance()
        //{
        //    var mockStream = MockRepository.GenerateMock<IStream>();
        //    mockStream.Stub(mo => mo.StreamInstance).Return(_fileStream);
        //    var instance = new DeflateStreamWrap(mockStream, CompressionMode.Compress);
        //    Assert.IsNotNull(instance.DeflateStreamInstance);
        //}


    }
}