using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        private float iva = 0.22f;

        public Prodotto( string nome, string descrizione, int prezzo)
        {
            Random rnd = new Random();
            this.Codice = rnd.Next(1, 100);
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }


     
        //Getters 

        public int GetCodice()
        {
            return this.Codice;
        }

        public double GetIva()
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




        public double CalcoloIva()
        {
            double PIva = prezzo * iva;

            double PrezzoFinale = prezzo + PIva;

            PrezzoFinale = (double)System.Math.Round(PrezzoFinale, 2);

            return PrezzoFinale;
        }
        


        public int PrezzoBase()
        {
            return prezzo;
        }


        public string NomeEsteso()
        {
            var concatenato = Codice + nome;

            return concatenato;
        }




        public void StampaDatiProdotto()
        {
            double PrezzoFinale = CalcoloIva();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-----------------------");
            Console.WriteLine("il Codice del prodotto è :" + Codice);
            Console.WriteLine("il Nome :" + nome);
            Console.WriteLine("Descrezione Prodotto :" + descrizione);
            Console.WriteLine("il prezzo senza iva è di :" + prezzo + " €");
            Console.WriteLine($"Prezzo compreso iva è di:{PrezzoFinale} €");
            Console.WriteLine("il nome esteso è :" + NomeEsteso());
            Console.WriteLine("-----------------------");
        }


    }
}
