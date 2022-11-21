using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ManagerStudent : Student
    {
        public List<Student> ListStudents = new List<Student>();

        public int checkID(string? ID)
        {
            for(int i = 0; i < ListStudents.Count; i++)
            {
                if (ListStudents[i].StudentId == ID)
                {
                    return i;
                }
            }
            return -1;
        }
        public void add()
        {
            Console.WriteLine("So luong student muon them: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<num; i++) 
            { 
                Console.WriteLine("\nStudent {0}", i+1);
                Student hs = new Student();
                hs.Input();
                ListStudents.Add(hs);
            }

        }
        public new void Edit() 
        {
            Console.WriteLine("Nhap id student muon update: ");
            String? ID = Console.ReadLine();
            int check = 0;
            if((check = checkID(ID)) >= 0)
            {
                Student hs = new()
                {
                    StudentId = ID
                };
                hs.Edit();
                ListStudents[check] = hs;
                Console.WriteLine("\nUpdate thanh cong");
            }
            else
            {
                Console.WriteLine("\nStudentID khong ton tai");
            }
        }
        public void Remove()
        {
            Console.WriteLine("Nhap id student muon Delete: ");
            String? ID = Console.ReadLine();
            int check = 0;
            if ((check = checkID(ID)) >= 0)
            {
                ListStudents.RemoveAt(check);
                Console.WriteLine("\nDelete thanh cong");
            }
            else
            {
                Console.WriteLine("\nStudentID khong ton tai");
            }
        }
        public void DisplayAll()
        {
            if (ListStudents.Any())
            {
                Console.WriteLine("________________LIST STUDENT________________\n");
                foreach(Student hs in ListStudents)
                {
                    hs.Output();
                }
            }
            else
            {
                Console.WriteLine("\nDanh sach trong!!!");
            }
        }
        public void FindName()
        {
            Console.WriteLine("Nhap ten can tim: ");
            string? HSN = Console.ReadLine();
            List<Student> FindN = new();
            foreach (Student hs in ListStudents)
            {
                if (hs.StudentName.Contains(HSN))
                {
                    FindN.Add(hs);
                }
            }
            foreach (Student hs in FindN)
            {
                Console.WriteLine("\nStudent Name: " + hs.StudentName + "\tStudent Id: " + hs.StudentId + "\tStudent Address: " + hs.StudentAddress);
            }
            if (FindN==null)
            {
                Console.WriteLine("\nKhong tim thay");
                Search();
            }
        }
        public void FindAdd()
        {
            Console.WriteLine("Nhap dia chi can tim: ");
            string? HSN = Console.ReadLine();
            List<Student> FindN = new List<Student>();
            foreach (Student hs in ListStudents)
            {
                if (hs.StudentAddress.Contains(HSN))
                {
                    FindN.Add(hs);
                }
            }
            foreach (Student hs in FindN)
            {
                Console.WriteLine("\nStudent Address: " + hs.StudentAddress + "\tStudent Name: " + hs.StudentName + "\tStudent ID: " + hs.StudentId);
            }
            if (FindN == null)
            {
                Console.WriteLine("Khong tim thay");
                Search();
            }
        }
        public void FindID()
        {
            Console.WriteLine("Nhap id can tim: \n");
            String? HSID = Console.ReadLine();
            Student FindHS = null;
            foreach (Student hs in ListStudents)
            {
                if (hs.StudentId == HSID)
                {
                    FindHS = hs;
                    FindHS.Output();
                }
            }
        }
        public void Search()
        {
            int choice;
            Console.WriteLine("Chon option ban muon tim kiem: ");
            Console.WriteLine("\n1. Tim theo ID\t2. Tim theo ten\t3. Tim theo dia chi\t4. Back");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FindID();
                    break;
                case 2:
                    FindName();
                    break;
                case 3:
                    FindAdd();
                    break;
                default:
                    menu();
                    break;
            }
        }
        public void menu()
        {
            int choice;
            do
            {
                Console.WriteLine("_______________Student Manager_____________");
                Console.WriteLine("Nhap chuc nang ban muon dung: \n" + "1. Create Student\t2. Update Student\t3. Delete Student\t4.list student\t5. Search\t0. Back");
                Console.Write("\nNhap chuc nang: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        Edit();
                        break;
                    case 3:
                        Remove();
                        break;
                    case 4:
                        DisplayAll();
                        break;
                    case 5:
                        Search();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (choice != 0);
        }
    }
}
