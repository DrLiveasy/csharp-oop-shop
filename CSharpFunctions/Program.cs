// See https://aka.ms/new-console-template for more information
using CSharpShop;

Console.WriteLine("inserisci il nome del tu prodotto");
string NomeProdotto = Console.ReadLine();
Console.WriteLine("inserisci descrizzione del prodotto");
string DescrizioneProdotto = Console.ReadLine();
Console.WriteLine("inserisci il prezzo del prodotto");
int PrezzoProdotto = Convert.ToInt32(Console.ReadLine());





Prodotto InputUtente = new Prodotto(NomeProdotto, DescrizioneProdotto, PrezzoProdotto);


InputUtente.StampaDatiProdotto();