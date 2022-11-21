using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1;
class Program
{
    public static void Main(string[] args)
    {
        int n;
        ManagerStudent mns= new ManagerStudent();
        Student hs = new Student();
        do
        {
            Console.WriteLine("1. Vao chuong trinh\t 2. Thoat chuong trinh");
            Console.WriteLine("\n Vui long chon chuc nang: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    mns.menu();
                break;
                default:
                    Console.WriteLine("\nThoat chuong trinh!!!");
                    Environment.Exit(0);
                    break;
            }
        }while(n != 0);
        
    }
}