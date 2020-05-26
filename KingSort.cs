using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnciclopédia
{
    class KingSort
    {

        private static readonly string[] romanos = { "I","V","X","L","C" };


        public String[] getSortedList(String[] reis) {

            var arryReis = new kings[reis.Length];
            String[] reisOrdenados = new string[reis.Length];


         for (int i = 0; i < reis.Length; i++)
            {

                string[] rei = reis[i].Split(' ');
                arryReis[i] = new kings();

                arryReis[i].nomeRei =  rei[0];
                arryReis[i].numeroRonamo = rei[1];
                arryReis[i].numeroDecimal = romanoParaDecimal(arryReis[i].numeroRonamo);

            }
            
            var listaNOmeOrdenada = arryReis.OrderBy(a => a.nomeRei).ThenBy(a => a.numeroDecimal);

            List<kings> lista = new List<kings>(listaNOmeOrdenada);

            var indice = 0;
            lista.ForEach(delegate (kings x)
               {
                   reisOrdenados[indice] = x.nomeRei+ "  "+x.numeroRonamo;
                   indice++;
                   
              });

           
       
            return reisOrdenados;

        }

        private int romanoParaDecimal(string numeroRomano)
        {
            int retorno = 0;

            if (numeroRomano.Length == 1)
            {
                retorno = dictionaryRomano(numeroRomano.ToUpper());
            }
            else
            {
                                
                int indiceArray = numeroRomano.Length ;
                int[] decimais = new int[indiceArray];

                for (int i =0; i < numeroRomano.Length; i++)
                {
                    decimais[i] = dictionaryRomano(numeroRomano[i].ToString());
                }

               
                int total = 0;
                for (int i = 0; i < decimais.Length; i++)
                {
                        if (decimais.Length % 2 == 0) {

                                try
                                {
                                    if (decimais[i] >= decimais[i + 1])
                                    {
                                        total += decimais[i] + decimais[i + 1];
                                    }
                                    else if (decimais[i] < decimais[i + 1])
                                    {
                                        total += decimais[i + 1] - decimais[i];
                                    }

                                    i++;
                                }catch(Exception e) { }
                        }
                        else
                        {
                                try
                                {
                                    if (decimais[i] >= decimais[i + 1])
                                    {
                                        total += decimais[i];
                                    }
                                    else if (decimais[i] < decimais[i + 1])
                                    {
                                        total += decimais[i + 1] - decimais[i];
                                    }
                                }catch (Exception e)
                                {
                                    total += decimais[i];
                                 }

                        }
                }

                retorno = total;

            }
            
            return retorno;
        }



        private int dictionaryRomano(string numeroRomano)
        {
            Dictionary<String, int> hash = new Dictionary<string, int>();
            hash.Add("I", 1);
            hash.Add("V", 5);
            hash.Add("X", 10);
            hash.Add("L", 50);
            hash.Add("C", 100);
          

            return hash[numeroRomano];
        }
    }


    class kings
    {
        public string nomeRei { get; set; }
        public string numeroRonamo { get; set; }
        public int numeroDecimal { get; set; }
     
    }
}
