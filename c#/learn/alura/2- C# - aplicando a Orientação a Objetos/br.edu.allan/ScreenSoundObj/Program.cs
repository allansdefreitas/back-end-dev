
Console.Clear();

Band bandOzeiasDePaula = new Band("Ozéias de Paula");

Album albumOzeiasDePaulaCemOvelhas = new Album("Cem Ovelhas");
albumOzeiasDePaulaCemOvelhas.ReleaseYear = 1973;

Song song = new Song(bandOzeiasDePaula, "Tu me guiarás");
Genre gospelGenre = new Genre();
gospelGenre.Nome = "Gospel";

song.Genre = gospelGenre;
song.DurationInSeconds = 210;

Song song2 = new Song(bandOzeiasDePaula, "Hoje eu sou feliz");
song2.Genre = gospelGenre;
song2.DurationInSeconds = 277;

albumOzeiasDePaulaCemOvelhas.AddSong(song);
albumOzeiasDePaulaCemOvelhas.AddSong(song2);

albumOzeiasDePaulaCemOvelhas.ShowAlbum();


Console.Clear();



bandOzeiasDePaula.AddAlbum(albumOzeiasDePaulaCemOvelhas);
bandOzeiasDePaula.showDiscography();




