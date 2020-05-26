using System;
using System.Collections.Generic;

namespace TestEnciclopédia
{
   
    class Program
    {
        static void Main(string[] args)
        {
            
            KingSort kingSort = new KingSort();

                       string[] kings = new String[17];

                       kings[0] = "Louis IX";
                       kings[1] = "Louis VIII";
                       kings[2] = "Philippe II";
                       kings[3] = "Richard I";
                       kings[4] = "Richard II";
                       kings[5] = "Richard III";
                       kings[6] = "João X";
                       kings[7] = "João I";
                       kings[8] = "João L";
                       kings[9] = "João V";
                       kings[10] = "Philippe VI";
                       kings[11] = "Jean II";
                       kings[12] = "Charles V";
                       kings[13] = "Charles VII";
                       kings[14] = "Charles VI";
                       kings[15] = "Louis XI";
                       kings[16] = "Philip II";

           String[] reisOrdenados =   kingSort.getSortedList(kings);
        
           for(int i = 0; i < reisOrdenados.Length; i++)
           {
                 Console.WriteLine(reisOrdenados[i]);
           };

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
              
        }


    }
}
