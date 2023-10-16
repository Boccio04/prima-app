using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
    public class Auto
    {
        #region " tipi "
        // Tipi personalizzati


        public enum motore
        {
            benzina,
            diesel,
            elettrico
        }

        #endregion

        // Proprietà
        /// <summary>
        /// Marca del veicolo
        /// </summary>
        public string? marca;
        public string? modello;
        public string? colore;
        public motore tipoMotore;

        private int livelloCarburante;
        private bool accesa;
        private int livelloMaxCarburante;
        

        //costruttore
        public Auto():this("Ferrari", "Purosangue", "rosso", Auto.motore.elettrico, 50, 90)
        {
            
        }

        public Auto(string? marca, string? modello, string? colore, motore tipoMotore, int livelloCarburante, int livelloMaxCarburante)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            this.tipoMotore = tipoMotore;
            this.livelloCarburante = livelloCarburante;
            this.livelloMaxCarburante = livelloMaxCarburante;
        }

        /// <summary>
        /// Stampa la descrizione del veicolo
        /// </summary>
        /// 
        /*public void StampaMenu()
        {
            string Comando;

            do {

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

        private void Menu() {
            Console.WriteLine("Seleziona un comando");
            Console.WriteLine("Seleziona un comando");
            Console.WriteLine("Seleziona un comando");
            Console.WriteLine("Seleziona un comando");


        }*/
        public void StampaDescrizione()
        {
            //stampo le caratteristiche dell'auto
            Console.WriteLine(generaDescrizione());
        }



        private string generaDescrizione()
        {

            string result;

            result = "marca:" + this.marca + "\n";
            result += $"modello: {this.modello} \n";
            result += $"motore:  {this.tipoMotore}\n";
            result += $"colore:  {this.colore}\n";
            result += "livello Carburante:" + this.livelloCarburante;

            return result;

        }

        /// <summary>
        /// Genera lo stato (carburante, accensione,) del veicolo
        /// </summary>
        /// <returns>Lo stato del veicolo</returns>
        /// 

        public void stampaStato()
        {
            Console.WriteLine(GeneraStato());
        }

        public string GeneraStato()
        {
            string result;

            result = $"carburante: {this.livelloCarburante}";
            if (this.accesa == true)
            {
                // se il veicolo è acceso scrivo accesa
                result += "accesa";

            }
            else
            {
                // alrtrimenti scrivo spenta
                result += "spenta";


            }




            return result;

        }

        /// <summary>
        /// Tenta di avviare il veicolo <para>
        /// Se non c'è carburante l'accensione fallisce</para>
        /// </summary>
        public void accendi()
        {

            //verifio il livello del carburante
            if (this.livelloCarburante > 0)
            {
                //se è maggiore di zero accendo il veicolo
                this.accesa = true;
            }
            else
            {
                //se è minore o uguale a zero spengo il veicolo
                this.accesa = false;
            }


        }

        /// <summary>
        /// Agginge carburante all'auto
        /// </summary>
        /// <param name="carburante"></param>
        public void spegni()
        {
            this.accesa = false;
            // spegne il veicolo

        }

        public void Rifornisci(int carburante)
        {
            //se ilalore è positivo, lo aggiungo
            if (carburante > 0)
            {
                this.livelloCarburante += carburante;
                Console.WriteLine(carburante);

                if (this.livelloCarburante > this.livelloMaxCarburante)
                {
                    this.livelloCarburante = this.livelloMaxCarburante;
                }
            }
        }

    }

    // fine
}
