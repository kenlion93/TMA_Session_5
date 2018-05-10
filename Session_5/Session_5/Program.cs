using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_5.Entities;

namespace Session_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo5();
            Console.ReadLine();
        }
        // lv1. Ke thua thuoc tinh Demo 1
        // lv2. Ke thua contructor Demo 2
        // lv3. Ke thua phuong thuc_function Demo 2
        // Abstract Demo3, the hien tu class dang ke thua no(Cat, fish, shake)

        static void Demo1()
        {
            Student stu1 = new Student();
            stu1.Name = "name 1";
            stu1.Gender = "male";
            stu1.Id = "st01";
            stu1.Avg = 6.7;
            Console.WriteLine("ID: " + stu1.Id);
            Console.WriteLine("AVG: " + stu1.Avg);
            Console.WriteLine("Name: " + stu1.Name);
            Console.WriteLine("Gender: " + stu1.Gender);


            Employee emp1 = new Employee() { Name = "Name 2", Gender = "Female", Id = "TMA01", Salary = 10.55555, Exp = 5 };
            Console.WriteLine("\nId: " + emp1.Id);
            Console.WriteLine("Name: " + emp1.Name);
            Console.WriteLine("Gender: " + emp1.Gender);
            Console.WriteLine("Salary: " + emp1.Salary);
            Console.WriteLine("Experience: " + emp1.Exp);
        }
        static void Demo2()
        {
            Student stu2 = new Student("st02", "name 2", "female", 7.8);
            stu2.display();
            //Console.WriteLine("ID: " + stu2.Id);
            //Console.WriteLine("AVG: " + stu2.Avg);
            //Console.WriteLine("Name: " + stu2.Name);
            //Console.WriteLine("Gender: " + stu2.Gender);

            Employee emp2 = new Employee("Emp02", "Name employ2", "3d", 10.3232, 6);
            emp2.display_emp();
            ////Console.WriteLine("\nId: " + emp2.Id);
            ////Console.WriteLine("Name: " + emp2.Name);
            ////Console.WriteLine("Gender: " + emp2.Gender);
            ////Console.WriteLine("Salary: " + emp2.Salary);
            ////Console.WriteLine("Experience: " + emp2.Exp);

        }

        static void Demo3()
        {
            Animal animal1 = new Cat();
            animal1.Sound();
            animal1.Move();
            Animal animal2 = new Fish();
            animal2.Sound();
            animal2.Move();
            Animal animal3 = new Shake();
            animal3.Sound();
            animal3.Move();
        }

        static void Demo4()
        {
            Animal[] animals = new Animal[5];
            animals[0] = new Cat();
            animals[1] = new Fish();
            animals[2] = new Shake();
            animals[3] = new Fish();
            animals[4] = new Cat();

            foreach (Animal animal in animals)
            {
                animal.Sound();
                animal.Move();
                Console.WriteLine("-----------------");
            }
        }

        static void Demo5()
        {
            NhanVien[] nhanviens = new NhanVien[5];

            for (int i = 0; i <= nhanviens.Length; i++)
            {
                Console.WriteLine("Chon loai nhan vien");
                Console.WriteLine("1. Chon nhan vien san xuat");
                Console.WriteLine("1. Chon nhan vien van phong");

                int loannv = Convert.ToInt32(Console.ReadLine());

                if (loannv == 1)
                {
                    NhanVienSanXuat nvsx = new NhanVienSanXuat();
                    nvsx.Nhap();
                    nhanviens[i] = nvsx;
                }
                else if(loannv == 2)
                {
                    NhanVienVanPhong nvvp = new NhanVienVanPhong();
                    nvvp.Nhap();
                    nhanviens[i] = nvvp;
                }
            }

            Console.WriteLine("Thuc hien tinh luong va phu cap");
            foreach (NhanVien nhanVien in nhanviens)
            {
                Console.WriteLine("Ho ten: " + nhanVien.Name);
                Console.WriteLine("Tinh luong: " + nhanVien.Tinhluong());
                Console.WriteLine("Tinh phu cap: " + nhanVien.TinhPhuCap());
            }
        }
    }
}
