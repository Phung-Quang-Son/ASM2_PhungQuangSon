using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
        }
        public tinhtong tong;
        [SetUp]
        public void Setup()
        {
            tong = new tinhtong();
        }

        [Test]
        [TestCase("0", "0", 0)]
        [TestCase("1", "1", 2)]
        [TestCase("5", "5", 10)]
        [TestCase("10", "2", 12)]
        [TestCase("-5", "-5", -10)]
        [TestCase("-10", "2", -8)]
        [TestCase("10", "-2", 8)]
        [TestCase("abc", "1", 0)] 
        [TestCase("2.5", "3", 0)]
        [TestCase("2.5", "0", 10)]
        public void TinhTong(string a, string b, int c)
        {
            var result = tong.Tong(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
        public class tinhtong
        {
            public int Tong(string a, string b)
            {
                if (!int.TryParse(a, out int numA) || !int.TryParse(b, out int numB))
                {
                    throw new ArgumentException("Các tham số phải là số nguyên hợp lệ.");
                }

                return numA + numB;
            }
        }

    }
}
