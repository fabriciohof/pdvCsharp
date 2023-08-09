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
    public partial class TelaHistoricoVendas : Form
    {
        public TelaHistoricoVendas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;
            VendaDAO vendaDAO = new VendaDAO();

            dataInicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            dataFim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            tblHistorico.DataSource = vendaDAO.RetornarVendasPorPeriodo(dataInicio, dataFim);



        }

        private void TelaHistoricoVendas_Load(object sender, EventArgs e)
        {
            VendaDAO vendaDAO = new VendaDAO();
            tblHistorico.DataSource = vendaDAO.listarVendas();

        }

        private void tblHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //passando id da venda pelo construtor
            int vendaId = int.Parse(tblHistorico.CurrentRow.Cells[0].Value.ToString());
            TelaDetalhesVendas tela = new TelaDetalhesVendas(vendaId);


            //formatar a data para aparecer apenas o dia ano e mes
            DateTime  DataVenda = Convert.ToDateTime(tblHistorico.CurrentRow.Cells[1].Value.ToString());

            tela.txtData.Text = DataVenda.ToString("dd/MM/yyyy");
            tela.txtCliente.Text = tblHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = tblHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = tblHistorico.CurrentRow.Cells[4].Value.ToString();

            tela.ShowDialog();

        }
    }
}
