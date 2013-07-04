using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UnitWrappers.System;

namespace UnitWrappers.NET40.Samples
{
    [TestFixture]
    public class AppDomainSamples
    {
        [Test]
        public void Conversion()
        {
            var real = AppDomain.CreateDomain("Test");
            TestReal(real);
            TestTest((AppDomainWrap)real);
            AppDomainWrap wrap = real;
            TestReal(wrap);
            TestTest(wrap);
        }

        private void TestReal(AppDomain real)
        {
            Assert.NotNull(real);
        }

        private void TestTest(IAppDomain wrap)
        {
            Assert.NotNull(wrap);
        }
    }
}
