using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_24_06_2024
{
    internal class Prodotti
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Prezzo { get; }

        public Prodotti(int id,string name,decimal prezzo)
        {
            Id = id;
            Name = name;
            Prezzo = prezzo;
        }
    }
}
