using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Student
    {
        public string? StudentId { get; set; } = null!;
        public string? StudentName { get; set; } = null!;
        public string? StudentAddress { get; set; } = null!;
        public Student(string studentId, string studentName, string studentAddress)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentAddress = studentAddress;
        }

        public Student()
        {
        }

        public void Input()
        {
            int test;
            do
            {
                Console.Write("Nhap id: ");
                StudentId = Console.ReadLine();
                String? Str = StudentId.Substring(2, 3);
                string pattern = @"[A-Z]{2}";
                Match m1 = Regex.Match(StudentId, pattern);
                if (string.IsNullOrEmpty(StudentId) || m1.Success == false)
                {
                    Console.Write("ID sai dinh dang!");
                    Console.Write("Nhap lai!\n");
                    test = -1;
                }
                else test = 0;
            } while (test != 0);
            Console.Write("\nNhap studentname: ");
            StudentName = Console.ReadLine();
            while (string.IsNullOrEmpty(StudentName))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                Console.Write("\nNhap studentname: ");
                StudentName = Console.ReadLine();
            }
            Console.Write("\nNhap studentaddress: ");
            StudentAddress = Console.ReadLine();
            while (string.IsNullOrEmpty(StudentAddress))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                Console.Write("\nNhap studentaddress: ");
                StudentAddress = Console.ReadLine();
            }
        }
        public void Edit() 
        {
            Input();
        }
        public void Output()
        {
            Console.WriteLine("Student ID: "+ StudentId + "\tStudent Name: " + StudentName + "\tStudent Address: "+StudentAddress);
        }
    }
}
