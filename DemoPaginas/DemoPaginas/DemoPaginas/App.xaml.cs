using DemoPaginas.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoPaginas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // por default
            //MainPage = new MainPage();

            // vista de tabs
            VistaTabbed vistaTabs = new VistaTabbed();

            // agregar contenido a las tabs
            MainPage mPage = new MainPage();
            mPage.Title = "Contenido";

            // agregando paginas de contenido a la tab
            vistaTabs.Children.Add(mPage);

            VistaFlyout vistaMaster = new VistaFlyout { 
                Detail = vistaTabs
            };

            // colocando la vista master detail como la principal del app
            MainPage = vistaMaster;

            //tbpInicial newTab = new tbpInicial();

            //MainPage mPage = new MainPage();
            //mPage.Title = "Inicial";

            //newTab.Children.Add(mPage);
            //newTab.Children.Add(new ContentPage
            //{
            //    Title = "tab2"
            //});

            //MainPage = newTab;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
