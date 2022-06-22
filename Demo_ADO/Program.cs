using Demo_ADO;
using System.Data.SqlClient;

string connectionString = "Server=TFNSDOTDE0400B; Database=Exo02; User Id=StudentAdmin; Password=Test1234=;";

// Créer la connection
SqlConnection connection = new SqlConnection(connectionString);

// Définir la commande SQL
SqlCommand cmd = connection.CreateCommand();
cmd.CommandText = "SELECT * FROM Produit";
cmd.CommandType = System.Data.CommandType.Text;

// Ouvrir la connection
connection.Open();

// Executer la commande SQL
SqlDataReader reader = cmd.ExecuteReader();

while(reader.Read())
{
    Produit p = new Produit
    {
        Id = (int)reader["ID"],
        Name = (string)reader["Nom"],
        Desc = (string)reader["Description"]
    };
    Console.WriteLine($"{p.Id} / {p.Name} / {p.Desc}");
}

// Fermeture la connection
connection.Close();