// L'app deve modellare un'automobile, per farlo deve registrare le informazioni relative a:
// - marca
// - modello
// - tipo di motore
// - colore 
// All'avvio dell'app deve mostrare lo stato dell'auto, stampando marca, modello, colore e tipo di motore
// Per modellare l'automobile implementiamo una classe chiamata auto

Auto miaAuto;

miaAuto = new Auto();

miaAuto.marca = "ferrari";
miaAuto.modello = "purosangue";
miaAuto.colore = "rosso";
miaAuto.tipoMotore = Auto.motore.benzina;

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
    public string? marca;
    public string? modello;
    public string? colore;
    public motore tipoMotore;

    public Auto()
    {
    }

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
