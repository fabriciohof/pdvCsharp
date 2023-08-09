using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.Model
{
    public class Produtos
    {
        //prop TAB TAB 
        public int id { get; set; }

        public string descricao { get; set; }

        public decimal preco { get; set; }

        public int estoque { get; set; } 


        //chave estrangeira de fornecedor
        public int for_id { get; set; } 

    }
}
