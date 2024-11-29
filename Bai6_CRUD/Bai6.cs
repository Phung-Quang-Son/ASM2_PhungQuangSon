using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_CRUD
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
        }
        public SinhVien _sv;
        public SinhVienPoly _poly;
        [SetUp]
        public void SetUp()
        {
            _poly = new SinhVienPoly();
        }
        [Test]
        [TestCase("1", "SV001", "Phùng Quang Sơn", "L01", "A")]
        [TestCase("2", "SV002", "Phùng Quang Sơn", "L02", "B")]
        [TestCase("3", "SV003", "Phùng Quang Sơn", "L03", "C")]
        [TestCase("4", "SV004", "Phùng Quang Sơn", "L04", "D")]
        [TestCase("5", "SV005", "Phùng Quang Sơn", "L05", "E")]
        [TestCase("6", "SV006", "Phùng Quang Sơn", "L06", "F")]
        [TestCase("7", "SV007", "Phùng Quang Sơn", "L07", "An toàn thông tin")]
        [TestCase("8", "SV008", "Phùng Quang Sơn", "L08", "Lập trình Web")]
        [TestCase("9", "SV009", "Phùng Quang Sơn", "L09", "Cơ sở dữ liệu")]
        [TestCase("10", "SV010", "Phùng Quang Sơn", "L10", "Mạng máy tính")]
        public void ThemSinhVien(string id, string masv, string hoten, string malop, string tenlop)
        {
            _sv = new SinhVien(id, masv, hoten, malop, tenlop);
            _poly.Them(_sv);
            Assert.That(_poly.DsSinhVien().Contains(_sv), Is.True);
        }
        [Test]
        [TestCase("SV010", true)] 
        [TestCase("SV001", false)]
        [TestCase("SV999", false)] 
        [TestCase("", false)] 
        [TestCase(null, false)]
        public void TimKiem_MaSV(string masv, bool b)
        {
            _sv = new SinhVien("10", "SV010", "Phùng Quang Sơn", "L10", "C");
            _poly.Them(_sv);
            var kq = _poly.TimKiem(masv) != null;
            Assert.That(kq, Is.EqualTo(b));
        }
    }
}
