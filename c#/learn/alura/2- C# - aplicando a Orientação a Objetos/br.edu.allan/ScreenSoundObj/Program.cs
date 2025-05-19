
Console.Clear();

Album albumOzeiasDePaulaCemOvelhas = new Album();
Song song = new Song();
Gnere gospelGender = new Gnere();
gospelGender.Nome = "Gospel";


albumOzeiasDePaulaCemOvelhas.Title = "Cem Ovelhas";

song.Title = "Tu me guiarás";
song.Genre = gospelGender;
song.DurationInSeconds = 210;

Song song2 = new Song();
song2.Title = "Hoje eu sou feliz";
song2.Genre = gospelGender;
song2.DurationInSeconds = 277;

albumOzeiasDePaulaCemOvelhas.AddSong(song);
albumOzeiasDePaulaCemOvelhas.AddSong(song2);

albumOzeiasDePaulaCemOvelhas.ShowAlbum();


Console.Clear();

Band bandOzeiasDePaula = new Band();
bandOzeiasDePaula.Name = "Ozéias de Paula";

bandOzeiasDePaula.AddAlbum(albumOzeiasDePaulaCemOvelhas);
bandOzeiasDePaula.showDiscography();




