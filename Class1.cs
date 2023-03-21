using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Biblioteca
{
    bool registrato;

    public Biblioteca(bool registrato)
    {
        this.registrato = registrato;
 
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

abstract class Documento
{
    string Codice { get; set; } = "";
    string Titolo { get; set; } = "";
    int Anno { get; set; }
    string Settore { get; set; } = "";
    int Scaffale { get; set; }
    Autore? Autore { get; set; }
    
}


class Libro : Documento
{
    int NumeroPagine { get; set; }
}

class DVD : Documento
{
    int Durata { get; set; }
}


class Autore
{
    string Nome { get; set; } = "";
    string Cognome { get; set; } = "";
}