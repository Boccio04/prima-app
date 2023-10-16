using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
    internal class AutoInterattiva : Auto
    {
        public AutoInterattiva()
        {

        }

        public AutoInterattiva(string? marca, string? modello, string? colore, motore tipoMotore, int livelloCarburante, int livelloMaxCarburante) : base(marca, modello, colore, tipoMotore, livelloCarburante, livelloMaxCarburante)
        {
        }

        public void StampaMenu()
        {
            string Comando;

            do
            {

                this.Menu();

                Comando = Console.ReadLine();

                switch (Comando)
                {
                    case "1":
                        this.accendi();
                        this.stampaStato();
                        break;
                    case "2":
                        this.spegni();
                        this.stampaStato();
                        break;
                    case "3":
                        this.Rifornisci(this.ChiediCarburante());
                        this.stampaStato();
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }

            } while (Comando != "0");
        }

        /// <summary>
        /// Chiede all'utente quant immettere nel serbatoi
        /// </summary>
        /// 
        private int ChiediCarburante()
        {
            int result;

            Console.WriteLine("Quanto carburante vuoi aggiungere?");

            result = Int32.Parse(Console.ReadLine());

            return result;
        }


        private void Menu()
        {
            Console.WriteLine("Seleziona un comando");
            Console.WriteLine("Accendi");
            Console.WriteLine("Spegni");
            Console.WriteLine("Rifornisci");
            Console.WriteLine("0");


        }
    }
}
