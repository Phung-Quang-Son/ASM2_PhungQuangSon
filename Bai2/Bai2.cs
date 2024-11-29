using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
        }
        public Tich tich;
        [SetUp]
        public void Setup()
        {
            tich = new Tich();
        }

        [Test]
        [TestCase("0", "0", 0)]
        [TestCase("1", "1", 1)]
        [TestCase("5", "5", 25)]
        [TestCase("10", "abc", 20)]
        [TestCase("2.5", "1", 25)]
        [TestCase("2", "3", 6)]
        [TestCase("10", "1",10)]
        [TestCase("10", "1", 10)]
        [TestCase("10", "1",10)]
        [TestCase("10", "1", 10)]

        public void PhepNhan(string a, string b, int c)
        {
            
            var result = tich.Nhan(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
        public class Tich
        {
            public int Nhan(string a, string b)
            {
                if(!int.TryParse(a, out int x) || !int.TryParse(b, out int y))
                {
                    throw new ArgumentException("so truyen vao phai la so nguyen");
                }
                return x * y;
            }
        }
    }
}
