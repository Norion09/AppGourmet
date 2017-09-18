using System;
using System.Collections.Generic;
using AppGourmet.Models;
using AppGourmet.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppGourmet.Views
{   [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ListaDePedidosView : ContentPage
	{

		public ListaDePedidosViewModel ViewModel { get; set; }

        public ListaDePedidosView(Pratos prato, Usuario usuario)
        {
            InitializeComponent();
            this.ViewModel = new ListaDePedidosViewModel();
            this.BindingContext = this.ViewModel;
        }
    }
}
