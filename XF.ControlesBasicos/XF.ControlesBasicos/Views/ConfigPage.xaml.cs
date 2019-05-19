using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            InitializeComponent();

            App.ReceberEmail = SwitchEmail.IsToggled;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            EntryEmail.IsVisible = SwitchEmail.IsToggled;
            if (!SwitchEmail.IsToggled) EntryEmail.Text = string.Empty;
            App.ReceberEmail = SwitchEmail.IsToggled;
        }

        private void EntryEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            App.Email = e.NewTextValue;
        }
    }
}