
Console.Clear();

Band bandOzeiasDePaula = new Band();
bandOzeiasDePaula.Name = "Ozéias de Paula";

Album albumOzeiasDePaulaCemOvelhas = new Album();
albumOzeiasDePaulaCemOvelhas.ReleaseYear = 1973;
Song song = new Song(bandOzeiasDePaula);
Gnere gospelGender = new Gnere();
gospelGender.Nome = "Gospel";

albumOzeiasDePaulaCemOvelhas.Title = "Cem Ovelhas";

song.Title = "Tu me guiarás";
song.Genre = gospelGender;
song.DurationInSeconds = 210;

Song song2 = new Song(bandOzeiasDePaula);
song2.Title = "Hoje eu sou feliz";
song2.Genre = gospelGender;
song2.DurationInSeconds = 277;

albumOzeiasDePaulaCemOvelhas.AddSong(song);
albumOzeiasDePaulaCemOvelhas.AddSong(song2);

albumOzeiasDePaulaCemOvelhas.ShowAlbum();


Console.Clear();



bandOzeiasDePaula.AddAlbum(albumOzeiasDePaulaCemOvelhas);
bandOzeiasDePaula.showDiscography();




