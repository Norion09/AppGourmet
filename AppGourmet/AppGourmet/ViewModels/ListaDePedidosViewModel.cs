using System;
namespace AppGourmet.ViewModels
{
    public class ListaDePedidosViewModel : BaseViewModel
    {
        public ListaDePedidosViewModel ListaDePedidos { get; set; }

        public string Pedidos
        {
            get { return this.ListaDePedidos.Pedidos; }
			set { this.ListaDePedidos.Pedidos = value; }
        }

		public string Nome
		{
			get
			{
				return ListaDePedidos.Nome;
			}
			set
			{
				ListaDePedidos.Nome = value;
				OnPropertyChanged();
				//((Command)ProximoCommand).ChangeCanExecute();
			}
		}
		public string Email
		{
			get
			{
				return ListaDePedidos.Email;
			}
			set
			{
				ListaDePedidos.Email = value;
				OnPropertyChanged();
				//((Command)ProximoCommand).ChangeCanExecute();
			}
		}
		public string Telefone
		{
			get
			{
				return ListaDePedidos.Telefone;
			}
			set
			{
				ListaDePedidos.Telefone = value;
				OnPropertyChanged();
				//((Command)ProximoCommand).ChangeCanExecute();
			}
		}

        public ListaDePedidosViewModel()
        {
        }
    }
}
