

using Edu.Allan.Filmes;

Artista tomCruise = new Artista("Tom Cruise");
Artista sylvesterStallone = new Artista("Sylvester Stallone");
Artista denzelWashington = new Artista("Denzel Washington");

Filme stalloneCobra = new("Stallone Cobra", 1997, 8.5);
Filme mercenarios5 = new("Mercenários 5", 2026, 7.5);

mercenarios5.AdicionarArtista(sylvesterStallone);
mercenarios5.AdicionarArtista(tomCruise);
mercenarios5.AdicionarArtista(denzelWashington);

stalloneCobra.AdicionarArtista(sylvesterStallone);



sylvesterStallone.ExibirFilmografia();

Console.WriteLine();

mercenarios5.ExibirElenco();



