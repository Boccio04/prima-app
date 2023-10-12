// L'app deve modellare un'automobile, per farlo deve registrare le informazioni relative a:
// - marca
// - modello
// - tipo di motore
// - colore 
// All'avvio dell'app deve mostrare lo stato dell'auto, stampando marca, modello, colore e tipo di motore
// Per modellare l'automobile implementiamo una classe chiamata auto

Auto miaAuto;

miaAuto = new Auto("Ferrari", "Purosangue", "rosso", Auto.motore.elettrico);



//miaAuto.marca = "ferrari";
//miaAuto.modello = "purosangue";
//miaAuto.colore = "rosso";
//miaAuto.tipoMotore = Auto.motore.benzina;

miaAuto.StampaDescrizione();

Console.ReadLine();


class Auto{
    // Tipi personalizzati

    public enum motore {
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

    //costruttore
    public Auto()
    {
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="marca">Marca del veicolo (es;fiat)</param>
    /// <param name="modello">Modello del veicolo (es:panda)</param>
    /// <param name="colore">Colore del veicolo</param>
    /// <param name="tipoMotore">Motore del veicolo(es:benzina,diesel,elettrica)</param>

    public Auto(string? marca, string? modello, string? colore, motore tipoMotore)
    {
        this.marca = marca;
        this.modello = modello;
        this.colore = colore;
        this.tipoMotore = tipoMotore;
    }

    public void StampaDescrizione()
    {
        //stampo le caratteristiche dell'auto
        Console.WriteLine(generaDescrizione());
    }

    private string generaDescrizione(){

        string result;

        result = "marca:" + this.marca + "\n";
        result += $"modello: {this.modello} \n";
        result += $"motore:  {this.tipoMotore}\n";
        result += "colore:" + this.colore;

        return result;

    }


}
