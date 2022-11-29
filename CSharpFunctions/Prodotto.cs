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
        private int iva = 22;

        public Prodotto(int codice, string nome, string descrizione, int prezzo)
        {
            Random rnd = new Random();
            codice = rnd.Next(1,100);
            this.Codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }
     
        //Getters 

        public int GetCodice()
        {
            return this.Codice;
        }

        public int GetIva()
        {
            return this.iva;
        }

        //SETTERS
        public void CambiaNome(string nome)
        {
            if (nome !="")
            {
                this.nome = nome;
            }
            else
            {
                Console.WriteLine("il nome non può essere vuoto"); ;
            }
        }
        public void CambiaDiscrezione(string descrizione)
        {
            if (descrizione != "")
            {
                this.descrizione = descrizione;
            }
            else
            {
                Console.WriteLine("non hai inserito nessuna descrizione");
            }
        }
        public void CambiaPrezzo(int prezzo)
        {
            if (prezzo > 0 ) 
            {
                this.prezzo = prezzo;
            }
            else
            {
                Console.WriteLine("il Prezzo non può essere uguale o minore di 0 ");
            }
        }
        public void CambiaIva(int iva)
        {
            if (iva > 0)
            {
                this.iva = iva;
            }
            else
            {
                Console.WriteLine("il Prezzo non può essere uguale o minore di 0 ");
            }
        }




        public int PrezzoCompresoIva()
        {
            int PIva = prezzo * (iva / 100);
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
