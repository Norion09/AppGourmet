using System;
using System.Collections.Generic;
using SQLite;
using SQLitePCL;
namespace AppGourmet.Models
{
    public class ListaDePedidos
    {
		[PrimaryKey, AutoIncrement]

		public int ID { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
        public string Pedidos { get; set; }
		public decimal Preco { get; set; }
		public bool Confirmado { get; set; }

        DateTime dataDoPedido = DateTime.Today; // pega o dia atual
        public DateTime DataDoPedido
        {
            get { return dataDoPedido; }
            set { dataDoPedido = value; }
        }

        public TimeSpan horaDoPedidoFormatada { get; set; } //data e ora formatada
        public string HoraDoPedidoFormatada
        {
            get { return horaDoPedidoFormatada.Add(horaDoPedidoFormatada).ToString("dd/MM/yyyy HH:mm"); }
        }

        public ListaDePedidos()
        {
        }
    }
}
