using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIOACASA
{
    class DATI  
    {
        private static int n;
        private struct rec_clienti
        {
            public string username;
            private string password;
            public string nome;
            public string cognome;
            
        }
        private struct rec_prodotti
        {
            public int quantita;
            public double prezzo;
            public double sconto;
            public string codice;
            public string descrizione;
        }
    }
}
