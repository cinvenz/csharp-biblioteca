using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Biblioteca
{
    public bool registrato;

    public List<Documento> documenti = new List<Documento>();
    public List<Utente> utenti = new List<Utente>();
    public List<Prestito> prestiti = new List<Prestito>();

    public Biblioteca(bool registrato)
    {
        this.registrato = registrato;
    }

    public List<Documento> RicercaDocumento(string parolaCercata)
    {
        List<Documento> risultati = new List<Documento>();

        foreach (Documento documento in documenti)
        {
            if (documento.Codice.ToString().Contains(parolaCercata) || documento.Titolo.Contains(parolaCercata))
            {
                risultati.Add(documento);
            }
        }

        return risultati;
    }

}
public class Utente
{
    public string Cognome { get; set; } = "";
    public string Nome { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string Telefono { get; set; } = "";
}

public class Documento
{
    public int Codice { get; set; }
    public string Titolo { get; set; } = "";
    public int Anno { get; set; }
    public string Settore { get; set; } = "";
    public int Scaffale { get; set; }
    public Autore? Autore { get; set; }

    public Documento(string codice, string titolo, int anno, string settore, int scaffale, Autore? autore)
    {
        Codice = int.Parse(codice);
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Scaffale = scaffale;
        Autore = autore;
    }

}


public class Libro : Documento
{
    public Libro(string codice, string titolo, int anno, string settore, int scaffale, Autore? autore) : base(codice, titolo, anno, settore, scaffale, autore)
    {
    }

    public int NumeroPagine { get; set; }
}

public class DVD : Documento
{
    public DVD(string codice, string titolo, int anno, string settore, int scaffale, Autore? autore) : base(codice, titolo, anno, settore, scaffale, autore)
    {
    }

    public int Durata { get; set; }
}


public class Autore
{
    public string Nome { get; set; } = "";
    public string Cognome { get; set; } = "";
}

public class Prestito
{
    public Documento? Documento { get; set; }
    public Utente? Utente { get; set; }
    public DateTime Dal { get; set; }
    public DateTime Al { get; set; }
}


