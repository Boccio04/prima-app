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

        public AutoInterattiva(string? marca, string? modello, string? colore, motore tipoMotore, int livelloCarburante) : base(marca, modello, colore, tipoMotore, livelloCarburante)
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
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("0");


        }
    }
}
