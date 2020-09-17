using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestBasicURL()
        {
            URLDownloader downloader = new URLDownloader("http://wsu.edu");
            Assert.IsNotNull(downloader.getURLString());
        }

        [Test]
        public void TestBadURL()
        {
            URLDownloader downloader = new URLDownloader("This isnt a URL");
            Assert.IsNull(downloader.getURLString());
        }

        [Test]
        public void TestMultithreading()
        {
            Sorting sorting = new Sorting();
            Assert.IsNotEmpty(sorting.executeAsNoraml().TotalMilliseconds.ToString());
        }

        [Test]
        public void TestSinglethreading()
        {
            Sorting sorting = new Sorting();
            Assert.IsNotEmpty(sorting.executeOneThread().TotalMilliseconds.ToString());
        }

    }
}
