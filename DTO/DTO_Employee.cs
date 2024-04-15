using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        private int maNV;
        private string tenNV;
        private string gender;
        private DateTime ngaysinh;
        private string diaChi;
        private string sDT;
        private int chucVu;
        //get,set
        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Gender { get => gender; set => gender = value; }
        public int ChucVu { get => chucVu; set => chucVu = value; }
        //constructor
        public DTO_Employee(int maNV, string tenNV,string gender,DateTime ngaysinh,string diaChi,string sDT,int chucVu)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.Gender = gender;
            this.Ngaysinh = ngaysinh;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.ChucVu = chucVu;
        }

    }
}
