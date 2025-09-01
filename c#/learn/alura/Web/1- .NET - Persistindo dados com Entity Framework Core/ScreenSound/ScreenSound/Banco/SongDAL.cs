using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System.Data.SqlTypes;

namespace ScreenSound.Banco;

internal class SongDAL : DAL<Song>
{

    private readonly ScreenSoundContext context;

    public SongDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public override IEnumerable<Song> ListAll()
    {
        using var context = new ScreenSoundContext();
        return context.Songs.ToList();
    }

    public override void Add(Song song)
    {
        context.Songs.Add(song);
        context.SaveChanges();
    }

    public override void Update(Song song)
    {
        context.Songs.Update(song);
        context.SaveChanges();
    }

    public override void Delete(Song song)
    {
        context.Songs.Remove(song);
        context.SaveChanges();
    }

    public override Song Get(int id)
    {
        return context.Songs.Find(id);
    }

    public override Song? GetByName(string name)
    {
        return context.Songs.FirstOrDefault(a => a.Name.Equals(name));
    }

    public void PrintAll()
    {
        var songs = ListAll();
        foreach (var song in songs)
        {
            Console.WriteLine(song);
            Console.WriteLine("===================================");
        }
    }

    //public static IEnumerable<Song> ListAll()
    //{
    //    var list = new List<Song>();

    //    using var connection = new ScreenSoundContext().GetConnection();
    //    connection.Open();

    //    string sqlQuery = "SELECT * FROM Musicas";

    //    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
    //    using SqlDataReader dataReader = sqlCommand.ExecuteReader();

    //    while (dataReader.Read())
    //    {
    //        int id = Convert.ToInt32(dataReader["Id"]);
    //        string songTitle = Convert.ToString(dataReader["Nome"]);

    //        Song song = new Song(songTitle)
    //        {
    //            Id = id,
    //        };

    //        list.Add(song);

    //    }

    //    return list;
    //}

    //public static void Add(Song song)
    //{

    //    Console.WriteLine("INSERT ==============================");
    //    using var connection = new ScreenSoundContext().GetConnection();
    //    connection.Open();

    //    string sqlString = "INSERT INTO Musicas (Nome) " +
    //        "VALUES (@name)";

    //    SqlCommand command = new SqlCommand(sqlString, connection);

    //    command.Parameters.AddWithValue("@name", song.Name);

    //    int rowsChanged = command.ExecuteNonQuery();
    //    ShowMessageSuccessOrErrorQuery(rowsChanged);
    //}

    //public static void Update(Song song)
    //{

    //    Console.WriteLine("UPDATE ==============================");
    //    using var connection = new ScreenSoundContext().GetConnection();
    //    connection.Open();

    //    string sqlString = "UPDATE Musicas " +
    //        "SET Nome=@name WHERE Id=@id";

    //    SqlCommand command = new SqlCommand(sqlString, connection);

    //    command.Parameters.AddWithValue("@name", song.Name);
    //    command.Parameters.AddWithValue("@id", song.Id);

    //    int rowsChanged = command.ExecuteNonQuery();
    //    ShowMessageSuccessOrErrorQuery(rowsChanged);
    //}

    //public static void Delete(int id)
    //{
    //    Console.WriteLine("DELETE ==============================");

    //    using var connection = new ScreenSoundContext().GetConnection();
    //    connection.Open();

    //    string SqlString = "DELETE FROM Musicas " +
    //        "WHERE Id = @id";

    //    SqlCommand command = new SqlCommand(SqlString, connection);

    //    command.Parameters.AddWithValue("@id", id);

    //    int rowsChanged = command.ExecuteNonQuery();
    //    ShowMessageSuccessOrErrorQuery(rowsChanged);
    //}

    //public static void ShowMessageSuccessOrErrorQuery(int rowsChanged)
    //{

    //    Console.WriteLine($"{rowsChanged} rows changed!");

    //    if (rowsChanged == 1)
    //    {
    //        Console.WriteLine("The operation successfully completed!");
    //    }
    //    else if (rowsChanged > 1)
    //    {
    //        Console.WriteLine("ERROR: More than a row was changed!");
    //    }
    //    else
    //    {
    //        Console.WriteLine("ERROR: Something went wrong!");
    //    }

    //}

}
