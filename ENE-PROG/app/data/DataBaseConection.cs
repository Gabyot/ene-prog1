using System;
using MySql.Data.MySqlClient;

namespace ENE_PROG.app.data
{
	public class DataBaseConection
	{
		public DataBaseConection()
		{
            string connectionString = "Server=localhost;Database=eneprog;User=root;Password=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Abre la conexión
                    connection.Open();

                    // Realiza una consulta de prueba (por ejemplo, selecciona una fila de una tabla)
                    string query = "SELECT 1";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result == 1)
                    {
                        Console.WriteLine("Conexión exitosa. La base de datos está en funcionamiento.");
                    }
                    else
                    {
                        Console.WriteLine("Error al verificar la conexión.");
                    }

                    // Cierra la conexión
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }
	}
}

