using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D2
{
    internal class Televisione
    {
        //Parameters
        private bool Accesa {get; set;}
        private int Volume { get; set;}
        private int Canale { get; set;}
        private bool Muto { get; set;}

        //Costructors
        Televisione()
        {
            Accesa = false;
            Muto = false;
        }
        Televisione(int volume): this()
        {
            Volume = volume;
        }
        Televisione(int volume, int canale): this(volume) 
        {
            Canale = canale;
        }

        //Methods
        public void pulsanteAccensione()
        {
            Accesa = !Accesa;
        }

        public void impostaCanale(int canale)
        {
            Canale |= canale;
        }
        public void canaleSuccessivo()
        {
            Canale = Canale == 99? 0: Canale++; 
        }
        public void canalePrecedente()
        {
            Canale = Canale == 0 ? 99 : Canale--;
        }

        public void aumentaVolume()
        {
            Volume = Volume == 10 ? 10 : Volume++;
        }
        public void abbassaVolume()
        {
            Volume = Volume == 0 ? 0 : Volume--;
        }
        public void pulsanteSilenzioso()
        {
            Muto = !Muto;
        }
        
        public string printStatoTv()
        {
            return string.Concat
                (
                    "Tv Accesa: ", Accesa ,"\n",
                    "Volume: ", Volume, "\n",
                    "Canale: ", Canale, "\n",
                    "Muto: ", Muto
                );
        }
    }
}
