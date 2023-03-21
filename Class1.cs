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
public class User 
{
    string cognome;
    string nome;
    string email;
    string password;
    string telefono;

    public User(string cognome, string nome, string email, string password, string telefono)
    {
        this.cognome = cognome;
        this.nome = nome;
        this.email = email;
        this.password = password;
        this.telefono = telefono;
    }

}

public class Documento
{
    string codiceIdentificativo;
    string titolo;
    int anno;
    int scaffale;
    string autore;

    public Documento(string codiceIdentificativo, string titolo, int anno, int scaffale, string autore)
    {
        this.codiceIdentificativo = codiceIdentificativo;
        this.titolo = titolo;
        this.anno = anno;
        this.scaffale = scaffale;
        this.autore = autore;
    }
}

class Libro : Documento
{
    int NumeroPagine;

    public Libro(string codiceIdentificativo, string titolo, int anno, int scaffale, string autore, int NumeroPagine) : base(codiceIdentificativo, titolo, anno, scaffale, autore)
    {
        this.NumeroPagine = NumeroPagine;

    }
}

class DVD : Documento
{
    int Durata;
    public DVD(string codiceIdentificativo, string titolo, int anno, int scaffale, string autore, int Durata) : base(codiceIdentificativo, titolo, anno, scaffale, autore)
    {
        this.Durata = Durata;

    }
}

class Autore
{
    string Nome;
    string Cognome;

    public Autore(string nome, string cognome)
    {
        Nome = nome;
        Cognome = cognome;
    }
}
