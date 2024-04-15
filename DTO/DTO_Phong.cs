using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phong
    {
        private string maPhong;
        private string tenPhong;
        private bool tinhTrang;
        private string maLoaiPhong;
        //get,set
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
    }
}
