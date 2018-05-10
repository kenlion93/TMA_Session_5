using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public abstract class NhanVien
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double HeSoLuong { get; set; }

        public NhanVien(){}

        public NhanVien(string id, string name, string address, double hesoluong){
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.HeSoLuong = hesoluong;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ID nhan vien: ");
            this.ID = Console.ReadLine();
            Console.WriteLine("Nhap ten nhan vien: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi nhan vien: ");
            this.Address = Console.ReadLine();
            do
            {
                Console.WriteLine("Nhap he so luong nhan vien: ");
                this.HeSoLuong = Convert.ToDouble(Console.ReadLine());
            } while (this.HeSoLuong <= 0);  
        }

        public void Xuat()
        {
            Console.WriteLine("\nID: " + this.ID);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Address: " + this.Address);
            Console.WriteLine("He so luong: " + this.HeSoLuong);
        }

        public abstract double Tinhluong();
        public abstract double TinhPhuCap();

    }

}
