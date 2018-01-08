using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStudentov
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            OtazkyDB databazaOdpovede = new OtazkyDB();


            OtazkyDB databaza = new OtazkyDB();
            databaza.generujOtazku();

            foreach (Otazka o in databaza.otazkovePole)
            {
                Console.WriteLine(o.question);
                Console.ReadLine();
                databazaOdpovede.generujOdpoved();

                S1.Odpoved();
                //foreach (Odpoved od in databazaOdpovede.odpovedovePole)
                //{
                //    Console.WriteLine(od.answer);
                //}

            }






            Console.ReadLine();
        }
    }
}
