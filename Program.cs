// L'app deve modellare un'automobile, per farlo deve registrare le informazioni relative a:
// - marca
// - modello
// - tipo di motore
// - colore 
// All'avvio dell'app deve mostrare lo stato dell'auto, stampando marca, modello, colore e tipo di motore
// Per modellare l'automobile implementiamo una classe chiamata auto

// Aggiungi al'applicazione un menu che consenta all'utente di selezionare l'operazione da fare, il menu deve prevedere le seguenti voci:
// 1)Accendi
// 2)Spegni
// 3)Rifornisci
// 0)Esci

using System.Runtime.CompilerServices;
using prima_app;

AutoInterattiva miaAuto;

miaAuto = new AutoInterattiva("Ferrari", "Purosangue", "rosso", Auto.motore.elettrico, 0);

miaAuto.stampaStato();

miaAuto.StampaMenu();

Console.ReadLine();

//miaAuto.marca = "ferrari";
//miaAuto.modello = "purosangue";
//miaAuto.colore = "rosso";
//miaAuto.tipoMotore = Auto.motore.benzina;








