// L'app deve modellare un'automobile, per farlo deve registrare le informazioni relative a:
// - marca
// - modello
// - tipo di motore
// - colore 
// All'avvio dell'app deve mostrare lo stato dell'auto, stampando marca, modello, colore e tipo di motore
// Per modellare l'automobile implementiamo una classe chiamata auto

using System.Runtime.CompilerServices;
using prima_app;

Auto miaAuto;

miaAuto = new Auto("Ferrari", "Purosangue", "rosso", Auto.motore.elettrico, 0);



miaAuto.StampaDescrizione();
miaAuto.stampaStato();


miaAuto.accendi();
miaAuto.stampaStato();

miaAuto.spegni();
miaAuto.stampaStato();

Console.ReadLine();

//miaAuto.marca = "ferrari";
//miaAuto.modello = "purosangue";
//miaAuto.colore = "rosso";
//miaAuto.tipoMotore = Auto.motore.benzina;








