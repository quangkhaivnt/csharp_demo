using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private static List<Student> list = new List<Student>();
        static void Main(string[] args)
        {
            GenerateMenu();  
            
        }
        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("=================Student Manager================");
                Console.WriteLine("1.Thêm sinh viên");
                Console.WriteLine("2.Hiển thị sinh viên.");
                Console.WriteLine("3.Tìm sinh viên theo tên.");
                Console.WriteLine("4.Thoát chương trình.");
                Console.WriteLine("Nhập lựa chọn của bạn : ");
                Console.WriteLine("================================================");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Thêm sinh viên.");
                        AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("Hiển thị sinh viên.");
                        DisplayStudent();
                        break;
                    case 3:
                        Console.WriteLine("Tìm tên sinh viên theo tên");
                        SearchByName();
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn sai.Nhập lại.");
                        break;
                }

            }

        }
        
        private static void AddStudent()
        {
            var student = new Student();
            Console.WriteLine("Nhập mã sinh viên : ");
            String rollNumber = Console.ReadLine();
            Console.WriteLine("Nhập tên sinh viên : ");
            String name = Console.ReadLine();
            Console.WriteLine("Nhập email sinh viên : ");
            String email = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại sinh viên : ");
            String phone = Console.ReadLine();
            
            list.Add(student);
        }

        private static void DisplayStudent()
        {
            foreach (var student in list)
            {
                Console.WriteLine("RollNumber : " + student.RollNumber + "Name : " + student.Name + "Email : "
                                  + student.Email + "Phone : " + student.Phone);
            }
        }

        private static void SearchByName()
        {
            Console.WriteLine("Nhập tên sinh viên : ");
            var searchKey = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                Student student = list[i];
                if (searchKey == student.Name)
                {
                    Console.WriteLine("RollNumber : " + student.RollNumber + "Name : " + student.Name + "Email : "
                                      + student.Email + "Phone : " + student.Phone);
                }
            }
        }

    }
}