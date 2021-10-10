using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class Avtomat
    {
        public void BirbirAtir(int varolan, int daxilolunan, int atilacaq)
        {
            int count = varolan + daxilolunan;
            if (atilacaq>count)
            {
                Console.WriteLine("Atmaq istediyiniz gulle maqazindeki gulleden coxdur");

            }else if (varolan+daxilolunan<30 || varolan+daxilolunan==30)
            {
               
                Console.WriteLine($"Avtomatda var idi:{varolan} gulle. Daxil etdiyimiz gulle:{daxilolunan} Atilan gulle:{atilacaq} Avtomatda qaldi:{count-atilacaq}");

            }

        }

        public void BirdefelikAtir(int varolan,int daxilolunan)
        {
            int count = varolan + daxilolunan;
            if (count>30)
            {
                Console.WriteLine("Gulle sayi 30-u kecmemelidir");
            }
            if (count<=30)
            { 
                Console.WriteLine($"Avtomatda var idi:{varolan} gulle.Daxil etdiniz {daxilolunan} gulle.Atildi {count}");
            }

        }





    }

}
