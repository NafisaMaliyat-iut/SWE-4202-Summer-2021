using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff AStaff = new Staff();
            AStaff.SetName("A");
            AStaff.SetCode("200-345-2");
            Console.WriteLine(AStaff.WhoAmI() + "\n\n");


            Officer AOfficer = new Officer();
            AOfficer.SetName("B");
            AOfficer.SetCode("344-342-1");
            AOfficer.SetGrade("A");
            Console.WriteLine(AOfficer.WhoAmI() + "\n\n");

            Teacher ATeacher = new Teacher();   
            ATeacher.SetName("C");
            ATeacher.SetCode("321-234-9");
            ATeacher.SetSubject("Mathematics");
            ATeacher.SetPublication("Dummy");
            Console.WriteLine(ATeacher.WhoAmI() + "\n\n");


            Typist ATypist = new Typist();
            ATypist.SetName("D");
            ATypist.SetCode("500-453-8");
            ATypist.SetSpeed(10);
            Console.WriteLine(ATypist.WhoAmI() + "\n\n");

            Regular ARegularTypist = new Regular();
            ARegularTypist.SetName("E");
            ARegularTypist.SetCode("532-455-8");
            ARegularTypist.SetSpeed(7);
            Console.WriteLine(ARegularTypist.WhoAmI() + "\n\n");

            Casual ACasualTypist = new Casual();
            ACasualTypist.SetName("F");
            ACasualTypist.SetCode("500-453-8");
            ACasualTypist.SetSpeed(10);
            ACasualTypist.SetDailyWages(6540);
            Console.WriteLine(ACasualTypist.WhoAmI() + "\n\n");
            Console.ReadLine();
        }
    }
}
