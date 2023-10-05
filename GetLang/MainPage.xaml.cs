using Microsoft.Data.Sqlite;
using Microsoft.Maui.Animations;
using Microsoft.Maui.Devices.Sensors;
using System;
using System.Diagnostics;

namespace GetLang
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Conectar();

        }

        async void Btn_add(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CriarMusica());
        }


        public void Conectar()
        {
            using (var connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();
                Debug.WriteLine("Conectado");

                var command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS listaMusica (id INTEGER PRIMARY KEY AUTOINCREMENT, nome STRING, letra STRING)";
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

      
        public void ImprimirDatos()
        {
            using (var connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM listaMusicas";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0); // Índice 0 corresponde a la columna "id"
                        string nome = reader.GetString(1); // Índice 1 corresponde a la columna "name"
                        string letra = reader.GetString(2); // Índice 2 corresponde a la columna "letra"

                        Debug.WriteLine($"ID: {id}, Nombre: {nome}, Letra: {letra}");
                    }
                }

                connection.Close();
            }
        }
    }
}
