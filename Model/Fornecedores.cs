using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.Model
{
    public class Fornecedores : Clientes     // herdando os atributos da classe clientes
    {
        public string cnpj { get; set; }

    }
}
