using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UnitWrappers.System.IO;

namespace UnitWrappers.Samples.System.IO
{
    [TestFixture]
    public class PathSample
    {
        [Test]
        public void Contract()
        {
            IPath path = new PathWrap();

            //path.Combine(null, null);
        }
    }
}
