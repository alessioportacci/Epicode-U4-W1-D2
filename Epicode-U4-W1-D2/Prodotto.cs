using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D2
{
    internal class Prodotto
    {
        private string Nome {get; set;}
        private float Prezzo { get; set;}
        private int Quantita{ get; set;}
        //Constructor
        public Prodotto(string nome) 
        {
            Nome = nome;
        }
        public Prodotto(string nome, float prezzo): this(nome)
        {
            Prezzo = prezzo;
        }
        public Prodotto(string nome, float prezzo, int quantita): this(nome, prezzo) 
        { 
           Quantita = quantita;
        }

        public float getTotale()
        {
            return Prezzo * Quantita;
        }
    }
}
