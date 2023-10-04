namespace GetLang
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void btn_add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CriarMusica());
        }

    }
}