using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos.Report
{
    public partial class frmRelMensal : Form
    {
        public frmRelMensal()
        {
            InitializeComponent();
        }

        private void frmRelMensal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gastosDataSet.saidaValor'. Você pode movê-la ou removê-la conforme necessário.
            this.saidaValorTableAdapter.Fill(this.gastosDataSet.saidaValor);
            // TODO: esta linha de código carrega dados na tabela 'gastosDataSet.entradaValor'. Você pode movê-la ou removê-la conforme necessário.
            this.entradaValorTableAdapter.Fill(this.gastosDataSet.entradaValor);
            // TODO: esta linha de código carrega dados na tabela 'gastosDataSet1.entradaValor'. Você pode movê-la ou removê-la conforme necessário.
            this.entradaValorTableAdapter.Fill(this.gastosDataSet1.entradaValor);
            // TODO: esta linha de código carrega dados na tabela 'gastosDataSet.lancamento_ano'. Você pode movê-la ou removê-la conforme necessário.
            this.lancamento_anoTableAdapter.Fill(this.gastosDataSet.lancamento_ano, cbMes.Text);            

            this.reportViewer1.RefreshReport();
        }

        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lancamento_anoTableAdapter.Fill(this.gastosDataSet.lancamento_ano, cbMes.Text);

            this.reportViewer1.RefreshReport();
        }

        private void entradaValorBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
