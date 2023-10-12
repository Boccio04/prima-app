using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
    class Auto
    {
        // Tipi personalizzati

        public enum motore
        {
            benzina,
            diesel,
            elettrico
        }

        // Proprietà
        /// <summary>
        /// Marca del veicolo
        /// </summary>
        public string? marca;
        public string? modello;
        public string? colore;
        public motore tipoMotore;

        public int livelloCarburante;
        private bool accesa;

        //costruttore
        public Auto()
        {
        }

        public Auto(string? marca, string? modello, string? colore, motore tipoMotore, int livelloCarburante)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            this.tipoMotore = tipoMotore;
            this.livelloCarburante = livelloCarburante;
        }

        /// <summary>
        /// Stampa la descrizione del veicolo
        /// </summary>
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
        /// Spegne il veicolo
        /// </summary>

        public void spegni()
        {
            this.accesa = false;
            // spegne il veicolo

        }


    }

    // fine
}
