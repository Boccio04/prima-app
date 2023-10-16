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
                        this.Rifornisci(10);
                        this.stampaStato();
                        break;
                    case "0":
                        break;
                    default:
                        break;
                }

            } while (Comando != "0");
        }

        private void Menu()
        {
            Console.WriteLine("Accendi");
            Console.WriteLine("Spegni");
            Console.WriteLine("Rifornisci");
            Console.WriteLine("0");


        }
    }
}
