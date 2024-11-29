using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
        }
        public tinhhieu hieu;
        [SetUp]
        public void Setup()
        {
            hieu = new tinhhieu();
        }

        [Test]
        [TestCase("0", "0", 0)]
        [TestCase("1", "1", 0)]
        [TestCase("5", "5", 0)]
        [TestCase("10", "2", 8)]
        [TestCase("-5", "-5", 0)]
        [TestCase("-10", "2", -12)]
        [TestCase("10", "-2", 12)]
        [TestCase("1.2", "-2", 12)]
        [TestCase("10", "abc", 12)]
        public void TinhHieu(string a, string b, int c)
        {
            var result = hieu.Hieu(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
        public class tinhhieu
        {
            public int Hieu(string a, string b)
            {
                if(!int.TryParse(a, out int x)||!int.TryParse(b, out int y))
                {
                    throw new ArgumentException("so truyen bvao phai la so nguyen");
                }
                return x - y;
            }
        }
    }
}
