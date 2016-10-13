using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EduLinq.Linq.Tests
{
    [TestClass]
    public class WhereTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullSourceThrowsNullArgumentException()
        {
            IEnumerable<int> source = null;
            source.Where(x => x > 5);
        }
    }
}
