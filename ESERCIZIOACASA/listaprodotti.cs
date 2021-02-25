using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*form lista_prodotti
private void cmdagg_Click(object sender, EventArgs e)
{
 
    for(int i=0; i<dati.n;i++)
{
    dati.prodotti[i].quantita=txtquant.text;
    dati.prodotti[i].prezzo=txtprezzo.text;
    dati.prodotti[i].sconto=txtsconto.text;
    dati.prodotti[i].codice=txtcodice.text;
    dati.prodotti[i].descrizione=txtdescr.text;
   if (dati.n==0)
    {
            Form_carrellovuoto FRMCARRVUO = new Form_carrellovuoto();
            FRMCARRVUO.Show();
            this.Hide();
    }
    else
    {
         DataTable tabcorsi = new DataTable();
            tabcorsi.Columns.Add("quantità.", typeof(string));
            tabcorsi.Columns.Add("prezzo.", typeof(double));
            tabcorsi.Columns.Add("sconto.", typeof(double));
            tabcorsi.Columns.Add("codice.", typeof(string));
            tabcorsi.Columns.Add("descrizione.", typeof(string));
            
           
                tabcorsi.Rows.Add(dati.prodotti[i].quantita, dati.prodotti[i].prezzo, dati.prodotti[i].sconto,
                    dati.prodotti[i].codice, dati.prodotti[i].descrizione;
                gridcorsi.DataSource = tabcorsi;
            
    }
}
} le variabili assumono i valori di quelli della parte grafica
