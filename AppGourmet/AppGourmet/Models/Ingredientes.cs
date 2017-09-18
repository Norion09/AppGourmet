using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGourmet.Models
{
    public class Ingredientes
    {
        
        public string NomeIngrediente { get; set; }
        public decimal PrecoIngrediente { get; set; }
        public string PrecoFormatadoIngrediente
        {
            get
            {
                return string.Format("R$ {0}", PrecoIngrediente);
            }
        }
        
    }
}
/*
 *public List<string> IngredienteDoPrato { get; set; }
        public decimal PrecoIngrediente { get; set; }
        public string PrecoIngredienteFormatado
        {
            get
            {
                return string.Format("R$ {0}", PrecoIngrediente);
            }
        }
 */
