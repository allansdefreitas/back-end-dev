using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System.Data.SqlTypes;

namespace ScreenSound.Banco;

internal class ArtistDAL
{
    public static IEnumerable<Artist> ListAll()
    {
        var list = new List<Artist>();

        using var connection = new ScreenSoundContext().GetConnection();
        connection.Open();

        string sqlQuery = "SELECT * FROM Artistas";

        SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
        using SqlDataReader dataReader = sqlCommand.ExecuteReader();

        while (dataReader.Read())
        {
            string nameArtist = Convert.ToString(dataReader["Nome"]);
            string bioArtist = Convert.ToString((dataReader["Bio"]));
            int idArtist = Convert.ToInt32((dataReader["Id"]));
            //int profilePicArtist = Convert.ToString((dataReader["Id"]));

            Artist artist = new Artist(nameArtist, bioArtist) { Id = idArtist };

            list.Add(artist);

        }

        return list;
    }

    public static void Add(Artist artist)
    {

        Console.WriteLine("INSERT ==============================");
        using var connection = new ScreenSoundContext().GetConnection();
        connection.Open();

        string sqlString = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) " +
            "VALUES (@name, @profilePicture, @bio)";

        SqlCommand command = new SqlCommand(sqlString, connection);

        command.Parameters.AddWithValue("@name", artist.Name);
        command.Parameters.AddWithValue("profilePicture", artist.ProfilePicture);
        command.Parameters.AddWithValue("@bio", artist.Bio);

        int rowsChanged = command.ExecuteNonQuery();
        ShowMessageSuccessOrErrorQuery(rowsChanged);
    }

    public static void Update(Artist artist)
    {

        Console.WriteLine("UPDATE ==============================");
        using var connection = new ScreenSoundContext().GetConnection();
        connection.Open();

        string sqlString = "UPDATE Artistas " +
            "SET Nome=@name, FotoPerfil=@profilePicture, Bio=@bio " +
            "WHERE Id=@id";

        SqlCommand command = new SqlCommand(sqlString, connection);

        command.Parameters.AddWithValue("@name", artist.Name);
        command.Parameters.AddWithValue("@profilePicture", artist.ProfilePicture);
        command.Parameters.AddWithValue("@bio", artist.Bio);
        command.Parameters.AddWithValue("@id", artist.Id);

        int rowsChanged = command.ExecuteNonQuery();
        ShowMessageSuccessOrErrorQuery(rowsChanged);
    }

    public static void Delete(int id)
    {
        Console.WriteLine("DELETE ==============================");

        using var connection = new ScreenSoundContext().GetConnection();
        connection.Open();

        string SqlString = "DELETE FROM Artistas " +
            "WHERE Id = @id";

        SqlCommand command = new SqlCommand(SqlString, connection);

        command.Parameters.AddWithValue("@id", id);

        int rowsChanged = command.ExecuteNonQuery();
        ShowMessageSuccessOrErrorQuery(rowsChanged);
    }

    public static void ShowMessageSuccessOrErrorQuery(int rowsChanged)
    {

        Console.WriteLine($"{rowsChanged} rows changed!");

        if (rowsChanged == 1)
        {
            Console.WriteLine("The operation successfully completed!");
        }
        else if (rowsChanged > 1)
        {
            Console.WriteLine("ERROR: More than a row was changed!");
        }
        else
        {
            Console.WriteLine("ERROR: Something went wrong!");
        }

    }

}
