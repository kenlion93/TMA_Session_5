using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }
        public double SoGioTangCa { get; set;}

        public NhanVienSanXuat() { }

        public NhanVienSanXuat(string id, string name, string address, double hesoluong, int sosanpham, double sogiotangca) : base(id, name, address, hesoluong)
        {
            this.SoSanPham = sosanpham;
            this.SoGioTangCa = sogiotangca;
        }

        public override double Tinhluong()
        {
            throw new NotImplementedException();
        }

        public override double TinhPhuCap()
        {
            throw new NotImplementedException();
        }
    }
}
