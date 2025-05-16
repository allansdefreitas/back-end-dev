
Console.Clear();

Album albumOzeiasDePaula = new Album();


albumOzeiasDePaula.Title = "Cem Ovelhas";
Song song = new Song();
song.Title = "Tu me guiarás";
song.DurationInSeconds = 210;

Song song2 = new Song();
song2.Title = "Hoje eu sou feliz";
song2.DurationInSeconds = 277;

albumOzeiasDePaula.AddSong(song);
albumOzeiasDePaula.AddSong(song2);

albumOzeiasDePaula.ShowAlbum();



