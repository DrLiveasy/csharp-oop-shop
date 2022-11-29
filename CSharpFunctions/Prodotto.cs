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
        private int iva = 22/100;

        public Prodotto (int codice, string nome, string descrizione)
        {
            Random rnd = new Random();
            codice = rnd.Next(10, 20);
            this.Codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;

 
        }


    }
}
