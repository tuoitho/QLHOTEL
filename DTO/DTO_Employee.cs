using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        private string maNV;
        private string tenNV;
        private DateTime ngaysinh;
        private string diaChi;
        private string sDT;
        private string email;
        private string gender;
        private string chucVu;
        private double luongCoBan;
        //get,set
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime Ngaysinh { get => Ngaysinh; set => ngaysinh = Ngaysinh; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

    }
}
