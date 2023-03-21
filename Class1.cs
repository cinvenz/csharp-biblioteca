using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Biblioteca
{
    bool registrato;

    List<Documento> documenti = new List<Documento>();
    List<Utente> utenti = new List<Utente>();
    List<Prestito> prestiti = new List<Prestito>();

    public Biblioteca(bool registrato)
    {
        this.registrato = registrato;
    }

    public List<Documento> CercaDocumento(string valoreRicerca)
    {
        List<Documento> risultati = new List<Documento>();

        foreach (Documento documento in documenti)
        {
            if (documento.Codice.Contains(valoreRicerca) || documento.Titolo.Contains(valoreRicerca))
            {
                risultati.Add(documento);
            }
        }

        return risultati;
    }

}
public class Utente
{
    string Cognome { get; set; } = "";
    string Nome { get; set; } = "";
    string Email { get; set; } = "";
    string Password { get; set; } = "";
    string RecapitoTelefonico { get; set; } = "";
}

public class Documento
{
    public string Codice { get; set; } = "";
    string Titolo { get; set; } = "";
    int Anno { get; set; }
    string Settore { get; set; } = "";
    int Scaffale { get; set; }
    Autore? Autore { get; set; }
    
}


public class Libro : Documento
{
    int NumeroPagine { get; set; }
}

public class DVD : Documento
{
    int Durata { get; set; }
}


public class Autore
{
    string Nome { get; set; } = "";
    string Cognome { get; set; } = "";
}

public class Prestito
{
    Documento? Documento { get; set; }
    Utente? Utente { get; set; }
    DateTime Dal { get; set; }
    DateTime Al { get; set; }
}

