using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppGourmet.Models
{
    public class Pratos
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", Preco);
            }
        }
       
        public ImageSource ImageLanche { get; set; }

        //------------------------------------------------------------------------------------

        public string ValorTotalFormatado
        {
            get
            {
                return string.Format("Preço total do Pedido R$ {0}", Preco +
                    (AdicionalBife      ? Bife      : 0) +
                    (AdicionalPresunto  ? Presunto  : 0) +
                    (AdicionalMussarela ? Mussarela : 0) +
                    (AdicionalOvo       ? Ovo       : 0) +
                    (AdicionalBacon     ? Bacon     : 0) +
                    (AdicionalCheddar   ? Cheddar   : 0) +
                    (AdicionalCalabresa ? Calabresa : 0) +
                    (AdicionalCatupiri  ? Catupiri  : 0));
            }
        }

        //ingredientes------------------------------------------------------------------------

        public bool AdicionalBife      { get; set; }
        public bool AdicionalPresunto  { get; set; }
        public bool AdicionalMussarela { get; set; }
        public bool AdicionalOvo       { get; set; }
        public bool AdicionalBacon     { get; set; }
        public bool AdicionalCheddar   { get; set; }
        public bool AdicionalCalabresa { get; set; }
        public bool AdicionalCatupiri  { get; set; }

        public decimal Pão = 0;
        public decimal Bife = 2m;
        public decimal Presunto = 1.5m;
        public decimal Mussarela = 2;
        public decimal Ovo = 1;
        public decimal Bacon = 2.5m;
        public decimal Cheddar = 2;
        public decimal Calabresa = 2;
        public decimal Catupiri = 1.5m;
        public decimal Salada = 0;

		//Detail------------------------------------------------------------------------------

		public bool TemPão       { get; set; }
        public bool TemBife      { get; set; }
        public bool TemPresunto  { get; set; }
        public bool TemMussarela { get; set; }
        public bool TemOvo       { get; set; }
        public bool TemBacon     { get; set; }
        public bool TemCheddar   { get; set; }
        public bool TemCalabresa { get; set; }
        public bool TemCatupiri  { get; set; }
        public bool TemSalada    { get; set; }

        public string IngredientesPrato
        {
            get
            {
                List<string> Ingredientes = new List<string>();
                if (TemPão)      { Ingredientes.Add("Pão, ");            }
                if (TemBife)     { Ingredientes.Add("Bife, ");           }
                if (TemPresunto) { Ingredientes.Add("Presunto, ");       }
                if (TemMussarela){ Ingredientes.Add("Mussarela, ");      }
                if (TemOvo)      { Ingredientes.Add("Ovo, ");            }
                if (TemBacon)    { Ingredientes.Add("Bacon, ");          }
                if (TemCheddar)  { Ingredientes.Add("Cheddar, ");        }
                if (TemCalabresa){ Ingredientes.Add("Calabresa, ");      }
                if (TemCatupiri) { Ingredientes.Add("Catupiri, ");       }
                if (TemSalada)   { Ingredientes.Add("Alface, Tomate."); }
                return string.Join(" ", Ingredientes);
                /*string ingredientes="";
                foreach(string ingrediente in Ingredientes)
                {
                    ingredientes += ingrediente + ", ";
                    ingredientes = ingrediente.TrimEnd(',') + ".";

                }
                return ingredientes;*/
            }
            set{}
        }
		//----------------------------------------------------------------------------------
	}
}

//"Pão","Bife","Presunto","Mussarela","Ovo","Bacon","Cheddar","Calabresa","Catupiri","Salada"
/*
public bool TemAPão { get; set; }
        public bool TemBife { get; set; }
        public bool TemPresunto { get; set; }
        public bool TemMussarela { get; set; }
        public bool TemOvo { get; set; }
        public bool TemBacon { get; set; }
        public bool TemCheddar { get; set; }
        public bool TemCalabresa { get; set; }
        public bool TemCatupiri { get; set; }
        public bool TemSalada { get; set; }
*/
/*
tring Ingrediente = "";
                return for (int i = 0; i < Ingredientes.Count; i++)
                {
                    string ingrediente = Ingredientes[i];
                    Ingrediente = Ingrediente.TrimEnd(',') + ".";
                }
*/
