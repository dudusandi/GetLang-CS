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
        }

        async void Btn_add(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CriarMusica());
        }

      
        
    }
}
