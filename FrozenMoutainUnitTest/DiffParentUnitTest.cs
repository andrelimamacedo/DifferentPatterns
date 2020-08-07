using System;
using FrozenMountainAssessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrozenMoutainUnitTest
{
    [TestClass]
    public class DiffParentUnitTest
    {
        [TestMethod]
        public void TestSizeZero()
        {
            FrozenMountainLibrary lib = new FrozenMountainLibrary();
            var res =  lib.getDifferentPatterns("zf3kabxcde224lkzf3mabxc51+crsdtzf3nab=", 0);
            Assert.AreEqual(res.Count, 0);
        }
       
        [TestMethod]
        public void TestPositiveSize()
        {
            FrozenMountainLibrary lib = new FrozenMountainLibrary();
            var res = lib.getDifferentPatterns("zf3kabxcde224lkzf3mabxc51+crsdtzf3nab=", 3);
            Assert.AreEqual(res[0].Key, "zf3");
            Assert.AreEqual(res[0].Value, 3);
        }

        [TestMethod]
        public void TestNegativeSize()
        {
            FrozenMountainLibrary lib = new FrozenMountainLibrary();
            var res = lib.getDifferentPatterns("zf3kabxcde224lkzf3mabxc51+crsdtzf3nab=", -1);
            Assert.AreEqual(res.Count, 0);
        }

        [TestMethod]
        public void TestEmptyString()
        {
            FrozenMountainLibrary lib = new FrozenMountainLibrary();
            var res = lib.getDifferentPatterns("", 2);
            Assert.AreEqual(res.Count, 0);
        }
    }
}
