using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    public class Prodotto
    {
        private int Codice;
        public string nome;
        public string descrizione;
        public int prezzo;
        private int iva = 22/100;

        public Prodotto(int codice, string nome, string descrizione, int prezzo)
        {
            Random rnd = new Random();
            codice = rnd.Next(1,100);
            this.Codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }
     






        public int PrezzoCompresoIva()
        {
            int PIva = prezzo * iva;
            int PrezzoFinale = PIva + prezzo;

            return PrezzoFinale;
        }

        public void StampaDatiProdotto()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("il Codice del prodotto è :" + Codice);
            Console.WriteLine("il Nome :" + nome);
            Console.WriteLine("Descrezione Prodotto :" + descrizione);
            Console.WriteLine("Prezzo senza iva :" + prezzo + " €");
            Console.WriteLine("Prezzo compreso iva :" + PrezzoCompresoIva() + " €");
            Console.WriteLine("-----------------------");
        }


    }
}
