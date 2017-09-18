using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGourmet.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGourmet.ViewModels;

namespace AppGourmet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdicionaisView : ContentPage
    {
        public Pratos Pratos { get; set; }

        public Usuario Usuario { get; set; }

        public AdicionaisView(Pratos prato, Usuario usuario)
        {
            InitializeComponent();
			this.Pratos = prato;
			this.Usuario = usuario;
			this.BindingContext = new AdicionaisViewModel(prato);
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();

			MessagingCenter.Subscribe<Pratos>(this, "AdicionarLista", (prato) =>
			{
				Navigation.PushAsync(new ListaDePedidosView(prato, this.Usuario));
			});
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			MessagingCenter.Unsubscribe<Pratos>(this, "AdicionarLista");
		}
    }
}