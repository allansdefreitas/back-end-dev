using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System.Data.SqlTypes;

namespace ScreenSound.Banco;

internal class SongDAL
{
    public static IEnumerable<Song> ListAll()
    {
        var list = new List<Song>();

        using var connection = new Connection().GetConnection();
        connection.Open();

        string sqlQuery = "SELECT * FROM Musicas";

        SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
        using SqlDataReader dataReader = sqlCommand.ExecuteReader();

        while (dataReader.Read())
        {
            int id = Convert.ToInt32(dataReader["Id"]);
            string songTitle = Convert.ToString(dataReader["Nome"]);

            Song song = new Song(songTitle)
            {
                Id = id,
            };

            list.Add(song);

        }

        return list;
    }

    public static void Add(Song song)
    {

        Console.WriteLine("INSERT ==============================");
        using var connection = new Connection().GetConnection();
        connection.Open();

        string sqlString = "INSERT INTO Musicas (Nome) " +
            "VALUES (@name)";

        SqlCommand command = new SqlCommand(sqlString, connection);

        command.Parameters.AddWithValue("@name", song.Name);

        int rowsChanged = command.ExecuteNonQuery();
        ShowMessageSuccessOrErrorQuery(rowsChanged);
    }

    public static void Update(Song song)
    {

        Console.WriteLine("UPDATE ==============================");
        using var connection = new Connection().GetConnection();
        connection.Open();

        string sqlString = "UPDATE Musicas " +
            "SET Nome=@name WHERE Id=@id";

        SqlCommand command = new SqlCommand(sqlString, connection);

        command.Parameters.AddWithValue("@name", song.Name);
        command.Parameters.AddWithValue("@id", song.Id);

        int rowsChanged = command.ExecuteNonQuery();
        ShowMessageSuccessOrErrorQuery(rowsChanged);
    }

    public static void Delete(int id)
    {
        Console.WriteLine("DELETE ==============================");

        using var connection = new Connection().GetConnection();
        connection.Open();

        string SqlString = "DELETE FROM Musicas " +
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
