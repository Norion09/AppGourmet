using AppGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppGourmet.ViewModels
{
    public class ListagemViewModel
    {
        public List<Pratos> Pratos { get; set; }

        Pratos pratoSelecionado;

        public Pratos PratoSelecionado
        {
            get
            {
                return pratoSelecionado;
            }
            set
            {
                pratoSelecionado = value;
                if (value != null)
                    MessagingCenter.Send(pratoSelecionado, "PratoSelecionado");
            }
        }

        public string DetailIngredientePrato
        {
            get
            {
                return pratoSelecionado.IngredientesPrato;
            }
        }

        public ListagemViewModel()
        {
            this.Pratos = new ListagemPratos().Pratos;
        }
    }
}
