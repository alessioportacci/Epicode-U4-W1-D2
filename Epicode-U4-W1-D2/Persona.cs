using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D2
{
    internal class Persona
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        private int Eta { get; set; }

        //Costruttori
        public Persona(string nome)
        {
            Nome = nome;
        }
        public Persona(string nome, string cognome): this(nome)
        {
            Cognome = cognome;
        }
        public Persona(string nome, string cognome, int eta): this(nome, cognome)
        {
            Eta = eta;
        }

        //Geters
        public string getNome()
        {
            return Nome;
        }
        public string getCognome()
        { 
            return Cognome;
        }
        public int getEta() 
        {
            return Eta;
        }
        public string getDettagli()
        {
            return string.Concat(getNome(), " ", 
                                 getCognome(), " ",
                                 getEta(), " anni");
        }


    }
}
