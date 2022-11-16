using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaeseRispettoDirittiUmano obj1= new PaeseRispettoDirittiUmano();
            PaeseNonRispettoDirittiUmano obj2 = new PaeseNonRispettoDirittiUmano();
            obj1.ControlloDirittiUmani("Italia");
            obj2.ControlloDirittiUmani("Corea del nord");
            Console.ReadKey();
        }
    }
    public interface ICorteEuropeaDeiDiritti
    {
         void ControlloDirittiUmani(string nomeDelPaese);
   
    }
    public class Paese
    {
       public string Nome { get; set; }
       public int NumeroAbitanti { get; set; }

    }
    public class PaeseRispettoDirittiUmano:Paese, ICorteEuropeaDeiDiritti
    {
        public void ControlloDirittiUmani(string nomeDelPaese)
        {
            Console.WriteLine(nomeDelPaese+" rispetta ai diritti umani.");
        }
    }
    public class PaeseNonRispettoDirittiUmano : Paese, ICorteEuropeaDeiDiritti
    {
        public void ControlloDirittiUmani(string nomeDelPaese)
        {
            Console.WriteLine(nomeDelPaese + " non rispetta ai diritti umani.");
        }
    }
}
