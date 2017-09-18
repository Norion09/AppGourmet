using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGourmet.Models;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;

namespace AppGourmet.ViewModels
{
    public class AdicionaisViewModel : BaseViewModel
    {
        public Pratos Pratos { get; set; }

       //public AdicionaisViewModel(Pratos pratos)
        //{
            //this.Pratos = pratos;
            /*
            ProximoCommand = new Command(() =>
            {
                MessagingCenter.Send(pratos, "Proximo");
            });
            */
       // }
        //-----------------------------------------------------------------------------------
        public string TextoBife      { get { return string.Format("Bife - R$ {0}",      Pratos.Bife);      } }
        public string TextoPresunto  { get { return string.Format("Presunto - R$ {0}",  Pratos.Presunto);  } }
        public string TextoMussarela { get { return string.Format("Mussarela - R$ {0}", Pratos.Mussarela); } }
        public string TextoOvo       { get { return string.Format("Ovo - R$ {0}",       Pratos.Ovo);       } }
        public string TextoBacon     { get { return string.Format("Bacon - R$ {0}",     Pratos.Bacon);     } }
        public string TextoCheddar   { get { return string.Format("Cheddar - R$ {0}",   Pratos.Cheddar);   } }
        public string TextoCalabresa { get { return string.Format("Calabresa - R$ {0}", Pratos.Calabresa); } }
        public string TextoCatupiri  { get { return string.Format("catupiri - R$ {0}",  Pratos.Catupiri);  } }
        //-----------------------------------------------------------------------------------
        public bool AdicionalBife
        {
            get {return Pratos.AdicionalBife; }
            set
            {
                Pratos.AdicionalBife = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool AdicionalPresunto
        {
            get { return Pratos.AdicionalPresunto; }
            set
            {
                Pratos.AdicionalPresunto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool AdicionalMussarela
        {
            get { return Pratos.AdicionalMussarela; }
            set
            {
                Pratos.AdicionalMussarela = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool AdicionalOvo
        {
            get { return Pratos.AdicionalOvo; }
            set
            {
                Pratos.AdicionalOvo = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool AdicionalBacon
        {
            get { return Pratos.AdicionalBacon; }
            set
            {
                Pratos.AdicionalBacon = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool AdicionalCheddar
        {
            get { return Pratos.AdicionalCheddar; }
            set
            {
                Pratos.AdicionalCheddar = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool AdicionalCalabresa
        {
            get { return Pratos.AdicionalCalabresa; }
            set
            {
                Pratos.AdicionalCalabresa = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public bool AdicionalCatupiri
        {
            get { return Pratos.AdicionalCatupiri; }
            set
            {
                Pratos.AdicionalCatupiri = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        //-----------------------------------------------------------------------------------
        public string ValorTotal
        {
            get
            {
                return Pratos.ValorTotalFormatado;
            }
        }
        //-----------------------------------------------------------------------------------
        public AdicionaisViewModel(Pratos prato)
        {
            this.Pratos = prato;

            AdicionarListaCommand = new Command(() =>
            {
                MessagingCenter.Send(this, "AdicionarLista");
            });
        }

        public ICommand AdicionarListaCommand { get; set; }


        private class CallerMenberNameAttribute : Attribute { }
    }
}
