using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class Connection
{
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;" +
        "Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";


    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }

    public IEnumerable<Artista> Listar()
    {
        var list = new List<Artista>();

        using var connection = ObterConexao();
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

            Artista artist = new Artista(nameArtist, bioArtist) { Id = idArtist};

            list.Add(artist);

        }

        return list;


    }

}
