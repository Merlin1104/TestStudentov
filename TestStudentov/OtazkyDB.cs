using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStudentov
{
    class OtazkyDB
    {
        string[] otazky = new string[] { "Kolko je 1 + 1", "Kolko je 2 na druhu", "Kolko metrov je jeden kilometer ?" };
        string[] odpovede = new string[] { "2", "4", "1000" };
        public Otazka[] otazkovePole = new Otazka[5];
        public Odpoved[] odpovedovePole = new Odpoved[1];

        Random randomGen = new Random();

        public void generujOtazku()
        {
            for (int i = 0; i < otazkovePole.Length; i++)
            {
                Otazka otazka1;
                otazka1.question = otazky[randomGen.Next(otazky.Length)];

                otazkovePole[i] = otazka1;

            }
        }

        public void generujOdpoved()
        {
            for (int i = 0; i < odpovedovePole.Length; i++)
            {
                Odpoved Odpoved1;
                Odpoved1.answer = odpovede[randomGen.Next(odpovede.Length)];

                odpovedovePole[i] = Odpoved1;
            }
        }
    }
}
