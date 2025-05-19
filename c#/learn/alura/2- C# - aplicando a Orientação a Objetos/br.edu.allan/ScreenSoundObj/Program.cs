
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
string oAmorETudoLyricsString = @"No princípio era o verbo, e o verbo era Deus
E a natureza já existia nos planos Seus
Desde a maior estrela a mais singela flor
Traçando leis tudo Ele fez por Seu amor
O amor é tudo, feliz é quem ama
Não há barreiras para conter suas chamas
O amor é bálsamo na triste vida
O amor é mais, também é paz, o amor é vida
O amor supera o ódio, através do Seu poder
Tudo ele sofre, tudo suporta, tudo ele crê
Amai-vos uns aos outros conforme Eu vos amei
Andai na luz, disse Jesus o Rei dos Reis!
O amor é tudo, feliz é quem ama
Não há barreiras para conter suas chamas
O amor é bálsamo na triste vida
O amor é mais, também é paz, o amor é vida";

SongLyrics oAmorETudoLyrics = new SongLyrics(oAmorETudoLyricsString)
{
    Source = "Musixmatch",
};

Song songOAmorETudo = new Song(bandOzeiasDePaula, "O Amor é Tudo")
{
    DurationInSeconds = 285,
    IsAvailableInPlann = true,
    Genre = gospelGenre,
    Lyrics = oAmorETudoLyrics,
};


string vinteSeculosLyricsString = @"O mundo ainda sofre demais
Do que o mundo, de vinte séculos atrás
Pois a maldade, se multiplicou
E a humanidade se debate e agoniza sem amor
Jesus
Há tanto tempo te seguir eu me propus
Ao ver a iniquidade se multiplicar
E só com tua ajuda eu posso escapar
Jesus
Eu quero, todavia, carregar a cruz
Preciso cada dia me santificar
Eu quero e preciso te acompanhar
São vinte séculos, ou quase já
E o mundo inteiro continua a se afastar
Pelo universo, sem direção
Mas Jesus Cristo continua estendendo sua mão
Jesus
Há tanto tempo te seguir eu me propus
Ao ver a iniquidade se multiplicar
E só com tua ajuda eu posso escapar
Jesus
Eu quero, todavia, carregar a cruz
Preciso cada dia me santificar
Eu quero e preciso te acompanhar
Jesus
Há tanto tempo te seguir eu me propus
Ao ver a iniquidade se multiplicar
E só com tua ajuda eu posso escapar";

SongLyrics vinteSeculosLyrics = new SongLyrics(vinteSeculosLyricsString)
{
    Source = "Musixmatch",
};

Song songVinteSeculos = new Song(bandOzeiasDePaula, "Vinte Seculos")
{
    DurationInSeconds = 247,
    IsAvailableInPlann = true,
    Genre = gospelGenre,
    Lyrics = vinteSeculosLyrics,
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

/* Playlist ---------------------------------- */
Console.WriteLine();

Playlist playlistAntigas = new Playlist("Músicas antigas");

playlistAntigas.AddSong(songTuMeGuiaras);
playlistAntigas.AddSong(songQuemEsTu);
playlistAntigas.AddSong(songHojeSouFeliz);
playlistAntigas.AddSong(songVinteSeculos);
playlistAntigas.AddSong(songOAmorETudo);

playlistAntigas.ShowPlayList();

User userAllan = new User("Allan", "allan@gmail.com");
userAllan.AddToPlaybackHistory(songVinteSeculos);
userAllan.AddPlaylist(playlistAntigas);

Console.WriteLine();

userAllan.ShowPlaylists();


