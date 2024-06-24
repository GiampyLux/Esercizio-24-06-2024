using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Esercizio_24_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Prodotti> list = new List<Prodotti>()
            {
               new Prodotti(1, "Coca Cola 150 ml", 2.50m),
                new Prodotti(2, "Insalata di pollo", 5.20m),
                new Prodotti(3, "Pizza Margherita", 10.00m),
                new Prodotti(4, "Pizza 4 Formaggi", 12.50m),
                new Prodotti(5, "Pz patatine fritte", 3.50m),
                new Prodotti(6, "Insalata di riso", 8.00m),
                new Prodotti(7, "Frutta di stagione", 5.00m),
                new Prodotti(8, "Pizza fritta", 5.00m),
                new Prodotti(9, "Piadina vegetariana", 6.00m),
                new Prodotti(10, "Panino Hamburger", 7.90m),
            };
            List<Prodotti> ordine = new List<Prodotti>();
            bool ordinazione = true;
            while (ordinazione)
            {
                StampaMenu(list);
                Console.Write("Seleziona degli ordini da 1 a 10");
                if (int.TryParse(Console.ReadLine(), out int scegliere))
                {
                    if (scegliere >= 1 && scegliere <= 10)
                    {
                        Prodotti ProdottoSelezionato = list.Find(p => p.Id == scegliere);
                        ordine.Add(ProdottoSelezionato);
                        Console.WriteLine($"hai aggiunto : {ProdottoSelezionato.Name} al tuo ordine!");
                    }
                    else if (scegliere == 11)
                    {
                        ordinazione = false;
                        Coperto(ordine);
                    }
                    else
                    {
                        Console.WriteLine("scelta non valida");
                    }
                }
                else
                {
                    Console.WriteLine("numero non valido");
                }
                    
                }

            }
            static void StampaMenu(List<Prodotti> menu)
            {
                foreach (Prodotti p in menu)
                {
                    Console.WriteLine($"{p.Id}: {p.Name} euro {p.Prezzo}");
                }
                Console.WriteLine("11: Stampa il conto");
            }

            static void Coperto(List<Prodotti> ordine)
            {
                decimal totale = 0;
                foreach (Prodotti p in ordine)
                {
                    Console.WriteLine($"{p.Name}: {p.Prezzo}");
                    totale += p.Prezzo;
                }

                const decimal servizioTavolo = 3.00m;
                Console.WriteLine($"servizio al tavolo: {servizioTavolo}");
                totale += servizioTavolo;
                Console.WriteLine($"totale: {totale}");
            }
        }
    }

