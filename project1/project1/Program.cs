using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            String first = "";
            String last = "";
            int age = 0;
            String Email = "";
            String Phone = "";
            String Adress = "";
            int zip = 0;
            WriteLine("What is your first name?");
            first = ReadLine();
            WriteLine("What is your last name?");
            last = ReadLine();
            WriteLine("What is your age?");
            age = int.Parse(ReadLine());
            WriteLine("What is your Email?");
            Email = ReadLine();
            WriteLine("What is your Phone number?");
            Phone = ReadLine();
            WriteLine("What is your adress?");
            Adress = ReadLine();
            WriteLine("What is your zip?");
            zip = int.Parse(ReadLine());
            WriteLine(first + "," + last + "\n" + age + " Years old" + "\n" + Email + "\n" + Phone + "\n" + Adress + "\n" + "Zip is " +zip );
            ReadLine();
        }
    }
}
