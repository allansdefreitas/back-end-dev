
Console.Clear();

Genre gospelGenre = new Genre();
gospelGenre.Nome = "Gospel";

// Create a Band
Band bandOzeiasDePaula = new Band("Ozéias de Paula");

/* Album: Cem Ovelhas ----------------------------------------------- */
Album albumCemOvelhas = new Album("Cem Ovelhas");
albumCemOvelhas.ReleaseYear = 1973;

// Create songs
Song songTuMeGuiaras = new Song(bandOzeiasDePaula, "Tu me guiarás")
{
    DurationInSeconds = 270, // A new way to initialize more (usually optional) properties.
    IsAvailableInPlann = true,
    Genre = gospelGenre,
};

Song songHojeSouFeliz = new Song(bandOzeiasDePaula, "Hoje eu sou feliz")
{
    DurationInSeconds = 275,
    IsAvailableInPlann = false,
    Genre = gospelGenre,
};

// To associate songs to an Album
albumCemOvelhas.AddSong(songTuMeGuiaras);
albumCemOvelhas.AddSong(songHojeSouFeliz);

// To associate Album to a Band
bandOzeiasDePaula.AddAlbum(albumCemOvelhas);


/* Album: O Amor é Tudo ----------------------------------------------- */
// Create album
Album albumOAmorETudo = new Album("O Amor é Tudo")
{
    ReleaseYear = 1979,
};

// Create songs
Song songOAmorETudo = new Song(bandOzeiasDePaula, "O Amor é Tudo")
{
    DurationInSeconds = 285,
    IsAvailableInPlann = true,
    Genre = gospelGenre,
};

Song songVinteSeculos = new Song(bandOzeiasDePaula, "VinteSeculos")
{
    DurationInSeconds = 247,
    IsAvailableInPlann = true,
    Genre = gospelGenre,
};

Song songQuemEsTu = new Song(bandOzeiasDePaula, "Quem És Tu")
{
    DurationInSeconds = 281,
    IsAvailableInPlann = true,
    Genre = gospelGenre,
};

// To associate songs to an Album
albumOAmorETudo.AddSong(songOAmorETudo);
albumOAmorETudo.AddSong(songVinteSeculos);
albumOAmorETudo.AddSong(songQuemEsTu);

// To associate Album to a Band
bandOzeiasDePaula.AddAlbum(albumOAmorETudo);


// Show info
Console.Clear();

albumCemOvelhas.ShowAlbum();

Console.WriteLine();
albumOAmorETudo.ShowAlbum();

Console.WriteLine();

songTuMeGuiaras.ShowTechnicalSheet();
Console.WriteLine();
songHojeSouFeliz.ShowTechnicalSheet();
Console.WriteLine();

bandOzeiasDePaula.showDiscography();






