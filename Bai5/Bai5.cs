using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Bai5
    {
        static void Main(string[] args)
        {
        }
        public XuatPhanTu XPT;
        [SetUp]
        public void SetUp()
        {
            XPT = new XuatPhanTu();
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 1)] 
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 5)]
        [TestCase(new int[] { 10, 20, 30 }, 2, 30)] 
        [TestCase(new int[] { 7, 8, 9 }, 1, 8)] 
        [TestCase(new int[] { 42 }, 0, 42)] 
        public void Xuat(int[] a, int b, int c)
        {
            var kq = XPT.XPTu(a, b);
            Assert.That(kq, Is.EqualTo(c));
        }
        public class XuatPhanTu
        {
            public object XPTu(int[] a, int b)
            {
                if (a == null || a.Length == 0)
                {
                    throw new Exception("Mảng rỗng");
                }
                return a[b];
            }

        }
    }
}
