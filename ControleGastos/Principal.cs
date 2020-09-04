using ControleGastos.Entidades;
using ControleGastos.Models;
using ControleGastos.Report;
using ControleGastos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos
{
    public partial class Principal : Form
    {

        Lancamentos obj = new Lancamentos();
        public Principal()
        {
            InitializeComponent();
            totalizar();
            Listar();
        }

        private void totalizar()
        {
            decimal total = valorTotalEntradas() - valorTotalSaidas();

            lblTotalEntradas.Text = valorTotalEntradas().ToString();
            lblTotalSaidas.Text = valorTotalSaidas().ToString();
            lblTotalGeral.Text = total.ToString();

            if(Convert.ToDecimal(lblTotalGeral.Text) < 0)
            {
                lblTotalGeral.ForeColor = Color.Red;
            }
            else
            {
                lblTotalGeral.ForeColor = Color.Green;
            }
        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadAno_Click(object sender, EventArgs e)
        {
            frmCadAno frm = new frmCadAno();
            frm.ShowDialog();
        }

        private void btnCadLanc_Click(object sender, EventArgs e)
        {
            frmCadLanc frm = new frmCadLanc();
            frm.ShowDialog();
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            obj.Data = Convert.ToDateTime(dt.Text);
            //obj.Tipo = "Entrada";
            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancModel().BuscarDataTipoEntrada(obj);
            dgEntradas.AutoGenerateColumns = false;
            dgEntradas.DataSource = lista;

            List<Lancamentos> lista2 = new List<Lancamentos>();
            lista2 = new LancModel().BuscarDataTipoSaida(obj);
            dgSaidas.AutoGenerateColumns = false;
            dgSaidas.DataSource = lista2;
            totalizar();
        }

        private void Listar()
        {
            try
            {
                List<Lancamentos> lista = new List<Lancamentos>();

                dgEntradas.DataSource = lista;
                dgEntradas.Columns[0].Visible = false;
                dgEntradas.Columns[4].Visible = false;
                dgEntradas.Columns[5].Visible = false;
                //dgEntradas.Columns[6].Visible = false;
                dgEntradas.Columns[1].Visible = false;
                dgEntradas.Columns[1].HeaderText = "Tipo";
                dgEntradas.Columns[2].HeaderText = "Descrição";
                dgEntradas.Columns[3].HeaderText = "Valor";
                dgEntradas.Columns[6].HeaderText = "Data";

                dgEntradas.Columns[2].Width = 200;

                List<Lancamentos> lista2 = new List<Lancamentos>();

                dgSaidas.DataSource = lista;

                dgSaidas.DataSource = lista;
                dgSaidas.Columns[0].Visible = false;
                dgSaidas.Columns[4].Visible = false;
                dgSaidas.Columns[5].Visible = false;
                //dgSaidas.Columns[6].Visible = false;
                dgSaidas.Columns[1].Visible = false;
                dgSaidas.Columns[1].HeaderText = "Tipo";
                dgSaidas.Columns[2].HeaderText = "Descrição";
                dgSaidas.Columns[3].HeaderText = "Valor";
                dgSaidas.Columns[6].HeaderText = "Data";

                dgSaidas.Columns[2].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void dt_Enter(object sender, EventArgs e)
        {
            dt.Value = DateTime.Now;
        }

        private decimal valorTotalEntradas()
        {
            decimal total = 0;
            

            int i = 0;
            for (i = 0; i < dgEntradas.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgEntradas.Rows[i].Cells[3].Value);
               
            }
            return total;
        }

        private decimal valorTotalSaidas()
        {
            decimal total = 0;


            int i = 0;
            for (i = 0; i < dgSaidas.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgSaidas.Rows[i].Cells[3].Value);

            }
            return total;
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRelMensal_Click(object sender, EventArgs e)
        {
            frmRelMensal frm = new frmRelMensal();
            frm.ShowDialog();
        }
    }
}
