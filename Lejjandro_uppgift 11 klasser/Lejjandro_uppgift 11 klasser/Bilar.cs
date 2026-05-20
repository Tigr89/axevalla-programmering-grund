using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lejjandro_uppgift_11_klasser
{
    internal class Bilar
    {
        public string bilMärke;
        public string bilModell;
        public int bilHastighet;
        public int bilPris;

        public Bilar(string _märke, string _modell, int _hastighet, int _pris)
        {
            bilMärke = _märke;
            bilModell = _modell;
            bilHastighet = _hastighet;
            bilPris = _pris;
        }

        public int checkSaldo(int saldo)
        {
            if (saldo < bilPris)
            {
                Console.WriteLine("du har inte råd för den här bilen finns det ett annan bilen som du gillade?");
                return 0;
            }
            else
            {
                Console.WriteLine("Du köpte " + bilMärke + " " + bilModell + ". Grattis och tack så mycket");
                return bilPris;
            }
        }

        public void addCar()
        {
            Console.WriteLine("Snälla skriv bil märke");
            bilMärke = Console.ReadLine();
            Console.WriteLine("Snälla skriv bil moddel");
            bilModell = Console.ReadLine();
            Console.WriteLine("Snälla skriv bil hastighet");
            bilHastighet = checkToValue(Console.ReadLine());
            Console.WriteLine("Snälla skriv bil pris");
            bilPris = checkToValue(Console.ReadLine());
        }

        int checkToValue(string valueToCheck)
        {
            int returnValue;

            while (int.TryParse(valueToCheck, out int number) == false)
            {
                Console.WriteLine("ERRO!! Snälla använd ett nummer");
                valueToCheck = Console.ReadLine();
            }

            returnValue = int.Parse(valueToCheck);

            return returnValue;
        }
    }
}
