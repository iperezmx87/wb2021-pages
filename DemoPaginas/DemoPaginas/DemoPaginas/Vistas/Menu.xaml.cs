using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoPaginas.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // acceder a la vista principal del app
            ((VistaFlyout)App.Current.MainPage).Detail = new VistaTabbed();
            ((VistaFlyout)App.Current.MainPage).IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ((VistaFlyout)App.Current.MainPage).Detail = new NavigationPage(new ContentPage());
            ((VistaFlyout)App.Current.MainPage).IsPresented = false;
        }
    }
}