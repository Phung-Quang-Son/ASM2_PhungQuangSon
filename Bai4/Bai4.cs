using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Bai4
    {
        static void Main(string[] args)
        {
        }
        private TBCong tbc;
        [SetUp]
        public void Setup()
        {
            tbc = new TBCong();
        }

        [Test]
        [TestCase("0", "0", "0", 0)]
        [TestCase("1", "1", "1", 1)]
        [TestCase("5", "5", "5", 5)]
        [TestCase("10", "1", "4", 5)]
        [TestCase("ab", "0", "1", -5)]
        [TestCase("-10", "2", "4", -1)]
        [TestCase("10", "-2", "4", 4)]
        [TestCase("abc", "-2", "4", 4)]
        [TestCase("10.4", "-2", "4", 4)]
        [TestCase("10", "-2.5", "4", 4)]
        public void TrungBinhCong(string a, string b, string c, int d)
        {
            var result = tbc.TBC(a, b, c);
            Assert.That(result, Is.EqualTo(d));
        }
        public class TBCong
        {
            public int TBC(string a, string b, string c)
            {
                if(!int.TryParse(a, out int x)||!int.TryParse(b, out int y)||!int.TryParse(c, out int z))
                {
                    throw new ArgumentException("tham so phai la so nguyen");
                }
                return (x + y + z) / 3;
            }
        }
    }
}
