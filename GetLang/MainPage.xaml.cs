namespace GetLang
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void Btn_add(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CriarMusica());
        }

    }
}