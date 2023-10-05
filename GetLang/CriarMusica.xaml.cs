using Microsoft.Data.Sqlite;
using Microsoft.Maui.Animations;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace GetLang;

public partial class CriarMusica : ContentPage
{
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    public CriarMusica()
	{
		InitializeComponent();
	}


private void Button_Clicked(object sender, EventArgs e)
{
    using (var connection = new SqliteConnection("Data Source=hello.db"))
    {


            string nome = nomeMusica.Text;
            string letra = letraMusica.Text;


        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO listaMusica (nome, letra) VALUES (@nome, @letra)";

        command.Parameters.AddWithValue("@nome", nome);
        command.Parameters.AddWithValue("@letra", letra);

        command.ExecuteNonQuery();
        connection.Close();
            string text = "Musica Adicionada!";
            ToastDuration duration = ToastDuration.Short;
            double fontSize = 14;

            var toast = Toast.Make(text, duration, fontSize);
            toast.Show(cancellationTokenSource.Token);

            nomeMusica.Text = string.Empty;
            letraMusica.Text = string.Empty;
    }
}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        nomeMusica.Text = string.Empty; 
        letraMusica.Text = string.Empty;
    }
}