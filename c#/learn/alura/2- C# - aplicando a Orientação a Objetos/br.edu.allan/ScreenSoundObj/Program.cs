
Console.Clear();

Song song1 = new Song();

song1.Title = "Conclusões";
Console.WriteLine(song1); // //Show the class 

Song song2 = new Song();
song2.Title = "Rompendo em Fé";
song2.Artist = "Elizeu Gomes";
song2.Duration = 4;

song1.ShowTechnicalSheet();
Console.WriteLine();
song2.ShowTechnicalSheet();
song2.ShowTitleAndArtist();

Console.WriteLine("Summarized description: {0}", song2.SummarizedDescription);

