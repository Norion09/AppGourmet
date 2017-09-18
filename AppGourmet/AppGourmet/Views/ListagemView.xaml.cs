using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppGourmet.Models;
using AppGourmet.ViewModels;

namespace AppGourmet.Views
{
    public partial class ListagemView : ContentPage
    {
        public ListagemViewModel ViewModel { get; set; }
        readonly Usuario usuario;

        public ListagemView(Usuario usuario)
        {
            InitializeComponent();
            this.ViewModel = new ListagemViewModel();
            this.usuario = usuario;
            this.BindingContext = this.ViewModel;
        }

        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Pratos>(this, "PratoSelecionado", 
                                              (pratos) =>
                {
                Navigation.PushAsync(new AdicionaisView(pratos,usuario));
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<Pratos>(this, "PratoSelecionado");
        }
    }
}
