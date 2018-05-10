using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public class NhanVienVanPhong : NhanVien
    {
        public int NgayLamViec { get; set; }
        public double NamCongTac { get; set; }

        public NhanVienVanPhong() { }

        public NhanVienVanPhong(string id, string name, string address, double hesoluong, int ngaylamviec, double namcongtac) : base(id, name, address, hesoluong)
        {
            this.NgayLamViec = ngaylamviec;
            this.HeSoLuong = hesoluong;
        }

        public void NhapNVVanPhong()
        {
            base.Nhap();
            do
            {
                Console.Write("Nhap so ngay lam viec: ");
                this.NgayLamViec = Convert.ToInt32(Console.ReadLine());
            } while (this.NgayLamViec <= 0);

            do{
            Console.Write("Nhap so nam cong tac: ");
            this.NamCongTac = Convert.ToInt32(Console.ReadLine());
            } while (this.NgayLamViec <= 0);
        }

        public void XuatNVVanPhong()
        {
            base.Xuat();
            Console.WriteLine("So ngay lam viec: " + this.NgayLamViec);
            Console.WriteLine("So nam cong tac: " + this.NamCongTac);
        }

        public override double Tinhluong()
        {
            return this.HeSoLuong * this.NgayLamViec;
        }

        public override double TinhPhuCap()
        {

            return this.HeSoLuong * 0.5;
        }


    }
}
