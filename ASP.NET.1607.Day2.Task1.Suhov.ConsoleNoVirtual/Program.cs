using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task1.Suhov.ConsoleNoVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            var abiturientArray = new Abiturient[5];
            for (int i = 0; i < abiturientArray.Length; i++)
            {
                System.Console.WriteLine("Choose the type of abiturient or leave it empty:");
                System.Console.WriteLine("1 - Gold Medal");
                System.Console.WriteLine("2 - Silver Medal");
                System.Console.WriteLine("3 - First grade diplom");
                System.Console.WriteLine("4 - Second grade diplom");
                System.Console.WriteLine("5 - Third grade diplom");
                string readLine = System.Console.ReadLine();
                int type = (String.IsNullOrEmpty(readLine)) ? 0 : Int32.Parse(readLine);
                if (OutputType.GetType(type) != AbiturientType.Default)
                    abiturientArray[i] = new AbiturientDrive().AddAbiturientNoVirtual(
                        surname: "Suhov",
                        marks: new int[] { 100, 100, 100 },
                        type: OutputType.GetType(type));
                else
                    abiturientArray[i] = new Abiturient().AddAbiturientNoVirtual(
                        surname: "Ivanov",
                        marks: new int[] { 50, 50, 50 },
                        type: OutputType.GetType(type));
                System.Console.WriteLine(abiturientArray[i].Output);
            }
            System.Console.ReadKey();
        }
    }
}
