using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using SQLite;
using System.Diagnostics;

namespace GetLang
{
    public partial class CriarMusica : ContentPage
    {

        Banco database;
        public CriarMusica()
        {
            InitializeComponent();
            database = new Banco();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                await database.Database.CreateTableAsync<Musica>();

                string nome = nomeMusica.Text;
                string letra = letraMusica.Text;

                var musica = new Musica
                {
                    nomeMusica = nome,
                    letraMusica = letra
                };


                await database.Database.InsertAsync(musica);

                string text = "Música Adicionada!";
                ToastDuration duration = ToastDuration.Short;
                double fontSize = 14;
                var toast = Toast.Make(text, duration, fontSize);
                await toast.Show();

                nomeMusica.Text = string.Empty;
                letraMusica.Text = string.Empty;
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine($"SQLite Error: {ex.Message}");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            nomeMusica.Text = string.Empty;
            letraMusica.Text = string.Empty;
        }
    }
}
