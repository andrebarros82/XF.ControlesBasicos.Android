using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.ControlesBasicos.Views;

namespace XF.ControlesBasicos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonEnviar_Clicked(object sender, EventArgs e)
        {
            string msg = App.ReceberEmail ? $"E-mail enviado para {App.Email}" : "E-mail não autorizado";
            DisplayAlert("Prática 1", msg, "OK");
        }

        private void ButtonConfiguracao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage());
        }
    }
}
