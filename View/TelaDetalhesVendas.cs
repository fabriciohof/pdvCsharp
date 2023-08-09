using ControleVendas.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.View
{
    public partial class TelaDetalhesVendas : Form
    {
        int venda_id;
        public TelaDetalhesVendas(int vendaId)
        {
            venda_id = vendaId;
            InitializeComponent();
        }

        private void TelaDetalhesVendas_Load(object sender, EventArgs e)
        {
            ItemVendaDAO itemVendaDAO = new ItemVendaDAO(); 
            tblDetalhes.DataSource = itemVendaDAO.listarItensPorVenda(venda_id);
        }
    }
}
