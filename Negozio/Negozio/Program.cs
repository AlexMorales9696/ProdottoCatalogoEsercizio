// See https://aka.ms/new-console-template for more information

using HelperFile;

var fileHelpe  = new Helper(@"ProdottiP.txt");

var Neg = fileHelpe.ReadAllProdotto();

Console.WriteLine("*********************");

foreach (var prodotto in Neg)
{
    Console.WriteLine($" IdProdotto: {prodotto.IdProdotto} - NomeProdotto:{prodotto.NomeProdotto} - Quantità: {prodotto.Quantità} - TipoProdotto: {prodotto.TipoProdotto}");
    //Console.WriteLine($": -IdProdotto: {Prodotto.IdProdotto} - NomeProdotto:{Prodotto.NomeProdotto} - Quantità: {Prodotto.Quantità} - Scadenza: {Prodotto.Scadenza} - TipoProdotto: {Prodotto.TipoProdotto}");
}

Console.WriteLine("*********************");
/*
Console.WriteLine("Inserisci  IdProdotto");
var IdProdotto = Console.ReadLine();
Console.WriteLine("Inserisci NomeProdotto");
var NomeProdotto = Console.ReadLine();
Console.WriteLine("Inserisci Quantità");
var Quantità = Console.ReadLine();
//Console.WriteLine("Inserisci la Scadenza");
//var  Scadenza = Console.ReadLine();
Console.WriteLine("Inserisci tipoProdotto");
var TipoProdotto = Console.ReadLine();

var Prodottonew= new Prodotto();
Prodottonew.IdProdotto = IdProdotto;
Prodottonew.NomeProdotto = NomeProdotto;
Prodottonew.Quantità = Quantità;
//Prodottonew.Scadenza = DateTime.Parse(Scadenza);
Prodottonew.TipoProdotto = TipoProdotto;

fileh.AddProdotto(Prodottonew);

rub= fileh.ReadAllProdotto();   */


/*Console.WriteLine("*********************");

foreach (var prodotto in rub)
{
    Console.WriteLine($": -IdProdotto: {prodotto.IdProdotto} - NomeProdotto:{prodotto.NomeProdotto} - Quantità: {prodotto.Quantità} - TipoProdotto: {prodotto.TipoProdotto}");
   // Console.WriteLine($": -IdProdotto: {prodotto.IdProdotto} - NomeProdotto:{prodotto.NomeProdotto} - Quantità: {prodotto.Quantità} - Scadenza: {prodotto.Scadenza} - TipoProdotto: {prodotto.TipoProdotto}");
}

Console.WriteLine("*********************");


Console.ReadLine();*/
