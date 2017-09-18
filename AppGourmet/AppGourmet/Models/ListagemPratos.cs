using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGourmet;

namespace AppGourmet.Models
{
    public class ListagemPratos
    {
        public List<Pratos> Pratos { get; private set; }

        //--------------------------------------------------------------------------

        public ListagemPratos()
        {
            this.Pratos = new List<Pratos>()
            {
                new Pratos { Nome = "X-Burger", Preco = 10, ImageLanche="Burger.png",
                    TemPão = true, TemBife = true, TemPresunto = true, TemSalada = true,TemBacon=false,
                    TemCalabresa=false,TemOvo=true,TemCheddar=false,TemCatupiri=false,TemMussarela=false,
                    IngredientesPrato={}},
				new Pratos { Nome = "X-Bacon", Preco = 13, ImageLanche="Burger.png",
                    TemPão = true, TemBife = true, TemPresunto = true, TemSalada = true,TemBacon=true,
					TemCalabresa=false,TemOvo=true,TemCheddar=false,TemCatupiri=false,TemMussarela=false,
					IngredientesPrato={}},
				new Pratos { Nome = "X-EggBacon", Preco = 14, ImageLanche="Burger.png",
					TemPão = true, TemBife = true, TemPresunto = true, TemSalada = true,TemBacon=true,
					TemCalabresa=false,TemOvo=true,TemCheddar=false,TemCatupiri=false,TemMussarela=true,
					IngredientesPrato={}},
				new Pratos { Nome = "X-Tudo", Preco = 16, ImageLanche="Burger.png",
					TemPão = true, TemBife = true, TemPresunto = true, TemSalada = true,TemBacon=true,
					TemCalabresa=true,TemOvo=true,TemCheddar=false,TemCatupiri=false,TemMussarela=false,
					IngredientesPrato={}},
				new Pratos { Nome = "X-Cheddar", Preco = 19, ImageLanche="Burger.png",
					TemPão = true, TemBife = true, TemPresunto = true, TemSalada = true,TemBacon=true,
					TemCalabresa=true,TemOvo=true,TemCheddar=true,TemCatupiri=false,TemMussarela=false,
					IngredientesPrato={}},
            };
        }
    }
}

/*
 * 
            /*
            Pratos XBurger = new Pratos();
            XBurger.Nome = "X-Burger";
            XBurger.Preco = 10;
            XBurger.ImageURL = "https://cdn5.bobsfa.com.br/assets/cardapio/produtos/picanha-barbecue-100g.g.png";
            XBurger.Ingrediente.Add("Pão");
            Pratos.Add(XBurger);
            /*
            Pratos XEggBurger = new Pratos();
            XBurger.Nome = "X-EggBurger";
            XBurger.Preco = 13;
            XBurger.ImageURL = "https://cdn5.bobsfa.com.br/assets/cardapio/produtos/picanha-barbecue-100g.g.png";
            //XBurger.IngredienteDoPrato.Add(Bife);
            Pratos.Add(XEggBurger);
            */
/*
this.Adicionais = new List<Ingredientes>()
{
    new Ingredientes {NomeIngrediente = "Bife",PrecoIngrediente = 1.5m },
    new Ingredientes {NomeIngrediente = "Presunte",PrecoIngrediente = 1.5m },
    new Ingredientes {NomeIngrediente = "Mussarela",PrecoIngrediente = 2 },
    new Ingredientes {NomeIngrediente = "Ovo",PrecoIngrediente = 1 },
    new Ingredientes {NomeIngrediente = "Bacon",PrecoIngrediente =2.5m },
    new Ingredientes {NomeIngrediente = "Cheddar",PrecoIngrediente = 2 },
    new Ingredientes {NomeIngrediente = "Calabresa", PrecoIngrediente = 2 },
    new Ingredientes {NomeIngrediente = "Catpiri", PrecoIngrediente = 1.5m },
};
*/
/*
 * this.Pratos = new List<Pratos>()
            { 
                new Pratos { Nome = "X-Burger", Preco = 10, ImageURL="picanha-barbecue-100g.g.png"
                ,IngredientePrato = new List<string>()
                {"Pão", "Bife", "Presunto", "Mussarela", "Ovo", "Bacon", "Cheddar", "Calabresa", "Catupiri", "Salada",},
                //IngredientePrato = Ingredientes.Add()},
                new Pratos { Nome = "X-Bacon", Preco = 13, ImageURL="picanha-barbecue-100g.g.png" },
                new Pratos { Nome = "X-EggBacon", Preco = 14, ImageURL="picanha-barbecue-100g.g.png" },
                new Pratos { Nome = "X-Tudo", Preco = 16, ImageURL="picanha-barbecue-100g.g.png" },
                new Pratos { Nome = "X-Cheddar", Preco = 19, ImageURL="picanha-barbecue-100g.g.png" }, 
            };
 */
/*
            this.Ingredientes = new List<Ingredientes>()
            { 
                new Ingredientes {NomeIngrediente = "Pão"},
                new Ingredientes {NomeIngrediente = "Bife"},
                new Ingredientes {NomeIngrediente = "Presunte"},
                new Ingredientes {NomeIngrediente = "Mussarela"},
                new Ingredientes {NomeIngrediente = "Calabresa"},
                new Ingredientes {NomeIngrediente = "Ovo"},
                new Ingredientes {NomeIngrediente = "Salada(Alface e Tomate)"},
                new Ingredientes {NomeIngrediente = "Bacon"},
                new Ingredientes {NomeIngrediente = "Cheddar"},
                
            };
*/
