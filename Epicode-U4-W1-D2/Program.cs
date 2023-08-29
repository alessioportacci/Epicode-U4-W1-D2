using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivi un nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Scrivi un cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci eta");
            int eta = Int32.Parse(Console.ReadLine());

            Persona persona = new Persona(nome, cognome, eta);

            Console.WriteLine(persona.getNome());
            Console.WriteLine(persona.getCognome());
            Console.WriteLine(persona.getEta());

            Console.WriteLine(persona.getDettagli());


            Console.WriteLine("Inserisci nome del prodotto");
            string nomeProdotto = Console.ReadLine();
            Console.WriteLine("Inserisci prezzo del prodotto");
            float prezzo = float.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la quantità del prodotto");
            int quantita = Int32.Parse(Console.ReadLine());

            Prodotto prodotto = new Prodotto(nomeProdotto, prezzo, quantita);

            Console.WriteLine(prodotto.getTotale());

            Console.ReadLine();
        }
    }
}
