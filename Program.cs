Biblioteca biblioteca = new Biblioteca(registrato: true);

// Aggiungere alcuni documenti alla lista della biblioteca
biblioteca.documenti.Add(new Libro { Codice = "001", Titolo = "Introduzione alla programmazione", Anno = 2021, Settore = "Informatica", Scaffale = 1, NumeroPagine = 200 });
biblioteca.documenti.Add(new DVD { Codice = "002", Titolo = "Programmazione avanzata", Anno = 2022, Settore = "Informatica", Scaffale = 2, Durata = 120 });
biblioteca.documenti.Add(new Libro { Codice = "003", Titolo = "Programmazione orientata agli oggetti", Anno = 2021, Settore = "Informatica", Scaffale = 3, NumeroPagine = 250 });

// Ricerca documenti contenenti la parola "programmazione"
List<Documento> risultati = biblioteca.RicercaDocumento("programmazione");

// Stampare i risultati
Console.WriteLine($"Trovati {risultati.Count} documenti:");
foreach (Documento documento in risultati)
{
    Console.WriteLine($"{documento.Codice}: {documento.Titolo}");
}