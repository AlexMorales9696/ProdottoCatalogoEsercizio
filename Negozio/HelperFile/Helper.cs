using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelperFile
{
    public class Helper
    {
        private  readonly string Path;
        public Helper(string path)
        {
            Path = path;
        }
        public void AddCatalogo(Catalogo catalogo)
        {
            var resultC = $"{catalogo.IdCatalogo};{catalogo.IdProdotto};{catalogo.Prezzo};{catalogo.NomeCatalogo};{catalogo.TipoCatalogo}";

            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(resultC);
            }
        }

        public void AddProdotto(Prodotto prodotto)
        {
            var resultP = $"{prodotto.IdProdotto};{prodotto.NomeProdotto};{prodotto.Quantità};{prodotto.TipoProdotto}";
           // var resultP = $"{prodotto.IdProdotto};{prodotto.NomeProdotto};{prodotto.Quantità};{prodotto.TipoProdotto}";
            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(resultP);
            }


        }
        public List<Prodotto> ReadAllProdotto()
        {
            var Prodotti = new List<Prodotto>();

            using (var stream = new StreamReader(Path))
            {
                var header = "IdProdotto;NomeProdotto;Quantità;TipoProdotto";
                //var header = "IdProdotto;NomeProdotto;Quantità;Scadenza;TipoProdotto";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");

                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");


                    Prodotti.Add(new Prodotto
                    {
                        IdProdotto = splitted[0],
                        NomeProdotto = splitted[1],
                        Quantità = splitted[2],
                        TipoProdotto = splitted[3]
                    });
                }

                return Prodotti;
            }




        }
    }
    
}
